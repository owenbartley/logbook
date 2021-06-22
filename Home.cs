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

namespace DriversLogbookApp
{
    public partial class Home : Form
    {
        public class Trip
        {
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
            public bool day;
            public bool approved;
        }

        string filePath = "trips.xml";

        Trip[] trips;

        public Home()
        {
            InitializeComponent();
        }

        private void ReadXML(string filePath)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);

            XmlNodeList xmlTripList = doc.GetElementsByTagName("trip");

            //Set the array size
            trips = new Trip[xmlTripList.Count];

            //To iterate though the array
            int index = 0;
            int totalHours = 0;
            foreach (XmlNode trip in xmlTripList)
            {
                Trip theTrip = new Trip();
                int duration = Convert.ToInt32(trip["duration"].InnerText); 
                string date = trip["date"].InnerText;
                bool weatherRain = Convert.ToBoolean(trip["rain"].InnerText);
                bool weatherClear = Convert.ToBoolean(trip["clear"].InnerText);
                bool trafficLight = Convert.ToBoolean(trip["light"].InnerText);
                bool trafficMed = Convert.ToBoolean(trip["med"].InnerText);
                bool trafficHeavy = Convert.ToBoolean(trip["heavy"].InnerText);
                bool roadLocal = Convert.ToBoolean(trip["local"].InnerText);
                bool roadRural = Convert.ToBoolean(trip["rural"].InnerText);
                bool roadHighway = Convert.ToBoolean(trip["highway"].InnerText);
                bool day = Convert.ToBoolean(trip["day"].InnerText);
                bool approved = Convert.ToBoolean(trip["approved"].InnerText);
                theTrip.duration = duration;
                theTrip.date = date;
                theTrip.weatherRain = weatherRain;
                theTrip.weatherClear = weatherClear;
                theTrip.trafficLight = trafficLight;
                theTrip.trafficMed = trafficMed;
                theTrip.trafficHeavy = trafficHeavy;
                theTrip.roadLocal = roadLocal;
                theTrip.roadHighway = roadHighway;
                theTrip.roadRural = roadRural;
                theTrip.day = day;
                theTrip.approved = approved;

                //Calculate total hours
                //Variables to hold running totals
                totalHours = totalHours + duration;

                trips[index] = theTrip;
                index++;

                lblHoursTotal.Text = totalHours.ToString() + " Minutes";
            }
        }

        private void Home_Load(object sender, EventArgs e)
        {
            ReadXML(filePath);
        }

        private void BtnNewTrip_Click(object sender, EventArgs e)
        {
            //Go to New Trip form
            Hide();
            NewTrip newTripForm = new NewTrip();
            newTripForm.ShowDialog();
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            //Go to Summary form
            Hide();
            Summary newSummaryForm = new Summary();
            newSummaryForm.ShowDialog();
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {
            //Go to Approval form
            Hide();
            Approval newApprovalForm = new Approval();
            newApprovalForm.ShowDialog();
        }
    }
}