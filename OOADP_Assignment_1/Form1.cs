using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace OOADP_Assignment_1
{
    public partial class Form1 : Form
    {
        //Parameters
        public bool SensorToggled = false;
        public bool LoggingToggled = false;
        public int SensorValue;
        public int counter = 0;
        public int counterMod;
        public int LogNum = 0;
        public double countdown = 2.3;
        public double LogTimer = 6;
        public int logCounterMod;
        public int logCounter = 0;
        public string LogData = "Analog1:;\t" + "Analog2:;\t" + "Analog3:;\t" + "Analog4:;\t" + "Analog5:;\t" + "Analog6:;\t" + "Analog7:;\t" + "Analog8:;\t" + "Digital1:;\t" + "Digital2:;\t" + "Digital3:;\t" + "Digital4:;" + "\n";
        public string filepath = "" + "";

        //Generate Sensors
        AnalogSensor Analog1 = new AnalogSensor();
        AnalogSensor Analog2 = new AnalogSensor();
        AnalogSensor Analog3 = new AnalogSensor();
        AnalogSensor Analog4 = new AnalogSensor();
        AnalogSensor Analog5 = new AnalogSensor();
        AnalogSensor Analog6 = new AnalogSensor();
        AnalogSensor Analog7 = new AnalogSensor();
        AnalogSensor Analog8 = new AnalogSensor();

        DigitalSensor Digital1 = new DigitalSensor();
        DigitalSensor Digital2 = new DigitalSensor();
        DigitalSensor Digital3 = new DigitalSensor();
        DigitalSensor Digital4 = new DigitalSensor();

        //Initialization for Form1
        public Form1()
        {
            InitializeComponent();
            txtLogNumber.Text = "0";
            txtLogFile.Text = ("DataLog.csv");
            txtAllSensors.AppendText("Analog1: " + "\n");
            txtAllSensors.AppendText("Analog2: " + "\n");
            txtAllSensors.AppendText("Analog3: " + "\n");
            txtAllSensors.AppendText("Analog4: " + "\n");
            txtAllSensors.AppendText("Analog5: " + "\n");
            txtAllSensors.AppendText("Analog6: " + "\n");
            txtAllSensors.AppendText("Analog7: " + "\n");
            txtAllSensors.AppendText("Analog8: " + "\n");
            txtAllSensors.AppendText("Digital1: " + "\n");
            txtAllSensors.AppendText("Digital2: " + "\n");
            txtAllSensors.AppendText("Digital3: " + "\n");
            txtAllSensors.AppendText("Digital4: " + "\n");
        }

        //Methods
        Random rndValue = new Random();
        public double SensorRandomValueAnalog()
        {
            double rnd = Convert.ToDouble(rndValue.Next(0, 4194304)) / 4194304;
            return rnd;
        }

        public int SensorRandomValueDigital()
        {
            int rnd = rndValue.Next(0, 2);
            return rnd;
        }


        //Classes
        public class AnalogSensor
        {
            public double value;
            public AnalogSensor()
            {
            }
        }

        public class DigitalSensor
        {
            public double value;
            public DigitalSensor()
            {
            }
        }
        //Timer tick Sensor
        private void tmrNextSample_Tick(object sender, EventArgs e)
        {
            counter++;
            counterMod = counter / 23;

            if (SensorToggled == true)
            {
                txtNextSample.Text = Convert.ToString(Math.Round(countdown, 1));
                countdown -= 0.1;
                if (counterMod == 1)
                {
                    counter = 0;

                    countdown = 2.3;

                    Analog1.value = SensorRandomValueAnalog();
                    txtAllSensors.Text = "Analog1: " + Convert.ToString(Analog1.value) + "\n";

                    Analog2.value = SensorRandomValueAnalog();
                    txtAllSensors.AppendText("Analog2: " + Convert.ToString(Analog2.value) + "\n");

                    Analog3.value = SensorRandomValueAnalog();
                    txtAllSensors.AppendText("Analog3: " + Convert.ToString(Analog3.value) + "\n");

                    Analog4.value = SensorRandomValueAnalog();
                    txtAllSensors.AppendText("Analog4: " + Convert.ToString(Analog4.value) + "\n");

                    Analog5.value = SensorRandomValueAnalog();
                    txtAllSensors.AppendText("Analog5: " + Convert.ToString(Analog5.value) + "\n");

                    Analog6.value = SensorRandomValueAnalog();
                    txtAllSensors.AppendText("Analog6: " + Convert.ToString(Analog6.value) + "\n");

                    Analog7.value = SensorRandomValueAnalog();
                    txtAllSensors.AppendText("Analog7: " + Convert.ToString(Analog7.value) + "\n");

                    Analog8.value = SensorRandomValueAnalog();
                    txtAllSensors.AppendText("Analog8: " + Convert.ToString(Analog8.value) + "\n");

                    Digital1.value = SensorRandomValueDigital();
                    txtAllSensors.AppendText("Digital1: " + Convert.ToString(Digital1.value) + "\n");

                    Digital2.value = SensorRandomValueDigital();
                    txtAllSensors.AppendText("Digital2: " + Convert.ToString(Digital2.value) + "\n");

                    Digital3.value = SensorRandomValueDigital();
                    txtAllSensors.AppendText("Digital3: " + Convert.ToString(Digital3.value) + "\n");

                    Digital4.value = SensorRandomValueDigital();
                    txtAllSensors.AppendText("Digital4: " + Convert.ToString(Digital4.value) + "\n");
                }
            }
        }


        //Buttons
        private void btnToggleSensor_Click(object sender, EventArgs e)
        {
            if (SensorToggled == false)
            {
                SensorToggled = true;
                tmrNextSample.Start();
                chckSensor.Checked = true;
            }
            else
            {
                SensorToggled = false;
                tmrNextSample.Stop();
                chckSensor.Checked = false;
            }
        }
        private void btnDataLogging_Click(object sender, EventArgs e)
        {
            if (SensorToggled)
            {
                if (LoggingToggled == false)
                {
                    LoggingToggled = true;
                    tmrNextLogging.Start();
                    chckLoggingData.Checked = true;
                }
                else
                {
                    LoggingToggled = false;
                    tmrNextLogging.Stop();
                    chckLoggingData.Checked = false;
                }
            }
        }
        //Timer Tick Logging
        private void tmrNextLogging_Tick(object sender, EventArgs e)
        {

            logCounter++;
            logCounterMod = logCounter / 60;
            if (LoggingToggled && SensorToggled)
            {
                LogTimer -= 0.1;
                txtNextLogging.Text = Convert.ToString(Math.Round(LogTimer, 1));
                if (logCounterMod == 1)
                {
                    logCounter = 0;
                    LogNum++;
                    txtLogNumber.Text = Convert.ToString(LogNum);
                    LogTimer = 6;

                    LogData += Analog1.value.ToString() + ";\t" + Analog2.value.ToString() + ";\t" + Analog3.value.ToString() + ";\t" + Analog4.value.ToString() + ";\t" + Analog5.value.ToString() + ";\t" + Analog6.value.ToString() + ";\t" + Analog7.value.ToString() + ";\t" + Analog8.value.ToString() + ";\t" + Digital1.value.ToString() + ";\t" + Digital2.value.ToString() + ";\t" + Digital3.value.ToString() + ";\t" + Digital4.value.ToString() + ";\t" + "\n";
                    File.AppendAllText("DataLog.csv", LogData);
                    LogData = "";

                }
            }
            else
            {
                tmrNextLogging.Stop();
                txtNextLogging.Clear();
                chckLoggingData.Checked = false;
                LoggingToggled = false;
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {

            MessageBox.Show("This app is created by Eirik Siljan as part of the course Industrial IT.", "About the application");
        }
    }
}

