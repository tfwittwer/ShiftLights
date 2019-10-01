using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iRacingSdkWrapper;
using System.IO;

namespace ShiftLights
{
    public partial class Form1 : Form
    {
        private readonly SdkWrapper wrapper;

        // todo:
        // shiftpoint afhankelijk maken van versnelling, configuratie laden en onthouden
        // positie onthouden en herstellen

        private int[] percentage;
        private int[] redline;

        public Form1()
        {
            InitializeComponent();
            shiftLbl.Text = "";

            if(ReadSettings())
            {
                // Create instance
                wrapper = new SdkWrapper();
                wrapper.TelemetryUpdateFrequency = 30;
                // Listen to events
                wrapper.TelemetryUpdated += OnTelemetryUpdated;
                wrapper.SessionInfoUpdated += OnSessionInfoUpdated;
                // Start it!
                wrapper.Start();

            }
        }

        private bool ReadSettings()
        {
            if(File.Exists("shiftlights.txt"))
            {
                percentage = new int[4];
                redline = new int[6];
                try
                {
                    using (StreamReader reader = new StreamReader("shiftlights.txt"))
                    {
                        string text = reader.ReadLine();
                        string[] fields = text.Split(' ');
                        for (int i = 0; i < 4; i++) percentage[i] = Convert.ToInt32(fields[i]);

                        for (int i = 0; i < 6; i++) redline[i] = Convert.ToInt32(reader.ReadLine());

                        return true;
                    }
                }
                catch
                {
                    MessageBox.Show("Error reading settings from shiftlights.txt!");
                    return false;

                }

            }
            else
            {
                MessageBox.Show("shiftlights.txt not found!");
                return false;
            }
        }

        private void OnSessionInfoUpdated(object sender, SdkWrapper.SessionInfoUpdatedEventArgs e)
        {
            // Use session info...
            // hier kan ergens de redline uitgelezen worden
        }
        private void OnTelemetryUpdated(object sender, SdkWrapper.TelemetryUpdatedEventArgs e)
        {
            // Use live telemetry...
            float rpm = e.TelemetryInfo.RPM.Value;          

            rpmLbl.Text = rpm.ToString("F0");

            int gear = e.TelemetryInfo.Gear.Value;

            int percent = Convert.ToInt32(rpm / (Redline(gear)/100));
            if (percent >= percentage[3])
            {
                shiftLbl.BackColor = Color.Red;
            }
            else if (percent >= percentage[2])
            {
                shiftLbl.BackColor = Color.Orange;
            }
            else if (percent >= percentage[1])
            {
                shiftLbl.BackColor = Color.Yellow;
            }
            else if (percent >= percentage[0])
            {
                shiftLbl.BackColor = Color.LightGreen;
            }
            else
            {
                shiftLbl.BackColor = Color.Blue;
            }


            if (gear == -1) gearLbl.Text = "R";
            else if (gear == 0) gearLbl.Text = "N";
            else gearLbl.Text = gear.ToString();
            
        }

        private int Redline(int gear)
        {
            gear--; // shift to 0-based
            if (gear < 0) gear = 0; // neutral or reverse
            else if (gear > 5) gear = 5; // higher than 6th gear

            return redline[gear];
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Location = Properties.Settings.Default.Location;
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.Location = Location;
            Properties.Settings.Default.Save();
        }
    }
}

