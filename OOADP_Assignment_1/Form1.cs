using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        public double countdown = 2.3;

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
            cmbSensorPick.SelectedIndex = 0; //Initial Value for Combobox
        }

        //Methods
        Random rndValue = new Random();
        public double SensorRandomValueAnalog()
        {
            double rnd = Convert.ToDouble(rndValue.Next(0, 4194304)) / 4194304;
            return rnd;
        }

        public double SensorRandomValueDigital()
        {
            Random rndValue = new Random();
            double rnd = Convert.ToDouble(rndValue.Next(0, 2));
            return rnd;
        }

        //Button Events
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
                    switch (cmbSensorPick.SelectedIndex)
                    {
                        case 0:
                            Analog1.value = SensorRandomValueAnalog();
                            txtValue.Text = Convert.ToString(Analog1.value);

                            break;

                        case 1:
                            Analog2.value = SensorRandomValueAnalog();
                            txtValue.Text = Convert.ToString(Analog2.value);
                            break;

                        case 2:
                            Analog3.value = SensorRandomValueAnalog();
                            txtValue.Text = Convert.ToString(Analog3.value);
                            break;

                        case 3:
                            Analog4.value = SensorRandomValueAnalog();
                            txtValue.Text = Convert.ToString(Analog4.value);
                            break;
                        case 4:
                            Analog5.value = SensorRandomValueAnalog();
                            txtValue.Text = Convert.ToString(Analog5.value);
                            break;

                        case 5:
                            Analog6.value = SensorRandomValueAnalog();
                            txtValue.Text = Convert.ToString(Analog6.value);
                            break;

                        case 6:
                            Analog7.value = SensorRandomValueAnalog();
                            txtValue.Text = Convert.ToString(Analog7.value);
                            break;

                        case 7:
                            Analog8.value = SensorRandomValueAnalog();
                            txtValue.Text = Convert.ToString(Analog8.value);
                            break;

                        case 8:
                            Digital1.value = SensorRandomValueDigital();
                            txtValue.Text = Convert.ToString(Digital1.value);
                            break;

                        case 9:
                            Digital2.value = SensorRandomValueDigital();
                            txtValue.Text = Convert.ToString(Digital2.value);
                            break;

                        case 10:
                            Digital3.value = SensorRandomValueDigital();
                            txtValue.Text = Convert.ToString(Digital3.value);
                            break;

                        case 11:
                            Digital4.value = SensorRandomValueDigital();
                            txtValue.Text = Convert.ToString(Digital4.value);
                            break;
                    }
                }
            }
        }

        private void btnDataLogging_Click(object sender, EventArgs e)
        {
            if (LoggingToggled == false)
            {
                LoggingToggled = true;
                
                chckLoggingData.Checked = true;
            }
            else
            {
                LoggingToggled = false;
                
                chckSensor.Checked = false;
            }
        }
    }
}

