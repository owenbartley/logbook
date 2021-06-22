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

        string filePath = "trips.xml";

        bool start = true;
        string date = DateTime.Now.ToShortDateString();

        public class Trip
        {
            public string date;
            public string duration;
            public bool weatherRain;
            public bool weatherClear;
            public bool trafficLight;
            public bool trafficMed;
            public bool trafficHeavy;
            public bool roadLocal;
            public bool roadHighway;
            public bool roadRural;
            public bool day;
            public bool approved;
        }

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

                Trip t = new Trip();
                t.duration = duration;
                t.weatherClear = chkBxClear.Checked;
                t.weatherRain = chkBxRain.Checked;
                t.trafficLight = chkBxLight.Checked;
                t.trafficMed = chkBxMed.Checked;
                t.trafficHeavy = chkBxHeavy.Checked;
                t.roadLocal = chkBxLocal.Checked;
                t.roadRural = chkBxRural.Checked;
                t.roadHighway = chkBxHighway.Checked;
                t.day = chkBxTime.Checked;
                t.approved = chkBxApproved.Checked;
                WriteTripData(filePath, t);

                //Go back to Home form
                Hide();
                Home newHomeForm = new Home();
                newHomeForm.ShowDialog();
            }
        }

        public void WriteTripData(string filePath, Trip t)
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
                    xmlWriter.WriteElementString("duration", Convert.ToString(t.duration));
                    xmlWriter.WriteElementString("date", date);
                    xmlWriter.WriteElementString("rain", Convert.ToString(t.weatherRain));
                    xmlWriter.WriteElementString("clear", Convert.ToString(t.weatherClear));
                    xmlWriter.WriteElementString("light", Convert.ToString(t.trafficLight));
                    xmlWriter.WriteElementString("med", Convert.ToString(t.trafficMed));
                    xmlWriter.WriteElementString("heavy", Convert.ToString(t.trafficHeavy));
                    xmlWriter.WriteElementString("local", Convert.ToString(t.roadLocal));
                    xmlWriter.WriteElementString("rural", Convert.ToString(t.roadRural));
                    xmlWriter.WriteElementString("highway", Convert.ToString(t.roadHighway));
                    xmlWriter.WriteElementString("day", Convert.ToString(t.day));
                    xmlWriter.WriteElementString("approved", Convert.ToString(t.approved));
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
                XElement root = xDocument.Element("Trip");
                IEnumerable<XElement> rows = root.Descendants("trips");
                XElement firstRow = rows.First();
                firstRow.AddBeforeSelf(
                   new XElement("trip",
                   new XElement("duration", t.duration),
                   new XElement("date", date),
                   new XElement("rain", t.weatherRain),
                   new XElement("clear", t.weatherClear),
                   new XElement("light", t.trafficLight),
                   new XElement("med", t.trafficMed),
                   new XElement("heavy", t.trafficHeavy),
                   new XElement("local", t.roadLocal),
                   new XElement("rural", t.roadRural),
                   new XElement("highway", t.roadHighway),
                   new XElement("day", t.day),
                   new XElement("approved", t.approved)));
                xDocument.Save("Test.xml");
            }
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