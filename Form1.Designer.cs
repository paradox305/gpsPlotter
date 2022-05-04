
namespace Logger
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.operationMode = new System.Windows.Forms.GroupBox();
            this.modeVisualizer = new System.Windows.Forms.RadioButton();
            this.modeDataLogger = new System.Windows.Forms.RadioButton();
            this.loggingFormat = new System.Windows.Forms.GroupBox();
            this.positionAltitude = new System.Windows.Forms.RadioButton();
            this.positionSpeed = new System.Windows.Forms.RadioButton();
            this.onlyPosition = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.inputIntervalTime = new System.Windows.Forms.TextBox();
            this.intervalTime = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.PortBox = new System.Windows.Forms.ComboBox();
            this.stopButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.exportLabel = new System.Windows.Forms.TextBox();
            this.visualizeButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.export = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.operationMode.SuspendLayout();
            this.loggingFormat.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // operationMode
            // 
            this.operationMode.Controls.Add(this.modeVisualizer);
            this.operationMode.Controls.Add(this.modeDataLogger);
            this.operationMode.Location = new System.Drawing.Point(14, 13);
            this.operationMode.Name = "operationMode";
            this.operationMode.Size = new System.Drawing.Size(180, 108);
            this.operationMode.TabIndex = 0;
            this.operationMode.TabStop = false;
            this.operationMode.Text = "Operation Mode";
            // 
            // modeVisualizer
            // 
            this.modeVisualizer.AutoSize = true;
            this.modeVisualizer.Location = new System.Drawing.Point(7, 54);
            this.modeVisualizer.Name = "modeVisualizer";
            this.modeVisualizer.Size = new System.Drawing.Size(74, 18);
            this.modeVisualizer.TabIndex = 1;
            this.modeVisualizer.Text = "Visualizer";
            this.modeVisualizer.UseVisualStyleBackColor = true;
            this.modeVisualizer.CheckedChanged += new System.EventHandler(this.modeVisualizer_CheckedChanged);
            // 
            // modeDataLogger
            // 
            this.modeDataLogger.AutoSize = true;
            this.modeDataLogger.Checked = true;
            this.modeDataLogger.Location = new System.Drawing.Point(7, 20);
            this.modeDataLogger.Name = "modeDataLogger";
            this.modeDataLogger.Size = new System.Drawing.Size(89, 18);
            this.modeDataLogger.TabIndex = 0;
            this.modeDataLogger.TabStop = true;
            this.modeDataLogger.Text = "Data Logger";
            this.modeDataLogger.UseVisualStyleBackColor = true;
            this.modeDataLogger.CheckedChanged += new System.EventHandler(this.modeDataLogger_CheckedChanged);
            // 
            // loggingFormat
            // 
            this.loggingFormat.Controls.Add(this.positionAltitude);
            this.loggingFormat.Controls.Add(this.positionSpeed);
            this.loggingFormat.Controls.Add(this.onlyPosition);
            this.loggingFormat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.loggingFormat.Location = new System.Drawing.Point(200, 13);
            this.loggingFormat.Name = "loggingFormat";
            this.loggingFormat.Size = new System.Drawing.Size(254, 108);
            this.loggingFormat.TabIndex = 2;
            this.loggingFormat.TabStop = false;
            this.loggingFormat.Text = "Data Logging Format";
            this.loggingFormat.Enter += new System.EventHandler(this.loggingFormat_Enter);
            // 
            // positionAltitude
            // 
            this.positionAltitude.AutoSize = true;
            this.positionAltitude.Location = new System.Drawing.Point(7, 70);
            this.positionAltitude.Name = "positionAltitude";
            this.positionAltitude.Size = new System.Drawing.Size(147, 18);
            this.positionAltitude.TabIndex = 3;
            this.positionAltitude.Text = "Position, Time, Altitude";
            this.positionAltitude.UseVisualStyleBackColor = true;
            this.positionAltitude.CheckedChanged += new System.EventHandler(this.positionAltitude_CheckedChanged);
            // 
            // positionSpeed
            // 
            this.positionSpeed.AutoSize = true;
            this.positionSpeed.Location = new System.Drawing.Point(7, 45);
            this.positionSpeed.Name = "positionSpeed";
            this.positionSpeed.Size = new System.Drawing.Size(99, 18);
            this.positionSpeed.TabIndex = 2;
            this.positionSpeed.Text = "Position, Time";
            this.positionSpeed.UseVisualStyleBackColor = true;
            this.positionSpeed.CheckedChanged += new System.EventHandler(this.positionSpeed_CheckedChanged);
            // 
            // onlyPosition
            // 
            this.onlyPosition.AutoSize = true;
            this.onlyPosition.Checked = true;
            this.onlyPosition.Location = new System.Drawing.Point(7, 20);
            this.onlyPosition.Name = "onlyPosition";
            this.onlyPosition.Size = new System.Drawing.Size(96, 18);
            this.onlyPosition.TabIndex = 1;
            this.onlyPosition.TabStop = true;
            this.onlyPosition.Text = "Only Position";
            this.onlyPosition.UseVisualStyleBackColor = true;
            this.onlyPosition.CheckedChanged += new System.EventHandler(this.onlyPosition_CheckedChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.inputIntervalTime);
            this.groupBox1.Controls.Add(this.intervalTime);
            this.groupBox1.Location = new System.Drawing.Point(14, 127);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 102);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Data Logging Interval";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(186, 34);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 14);
            this.label1.TabIndex = 4;
            this.label1.Text = "seconds";
            // 
            // inputIntervalTime
            // 
            this.inputIntervalTime.Location = new System.Drawing.Point(91, 31);
            this.inputIntervalTime.Name = "inputIntervalTime";
            this.inputIntervalTime.Size = new System.Drawing.Size(89, 21);
            this.inputIntervalTime.TabIndex = 3;
            this.inputIntervalTime.TextChanged += new System.EventHandler(this.inputIntervalTime_TextChanged);
            // 
            // intervalTime
            // 
            this.intervalTime.AutoSize = true;
            this.intervalTime.Checked = true;
            this.intervalTime.Location = new System.Drawing.Point(7, 31);
            this.intervalTime.Name = "intervalTime";
            this.intervalTime.Size = new System.Drawing.Size(66, 18);
            this.intervalTime.TabIndex = 2;
            this.intervalTime.TabStop = true;
            this.intervalTime.Text = "By Time";
            this.intervalTime.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.PortBox);
            this.groupBox2.Location = new System.Drawing.Point(261, 127);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(193, 102);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Ports";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 31);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(118, 14);
            this.label3.TabIndex = 1;
            this.label3.Text = "Select Available Ports";
            // 
            // PortBox
            // 
            this.PortBox.FormattingEnabled = true;
            this.PortBox.Location = new System.Drawing.Point(14, 60);
            this.PortBox.Name = "PortBox";
            this.PortBox.Size = new System.Drawing.Size(113, 22);
            this.PortBox.TabIndex = 0;
            // 
            // stopButton
            // 
            this.stopButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.stopButton.Enabled = false;
            this.stopButton.Location = new System.Drawing.Point(336, 12);
            this.stopButton.Name = "stopButton";
            this.stopButton.Size = new System.Drawing.Size(87, 25);
            this.stopButton.TabIndex = 4;
            this.stopButton.Text = "Stop";
            this.stopButton.UseVisualStyleBackColor = true;
            this.stopButton.Click += new System.EventHandler(this.stopButton_Click);
            // 
            // startButton
            // 
            this.startButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.startButton.Location = new System.Drawing.Point(243, 12);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(87, 25);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.Start_Click);
            // 
            // exportLabel
            // 
            this.exportLabel.Location = new System.Drawing.Point(87, 16);
            this.exportLabel.Name = "exportLabel";
            this.exportLabel.ReadOnly = true;
            this.exportLabel.Size = new System.Drawing.Size(150, 21);
            this.exportLabel.TabIndex = 10;
            this.exportLabel.TextChanged += new System.EventHandler(this.exportLabel_TextChanged);
            // 
            // visualizeButton
            // 
            this.visualizeButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.visualizeButton.Location = new System.Drawing.Point(243, 43);
            this.visualizeButton.Name = "visualizeButton";
            this.visualizeButton.Size = new System.Drawing.Size(87, 25);
            this.visualizeButton.TabIndex = 11;
            this.visualizeButton.Text = "Visualize";
            this.visualizeButton.UseVisualStyleBackColor = true;
            this.visualizeButton.Click += new System.EventHandler(this.visualizeButton_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.export);
            this.panel1.Controls.Add(this.visualizeButton);
            this.panel1.Controls.Add(this.stopButton);
            this.panel1.Controls.Add(this.exportLabel);
            this.panel1.Controls.Add(this.startButton);
            this.panel1.Location = new System.Drawing.Point(14, 235);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(440, 88);
            this.panel1.TabIndex = 6;
            // 
            // export
            // 
            this.export.Location = new System.Drawing.Point(6, 16);
            this.export.Name = "export";
            this.export.Size = new System.Drawing.Size(75, 23);
            this.export.TabIndex = 12;
            this.export.Text = "Export";
            this.export.UseVisualStyleBackColor = true;
            this.export.Click += new System.EventHandler(this.export_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(473, 336);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.loggingFormat);
            this.Controls.Add(this.operationMode);
            this.Font = new System.Drawing.Font("Microsoft JhengHei UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.Text = "GPS Logger And Visualizer";
            this.operationMode.ResumeLayout(false);
            this.operationMode.PerformLayout();
            this.loggingFormat.ResumeLayout(false);
            this.loggingFormat.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox operationMode;
        private System.Windows.Forms.RadioButton modeVisualizer;
        private System.Windows.Forms.RadioButton modeDataLogger;
        private System.Windows.Forms.GroupBox loggingFormat;
        private System.Windows.Forms.RadioButton positionSpeed;
        private System.Windows.Forms.RadioButton onlyPosition;
        private System.Windows.Forms.RadioButton positionAltitude;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox inputIntervalTime;
        private System.Windows.Forms.RadioButton intervalTime;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox PortBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button stopButton;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.TextBox exportLabel;
        private System.Windows.Forms.Button visualizeButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Button export;
    }
}

