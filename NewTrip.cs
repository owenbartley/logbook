﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Xml;
using System.Xml.Linq;

namespace DriversLogbookApp
{
    public partial class NewTrip : Form
    {
        public NewTrip()
        {
            InitializeComponent();
        }

        public class Trip
        {
            public int tripID;
            public string date;
            public int duration;
            public bool weatherRain;
            public bool weatherClear;
            public bool trafficLight;
            public bool trafficMed;
            public bool trafficHeavy;
            public bool roadLocal;
            public bool roadHighway;
            public bool roadRural;
            public bool dayNight;
            public bool approved;
        }

        string filePath = "trips.xml";

        bool start = true;
        bool day = false;
        bool night = false;
        string date = DateTime.Now.ToShortDateString();
        private void BtnStartStop_Click(object sender, EventArgs e)
        {
            //Turn button into switch and start timer
            if (start == true)
            {
                btnStartStop.Text = "Stop";
                start = false;
                timer1.Start();
                //Updates the duration every second
                /*
                while (true)
                {
                    string duration = timer1.ToString();
                    lblDuration.Text = duration;
                }
                */
            }
            else
            {
                timer1.Stop();
                string duration = timer1.ToString();
                //Testing the timer
                //lblDuration.Text = duration;

                //Get input data
                bool weatherClear = chkBxClear.Checked;
                bool weatherRain = chkBxRain.Checked;
                bool trafficLight = chkBxLight.Checked;
                bool trafficMed = chkBxMed.Checked;
                bool trafficHeavy = chkBxHeavy.Checked;
                bool roadLocal = chkBxLocal.Checked;
                bool roadRural = chkBxRural.Checked;
                bool roadHighway = chkBxHighway.Checked;
                int dayNight = cmbBxTime.SelectedIndex;
                bool approved = chkBxApproved.Checked;
                int id = 1000;

                //Day checkbox
                if (dayNight == 1)
                {
                    day = true;
                }
                //Night Checkbox
                else if (dayNight == 2)
                {
                    night = true;
                }
                WriteTripData(filePath);

                //Go back to Home form
                Hide();
                Home newHomeForm = new Home();
                newHomeForm.ShowDialog();
            }
        }
        public void WriteTripData(string filePath)
        //void WriteTripData(XmlWriter writer, string id, string date, string duration, string weatherRain, string weatherClear, string trafficLight, string trafficMed, string trafficHeavy, string roadLocal, string roadRural, string roadHighway, string dayNight, string approved)
        {
            if (!File.Exists(filePath))
            {
                XmlWriterSettings xmlWriterSettings = new XmlWriterSettings();
                xmlWriterSettings.Indent = true;
                xmlWriterSettings.NewLineOnAttributes = true;
                using (XmlWriter xmlWriter = XmlWriter.Create("trips.xml", xmlWriterSettings))
                {
                    xmlWriter.WriteStartDocument();
                    xmlWriter.WriteStartElement("trips");

                    xmlWriter.WriteStartElement("trip");
                    xmlWriter.WriteAttributeString("id", id);
                    xmlWriter.WriteElementString("duration", duration);
                    xmlWriter.WriteElementString("date", date);
                    xmlWriter.WriteElementString("rain", weatherRain);
                    xmlWriter.WriteElementString("clear", weatherClear);
                    xmlWriter.WriteElementString("light", trafficLight);
                    xmlWriter.WriteElementString("med", trafficMed);
                    xmlWriter.WriteElementString("heavy", trafficHeavy);
                    xmlWriter.WriteElementString("local", roadLocal);
                    xmlWriter.WriteElementString("rural", roadRural);
                    xmlWriter.WriteElementString("highway", roadHighway);
                    xmlWriter.WriteElementString("day", dayNight);
                    xmlWriter.WriteElementString("approved", approved);
                    xmlWriter.WriteEndElement();

                    xmlWriter.WriteEndElement();
                    xmlWriter.WriteEndDocument();
                    xmlWriter.Flush();
                    xmlWriter.Close();
                }
            }
            else
            {
                XDocument xDocument = XDocument.Load(filePath);
                XElement root = xDocument.Element("School");
                IEnumerable<XElement> rows = root.Descendants("Student");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("trip",
                   new XElement("id", id),
                   new XElement("duration", duration),
                   new XElement("date", date),
                   new XElement("rain", weatherRain),
                   new XElement("clear", weatherClear),
                   new XElement("light", trafficLight),
                   new XElement("med", trafficMed),
                   new XElement("heavy", trafficHeavy),
                   new XElement("local", roadLocal),
                   new XElement("rural", roadRural),
                   new XElement("highway", roadHighway),
                   new XElement("day", dayNight),
                   new XElement("approved", approved)));
                xDocument.Save("Test.xml");
            }
            /*
            XmlWriterSettings settings = new XmlWriterSettings();
            settings.Indent = true;
            XmlWriter writer = XmlWriter.Create("trips.xml", settings);

            //using (XmlWriter writer = XmlWriter.Create(@"trips.xml", settings))
            writer.WriteStartElement("trip");
            writer.WriteAttributeString("id", id);
            writer.WriteElementString("duration", duration);
            writer.WriteElementString("date", date);
            writer.WriteElementString("rain", weatherRain);
            writer.WriteElementString("clear", weatherClear);
            writer.WriteElementString("light", trafficLight);
            writer.WriteElementString("med", trafficMed);
            writer.WriteElementString("heavy", trafficHeavy);
            writer.WriteElementString("local", roadLocal);
            writer.WriteElementString("rural", roadRural);
            writer.WriteElementString("highway", roadHighway);
            writer.WriteElementString("day", dayNight);
            writer.WriteElementString("approved", approved);
            writer.WriteEndElement();
            */

        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            
        }

        private void NewTrip_Load(object sender, EventArgs e)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            //Get todays date and display it
            lblDate.Text = date;
        }

        private void CheckBox6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void CheckBox4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void ChkBxClear_CheckedChanged(object sender, EventArgs e)
        {
            
        }
    }
}