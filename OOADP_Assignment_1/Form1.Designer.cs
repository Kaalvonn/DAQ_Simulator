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
            this.txtAllSensors = new System.Windows.Forms.TextBox();
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
            this.tmrNextLogging = new System.Windows.Forms.Timer(this.components);
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLogFile = new System.Windows.Forms.TextBox();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtAllSensors
            // 
            this.txtAllSensors.Enabled = false;
            this.txtAllSensors.Location = new System.Drawing.Point(268, 46);
            this.txtAllSensors.Multiline = true;
            this.txtAllSensors.Name = "txtAllSensors";
            this.txtAllSensors.Size = new System.Drawing.Size(225, 175);
            this.txtAllSensors.TabIndex = 0;
            // 
            // btnToggleSensor
            // 
            this.btnToggleSensor.Location = new System.Drawing.Point(12, 42);
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
            this.chckSensor.Location = new System.Drawing.Point(114, 48);
            this.chckSensor.Name = "chckSensor";
            this.chckSensor.Size = new System.Drawing.Size(15, 14);
            this.chckSensor.TabIndex = 6;
            this.chckSensor.UseVisualStyleBackColor = true;
            // 
            // btnDataLogging
            // 
            this.btnDataLogging.Location = new System.Drawing.Point(12, 131);
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
            this.chckLoggingData.Location = new System.Drawing.Point(114, 138);
            this.chckLoggingData.Name = "chckLoggingData";
            this.chckLoggingData.Size = new System.Drawing.Size(15, 14);
            this.chckLoggingData.TabIndex = 8;
            this.chckLoggingData.UseVisualStyleBackColor = true;
            // 
            // txtNextSample
            // 
            this.txtNextSample.Location = new System.Drawing.Point(151, 46);
            this.txtNextSample.Name = "txtNextSample";
            this.txtNextSample.ReadOnly = true;
            this.txtNextSample.Size = new System.Drawing.Size(69, 20);
            this.txtNextSample.TabIndex = 9;
            // 
            // lblNextSample
            // 
            this.lblNextSample.AutoSize = true;
            this.lblNextSample.Location = new System.Drawing.Point(148, 30);
            this.lblNextSample.Name = "lblNextSample";
            this.lblNextSample.Size = new System.Drawing.Size(70, 13);
            this.lblNextSample.TabIndex = 10;
            this.lblNextSample.Text = "Next Sample:";
            // 
            // lblNextLogging
            // 
            this.lblNextLogging.AutoSize = true;
            this.lblNextLogging.Location = new System.Drawing.Point(150, 119);
            this.lblNextLogging.Name = "lblNextLogging";
            this.lblNextLogging.Size = new System.Drawing.Size(73, 13);
            this.lblNextLogging.TabIndex = 12;
            this.lblNextLogging.Text = "Next Logging:";
            // 
            // txtNextLogging
            // 
            this.txtNextLogging.Location = new System.Drawing.Point(151, 135);
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
            this.lblLogNumber.Location = new System.Drawing.Point(150, 185);
            this.lblLogNumber.Name = "lblLogNumber";
            this.lblLogNumber.Size = new System.Drawing.Size(75, 13);
            this.lblLogNumber.TabIndex = 15;
            this.lblLogNumber.Text = "# of Loggings:";
            // 
            // txtLogNumber
            // 
            this.txtLogNumber.Location = new System.Drawing.Point(153, 201);
            this.txtLogNumber.Name = "txtLogNumber";
            this.txtLogNumber.ReadOnly = true;
            this.txtLogNumber.Size = new System.Drawing.Size(69, 20);
            this.txtLogNumber.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(265, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 16;
            this.label1.Text = "Sensor Values:";
            // 
            // tmrNextLogging
            // 
            this.tmrNextLogging.Tick += new System.EventHandler(this.tmrNextLogging_Tick);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(505, 24);
            this.menuStrip1.TabIndex = 17;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 184);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 19;
            this.label2.Text = "Log file:";
            // 
            // txtLogFile
            // 
            this.txtLogFile.Location = new System.Drawing.Point(12, 200);
            this.txtLogFile.Name = "txtLogFile";
            this.txtLogFile.ReadOnly = true;
            this.txtLogFile.Size = new System.Drawing.Size(96, 20);
            this.txtLogFile.TabIndex = 18;
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(505, 232);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLogFile);
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
            this.Controls.Add(this.txtAllSensors);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
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
        private System.Windows.Forms.TextBox txtAllSensors;
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
        private System.Windows.Forms.Timer tmrNextLogging;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLogFile;
    }
}

