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

        //Store file path
        string filePath = "trips.xml";

        bool start = true;
        //Get todays date
        string date = DateTime.Now.ToShortDateString();

        public class Trip
        {
            public string date;
            public double duration;
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
            //Start button
            if (start == true)
            {
                //Change button to 'stop' button
                btnStartStop.Text = "Stop";
                start = false;
                //Start the timer from 0
                elapsedTime = 0;
                timer1.Start();
            }
            //Stop button
            else
            {
                //Stop the timer and store the elapsed time
                timer1.Stop();
                double duration = elapsedTime;

                //Add input data into array
                Trip t = new Trip();
                t.duration = Convert.ToDouble(duration);
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

                //Validate input data
                //Validate weather
                if(t.weatherClear == false & t.weatherRain == false)
                {
                    MessageBox.Show("No Weather Selected", "Error");
                }
                else
                {
                    //Validate traffic
                    if (t.trafficLight == false & t.trafficMed == false & t.trafficHeavy == false)
                    {
                        MessageBox.Show("No Traffic Level Selected", "Error");
                    }
                    else
                    {
                        //Validate road type
                        if (t.roadLocal == false & t.roadRural == false & t.roadHighway == false)
                        {
                            MessageBox.Show("No Road Type Selected", "Error");
                        }
                        else
                        {
                            //Save data to XML document
                            WriteTripData(t);
                            //Go back to Home form
                            Hide();
                            Home newHomeForm = new Home();
                            newHomeForm.ShowDialog();
                        }
                    }
                }
            }
        }

        public void WriteTripData(Trip t)
        {
            //Load document
            XDocument xmlDoc = XDocument.Load(filePath);
            if (!File.Exists(filePath))
            {
                //Append input data into XML
                xmlDoc.Element("driverslog").Add(new XElement("trip"), new XElement("duration", Convert.ToString(t.duration)), new XElement("date", date), new XElement("rain", Convert.ToString(t.weatherRain)), new XElement("clear", Convert.ToString(t.weatherClear)), new XElement("light", Convert.ToString(t.trafficLight)), new XElement("med", Convert.ToString(t.trafficMed)), new XElement("heavy", Convert.ToString(t.trafficHeavy)), new XElement("local", Convert.ToString(t.roadLocal)), new XElement("rural", Convert.ToString(t.roadRural)), new XElement("highway", Convert.ToString(t.roadHighway)), new XElement("day", Convert.ToString(t.day)), new XElement("approved", Convert.ToString(t.approved)));
            }
            else
            {
                //Create XML document and add input data
                XElement root = xmlDoc.Element("driverslog");
                IEnumerable<XElement> rows = root.Descendants("trip");
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
            }
            //Save document
            xmlDoc.Save(filePath);
        }

        int elapsedTime = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            //Add a second every tick to elapsed time
            elapsedTime = elapsedTime + 1;
            var time = TimeSpan.FromSeconds(elapsedTime);

            //Get current duration and display it
            lblDuration.Text = time.ToString();
        }

        private void NewTrip_Load(object sender, EventArgs e)
        {
            //Load XML document
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