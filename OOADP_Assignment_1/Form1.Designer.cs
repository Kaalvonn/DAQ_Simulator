namespace OOADP_Assignment_1
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
            this.components = new System.ComponentModel.Container();
            this.txt = new System.Windows.Forms.TextBox();
            this.cmbSensorPick = new System.Windows.Forms.ComboBox();
            this.txtValue = new System.Windows.Forms.TextBox();
            this.lblSensor = new System.Windows.Forms.Label();
            this.lblMeasurement = new System.Windows.Forms.Label();
            this.btnToggleSensor = new System.Windows.Forms.Button();
            this.chckSensor = new System.Windows.Forms.CheckBox();
            this.btnDataLogging = new System.Windows.Forms.Button();
            this.chckLoggingData = new System.Windows.Forms.CheckBox();
            this.txtNextSample = new System.Windows.Forms.TextBox();
            this.lblNextSample = new System.Windows.Forms.Label();
            this.lblNextLogging = new System.Windows.Forms.Label();
            this.txtNextLogging = new System.Windows.Forms.TextBox();
            this.tmrNextSample = new System.Windows.Forms.Timer(this.components);
            this.lblLogNumber = new System.Windows.Forms.Label();
            this.txtLogNumber = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt
            // 
            this.txt.Location = new System.Drawing.Point(268, 23);
            this.txt.Multiline = true;
            this.txt.Name = "txt";
            this.txt.Size = new System.Drawing.Size(100, 151);
            this.txt.TabIndex = 0;
            // 
            // cmbSensorPick
            // 
            this.cmbSensorPick.FormattingEnabled = true;
            this.cmbSensorPick.Items.AddRange(new object[] {
            "Analog 1",
            "Analog 2",
            "Analog 3",
            "Analog 4",
            "Analog 5",
            "Analog 6",
            "Analog 7",
            "Analog 8",
            "Digital 1",
            "Digital 2",
            "Digital 3",
            "Digital 4"});
            this.cmbSensorPick.Location = new System.Drawing.Point(12, 23);
            this.cmbSensorPick.Name = "cmbSensorPick";
            this.cmbSensorPick.Size = new System.Drawing.Size(117, 21);
            this.cmbSensorPick.TabIndex = 1;
            // 
            // txtValue
            // 
            this.txtValue.Location = new System.Drawing.Point(151, 83);
            this.txtValue.Name = "txtValue";
            this.txtValue.ReadOnly = true;
            this.txtValue.Size = new System.Drawing.Size(69, 20);
            this.txtValue.TabIndex = 2;
            // 
            // lblSensor
            // 
            this.lblSensor.AutoSize = true;
            this.lblSensor.Location = new System.Drawing.Point(15, 7);
            this.lblSensor.Name = "lblSensor";
            this.lblSensor.Size = new System.Drawing.Size(79, 13);
            this.lblSensor.TabIndex = 3;
            this.lblSensor.Text = "Sensor Picked:";
            // 
            // lblMeasurement
            // 
            this.lblMeasurement.AutoSize = true;
            this.lblMeasurement.Location = new System.Drawing.Point(148, 67);
            this.lblMeasurement.Name = "lblMeasurement";
            this.lblMeasurement.Size = new System.Drawing.Size(37, 13);
            this.lblMeasurement.TabIndex = 4;
            this.lblMeasurement.Text = "Value:";
            // 
            // btnToggleSensor
            // 
            this.btnToggleSensor.Location = new System.Drawing.Point(12, 50);
            this.btnToggleSensor.Name = "btnToggleSensor";
            this.btnToggleSensor.Size = new System.Drawing.Size(96, 26);
            this.btnToggleSensor.TabIndex = 5;
            this.btnToggleSensor.Text = "Toggle Sensor";
            this.btnToggleSensor.UseVisualStyleBackColor = true;
            this.btnToggleSensor.Click += new System.EventHandler(this.btnToggleSensor_Click);
            // 
            // chckSensor
            // 
            this.chckSensor.AutoSize = true;
            this.chckSensor.Enabled = false;
            this.chckSensor.Location = new System.Drawing.Point(114, 56);
            this.chckSensor.Name = "chckSensor";
            this.chckSensor.Size = new System.Drawing.Size(15, 14);
            this.chckSensor.TabIndex = 6;
            this.chckSensor.UseVisualStyleBackColor = true;
            // 
            // btnDataLogging
            // 
            this.btnDataLogging.Location = new System.Drawing.Point(12, 148);
            this.btnDataLogging.Name = "btnDataLogging";
            this.btnDataLogging.Size = new System.Drawing.Size(96, 26);
            this.btnDataLogging.TabIndex = 7;
            this.btnDataLogging.Text = "Toggle Logging";
            this.btnDataLogging.UseVisualStyleBackColor = true;
            this.btnDataLogging.Click += new System.EventHandler(this.btnDataLogging_Click);
            // 
            // chckLoggingData
            // 
            this.chckLoggingData.AutoSize = true;
            this.chckLoggingData.Enabled = false;
            this.chckLoggingData.Location = new System.Drawing.Point(114, 155);
            this.chckLoggingData.Name = "chckLoggingData";
            this.chckLoggingData.Size = new System.Drawing.Size(15, 14);
            this.chckLoggingData.TabIndex = 8;
            this.chckLoggingData.UseVisualStyleBackColor = true;
            // 
            // txtNextSample
            // 
            this.txtNextSample.Location = new System.Drawing.Point(151, 23);
            this.txtNextSample.Name = "txtNextSample";
            this.txtNextSample.ReadOnly = true;
            this.txtNextSample.Size = new System.Drawing.Size(69, 20);
            this.txtNextSample.TabIndex = 9;
            // 
            // lblNextSample
            // 
            this.lblNextSample.AutoSize = true;
            this.lblNextSample.Location = new System.Drawing.Point(148, 7);
            this.lblNextSample.Name = "lblNextSample";
            this.lblNextSample.Size = new System.Drawing.Size(70, 13);
            this.lblNextSample.TabIndex = 10;
            this.lblNextSample.Text = "Next Sample:";
            // 
            // lblNextLogging
            // 
            this.lblNextLogging.AutoSize = true;
            this.lblNextLogging.Location = new System.Drawing.Point(150, 136);
            this.lblNextLogging.Name = "lblNextLogging";
            this.lblNextLogging.Size = new System.Drawing.Size(73, 13);
            this.lblNextLogging.TabIndex = 12;
            this.lblNextLogging.Text = "Next Logging:";
            // 
            // txtNextLogging
            // 
            this.txtNextLogging.Location = new System.Drawing.Point(151, 152);
            this.txtNextLogging.Name = "txtNextLogging";
            this.txtNextLogging.ReadOnly = true;
            this.txtNextLogging.Size = new System.Drawing.Size(69, 20);
            this.txtNextLogging.TabIndex = 11;
            // 
            // tmrNextSample
            // 
            this.tmrNextSample.Tick += new System.EventHandler(this.tmrNextSample_Tick);
            // 
            // lblLogNumber
            // 
            this.lblLogNumber.AutoSize = true;
            this.lblLogNumber.Location = new System.Drawing.Point(9, 106);
            this.lblLogNumber.Name = "lblLogNumber";
            this.lblLogNumber.Size = new System.Drawing.Size(75, 13);
            this.lblLogNumber.TabIndex = 15;
            this.lblLogNumber.Text = "# of Loggings:";
            // 
            // txtLogNumber
            // 
            this.txtLogNumber.Location = new System.Drawing.Point(12, 122);
            this.txtLogNumber.Name = "txtLogNumber";
            this.txtLogNumber.ReadOnly = true;
            this.txtLogNumber.Size = new System.Drawing.Size(69, 20);
            this.txtLogNumber.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sensor Values:";
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(380, 192);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblLogNumber);
            this.Controls.Add(this.txtLogNumber);
            this.Controls.Add(this.lblNextLogging);
            this.Controls.Add(this.txtNextLogging);
            this.Controls.Add(this.lblNextSample);
            this.Controls.Add(this.txtNextSample);
            this.Controls.Add(this.chckLoggingData);
            this.Controls.Add(this.btnDataLogging);
            this.Controls.Add(this.chckSensor);
            this.Controls.Add(this.btnToggleSensor);
            this.Controls.Add(this.lblMeasurement);
            this.Controls.Add(this.lblSensor);
            this.Controls.Add(this.txtValue);
            this.Controls.Add(this.cmbSensorPick);
            this.Controls.Add(this.txt);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TabPage tabPage6;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TabPage tabPage7;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TabPage tabPage8;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TabPage tabPage9;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TabPage tabPage10;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TabPage tabPage11;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TabPage tabPage12;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.TextBox txt;
        private System.Windows.Forms.ComboBox cmbSensorPick;
        private System.Windows.Forms.TextBox txtValue;
        private System.Windows.Forms.Label lblSensor;
        private System.Windows.Forms.Label lblMeasurement;
        private System.Windows.Forms.Button btnToggleSensor;
        private System.Windows.Forms.Button btnDataLogging;
        private System.Windows.Forms.CheckBox chckLoggingData;
        private System.Windows.Forms.TextBox txtNextSample;
        private System.Windows.Forms.Label lblNextSample;
        private System.Windows.Forms.Label lblNextLogging;
        private System.Windows.Forms.TextBox txtNextLogging;
        private System.Windows.Forms.CheckBox chckSensor;
        private System.Windows.Forms.Timer tmrNextSample;
        private System.Windows.Forms.Label lblLogNumber;
        private System.Windows.Forms.TextBox txtLogNumber;
        private System.Windows.Forms.Label label1;
    }
}

