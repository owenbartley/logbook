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
        //To store variables from array in
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
        Trip[] trips;

        //Store file path
        string filePath = "trips.xml";

        public Home()
        {
            InitializeComponent();
        }

        private void ReadXML(string filePath)
        {
            //Load the document and its elements
            XmlDocument doc = new XmlDocument();
            doc.Load(filePath);
            XmlNodeList xmlTripList = doc.GetElementsByTagName("trip");

            //Set the array size
            trips = new Trip[xmlTripList.Count];

            //To iterate though the array
            int index = 0;
            double totalSeconds = 0;
            int highwayTotal = 0;
            int localTotal = 0;
            int ruralTotal = 0;
            int clearTotal = 0;
            int rainTotal = 0;
            int lightTotal = 0;
            int medTotal = 0;
            int heavyTotal = 0;
            int dayTotal = 0;
            int nightTotal = 0;
            double unapprovedDuration = 0;

            //Get variables from XML and store in array
            foreach (XmlNode trip in xmlTripList)
            {
                Trip theTrip = new Trip();
                double duration = Convert.ToDouble(trip["duration"].InnerText); 
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
                totalSeconds = totalSeconds + duration;
                //Convert from seconds to hours
                TimeSpan totalHours = TimeSpan.FromSeconds(totalSeconds);
                //here backslash is must to tell that colon is
                //not the part of format, it just a character that we want in output
                string strTotalHours = totalHours.ToString(@"hh\:mm");

                //Calculate total unapproved hours
                if (approved == false)
                {
                    unapprovedDuration += duration;
                }
                //Calculate total daytime trips
                if (day == true)
                {
                    dayTotal = dayTotal + 1;
                }
                //Calculate total nighttime trips
                else
                {
                    nightTotal = nightTotal + 1;
                }
                //Calculate total highway trips
                if(roadHighway == true)
                {
                    highwayTotal = highwayTotal + 1;
                }
                //Calculate total local trips
                if(roadLocal == true)
                {
                    localTotal = localTotal + 1;
                }
                //Calculate total rural trips
                if(roadRural == true)
                {
                    ruralTotal = ruralTotal + 1;
                }
                //Calculete total light traffic
                if(trafficLight == true)
                {
                    lightTotal = lightTotal + 1;
                }
                //Calculate total med traffic
                if(trafficMed == true)
                {
                    medTotal = medTotal + 1;
                }
                //Calculate total heavy traffic
                if(trafficHeavy == true)
                {
                    heavyTotal = heavyTotal + 1;
                }
                //Calculate total clear trips
                if(weatherClear == true)
                {
                    clearTotal = clearTotal + 1;
                }
                //Calcualte total rainy trips
                if(weatherRain == true)
                {
                    rainTotal = rainTotal + 1;
                }

                trips[index] = theTrip;
                index++;

                //Display unapproved total hours
                TimeSpan totalUnapproved = TimeSpan.FromSeconds(unapprovedDuration);
                //here backslash is must to tell that colon is
                //not the part of format, it just a character that we want in output
                string strUnapprovedHours = totalUnapproved.ToString(@"hh\:mm");
                lblUnapproved.Text = strUnapprovedHours + " Unapproved Hours";
                //Display total hours
                lblHoursTotal.Text = strTotalHours + " Total Hours";
            }
            //Display highway total
            lblHighwayTotal.Text = highwayTotal.ToString();
            //Display local total
            lblLocalTotal.Text = localTotal.ToString();
            //Display rural total
            lblRuralTotal.Text = ruralTotal.ToString();
            //Display light total
            lblLightTotal.Text = lightTotal.ToString();
            //Display med total
            lblMedTotal.Text = medTotal.ToString();
            //Display heavy total
            lblHeavyTotal.Text = heavyTotal.ToString();
            //Display clear total
            lblClearTotal.Text = clearTotal.ToString();
            //Display rainy total
            lblRainTotal.Text = rainTotal.ToString();
            //Display day total
            lblDayTotal.Text = dayTotal + " Day trips total";
            //Display night total
            lblNightTotal.Text = nightTotal + " Night trips total";
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
            
        }

        private void BtnApprove_Click(object sender, EventArgs e)
        {
            
        }

        private void Label5_Click(object sender, EventArgs e)
        {

        }
    }
}