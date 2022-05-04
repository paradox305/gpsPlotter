using System;
using System.IO;
using System.IO.Ports;
using System.Windows.Forms;
using System.Threading;
using System.Text;
using System.Diagnostics;

namespace Logger
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            #region Port Scanning
            // Get a list of serial port names.
            string[] ports = SerialPort.GetPortNames();
            Console.WriteLine("#########################################################");
            Console.WriteLine("The following serial ports were found:");
            // Display each port name to the console.
            foreach (string port in ports)
            {
                System.Console.WriteLine("Ports Available:");
                System.Console.WriteLine(port);
                System.Console.WriteLine("#########################################################");
                PortBox.Items.Add(port);
            }
            #endregion
            #region Default Values On Load
            mode = "Logging";
            onlyPosition.Enabled = true;
            positionSpeed.Enabled = true;
            positionAltitude.Enabled = true;
            intervalTime.Enabled = true;
            inputIntervalTime.Enabled = true;
            PortBox.Enabled = true;
            exportLabel.Enabled = true;
            startButton.Enabled = true;
            stopButton.Enabled = false;
            onlyPosition.Checked = true;
            format = "1";
            inputIntervalTime.Text = "1";
            exportLabel.Text = baseDirectoryName;
            visualizeButton.Enabled = false;
            #endregion
            // Install a new output TextWriter for the Console window.
           
        }

        #region Global Variables
        public string mode;
        public string format;
        public string interval;
        public int convertedInterval;
        public string redFlag = "Please select mode Data Logger";
        public string statusCode;
        public string baseDirectoryName = @"E:\GPS\Logger\out\out.txt";
        public string DirectoryName;
        private SerialPort SP;

        #endregion
        #region ConsoleWriter
        public class TextBoxWriter : TextWriter
        {

            // The control where we will write text.
            private Control MyControl;
            public TextBoxWriter(Control control)
            {
                MyControl = control;
            }
            
            public override void Write(char value)
            {
                MyControl.Text += value;
            }

            public override void Write(string value)
            {
                MyControl.Text += value;
            }

            public override Encoding Encoding
            {
                get { return Encoding.Unicode; }
            }
        }
        #endregion
        #region Port Connection
        public void makePort(string port, string statusCode)
        {
            try
            {
                if (statusCode == "Start")
                {
                    System.Console.WriteLine("Making Port availabe for Communication..");
                    Thread send_data = new Thread(Thread_send_data);
                    Thread getdata_serial = new Thread(Thread_getdata);
                    SP = new SerialPort();
                    SP.PortName = port;
                    SP.BaudRate = 9600;
                    SP.Open();
                    Console.WriteLine("Port Opened.");
                    getdata_serial.Start();
                    Console.WriteLine("Thread 1 initilized.");
                    send_data.Start();
                    Console.WriteLine("Thread 2 initilized.");
                }
                else if (statusCode == "Stop")
                {
                    SP.Close();
                    Console.WriteLine("Port Closed.");
                }
                else
                {
                    SP.Close();
                }
            }
            catch (Exception)
            {
                SP.Close();
                Console.WriteLine("Port Closed.");
                Console.WriteLine("Exception at Making Port.");
            }
            
        }
        #endregion
        #region Data: Send, Recieve and Save through SerialPort
        public void Thread_getdata()
        {
            try
            {

                using (StreamWriter sw = new StreamWriter(baseDirectoryName))
                do
                {
                   
                            sw.WriteLine(SP.ReadLine());
                            Console.WriteLine(DateTime.Now.ToString("mm:ss : " + SP.ReadLine()));
                            //Form here sample data:

                          //  sw.WriteLine("27.111, 20.322");
                          //  Console.WriteLine("27.111, 20.322");
                           Thread.Sleep(convertedInterval*1150);                  
                        
                   
                } while (statusCode == "Start");
                string data = File.ReadAllText(baseDirectoryName);
                string withHeader = "lat,lng\n" +data;
                File.WriteAllText(baseDirectoryName, withHeader);
            }
            catch (Exception)
            {
                SP.Close();
                Console.WriteLine("Port Closed.");
                Console.WriteLine("Exception I/O Occurred here!");
            }

        }

        public void Thread_send_data()
        {

            try
            {
                do
                {
                   SP.WriteLine(format);
                    Thread.Sleep(100);
                } while (statusCode == "Start");
                
            }
            catch (Exception )
            {
                Console.WriteLine("Exception I/O Occurred here!");
            }
            
        }
        #endregion
        public void loggingFormat_Enter(object sender, EventArgs e)
        {

        }

        private void modeDataLogger_CheckedChanged(object sender, EventArgs e)
        {
            #region DataLogger
            mode = "Logging";
            format = "1";
            exportLabel.Text = baseDirectoryName;
            onlyPosition.Enabled = true;
            positionSpeed.Enabled = true;
            positionAltitude.Enabled = true;
            intervalTime.Enabled = true;
            inputIntervalTime.Enabled = true;
            PortBox.Enabled = true;
            exportLabel.Enabled = true;
            startButton.Enabled = true;
            stopButton.Enabled = false;
            visualizeButton.Enabled = false;
            #endregion
        }

        public void modeVisualizer_CheckedChanged(object sender, EventArgs e)
        {
            #region Visualizer
            mode = "Visualizing";
            onlyPosition.Enabled = false;
            positionSpeed.Enabled = false;
            positionAltitude.Enabled = false;
            intervalTime.Enabled = false;
            inputIntervalTime.Enabled = false;
            inputIntervalTime.Text = "";
            format = redFlag;
            startButton.Enabled = false;
            stopButton.Enabled = false;
            PortBox.Enabled = false;
            exportLabel.Enabled = false;
            visualizeButton.Enabled = true;
            #endregion
        }

        private void onlyPosition_CheckedChanged(object sender, EventArgs e)
        {
            format = "1";
        }

        private void positionSpeed_CheckedChanged(object sender, EventArgs e)
        {
            format = "2";
        }

        private void positionAltitude_CheckedChanged(object sender, EventArgs e)
        {
            format = "3";
        }

        private void inputIntervalTime_TextChanged(object sender, EventArgs e)
        {
            if (inputIntervalTime.Text == "")
            {
                inputIntervalTime.Text = "1";
                interval = intervalTime.Text;
            }
            else
            {
                interval = intervalTime.Text;
            }
        }



        public void Start_Click(object sender, EventArgs e)
        {
            #region Validate And Submit
            if (PortBox.Text == "")
            {
                Console.WriteLine($"Please Select Port");
            }
            if  (exportLabel.Text == "")
            {
                Console.WriteLine($"Please Select File Location");
            }
            else
            {
                statusCode = "Start";
                interval = inputIntervalTime.Text;
                convertedInterval = Convert.ToInt16(interval);
                #region Console_ouptut
                Console.WriteLine($"Process Started");
                Console.WriteLine($"Mode: {mode} ");
                Console.WriteLine($"Format to log data: {format} ");
                Console.WriteLine($"Interval : {interval} Seconds ");
                Console.WriteLine($"Port: {PortBox.Text} ");
                Console.WriteLine($"Export Path : {exportLabel.Text} ");
                #endregion
                makePort(PortBox.Text, statusCode);
                #region Button_Conditions_disable
                onlyPosition.Enabled = false;
                positionSpeed.Enabled = false;
                positionAltitude.Enabled = false;
                intervalTime.Enabled = false;
                inputIntervalTime.Enabled = false;
                startButton.Enabled = false;
                stopButton.Enabled = true;
                modeVisualizer.Enabled = false;
                #endregion
            }
            #endregion
        }

        public void stopButton_Click(object sender, EventArgs e)
        {
            #region Stop Button
            statusCode = "Stop";
            makePort(PortBox.Text, statusCode);
            onlyPosition.Enabled = true;
            positionSpeed.Enabled = true;
            positionAltitude.Enabled = true;
            intervalTime.Enabled = true;
            inputIntervalTime.Enabled = true;
            PortBox.Enabled = true;
            stopButton.Enabled = false;
            startButton.Enabled = true;
            modeVisualizer.Enabled = true;
            visualizeButton.Enabled = false;
            Console.WriteLine($"Process Stopped");
            Console.WriteLine("#########################################################");
            #endregion

        }

        private void visualizeButton_Click(object sender, EventArgs e)
        {
            // Open Browser at specified url
            System.Diagnostics.Process.Start(Environment.CurrentDirectory + "/Webview/index.html");
        }

        private void export_Click(object sender, EventArgs e)
        {
            // Displays a SaveFileDialog so the user can save the Image
            // assigned to Button2.
            SaveFileDialog saveFileDialog1 = new SaveFileDialog();
            saveFileDialog1.Filter = "csv File|*.csv";
            saveFileDialog1.Title = "Save a data File";
            saveFileDialog1.ShowDialog();
            exportLabel.Text = saveFileDialog1.FileName;
            baseDirectoryName = saveFileDialog1.FileName;
        }

        private void exportLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
