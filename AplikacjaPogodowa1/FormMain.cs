using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.Net;

namespace AplikacjaPogodowa1
{
    public partial class FormMain : Form
    {
        public FormMain()
        {
            InitializeComponent();

            lab_time.Text = DateTime.Now.ToLongTimeString();
            lab_date.Text = DateTime.Now.ToLongDateString();
        }
        string APIKey = "9642cd241a871b5a67d4c66a90eb0bae";

        private void btn_search_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        private void getWeather()
        {
            using (WebClient web = new WebClient())
            {
                string url = string.Format("https://api.openweathermap.org/data/2.5/weather?q={0}&appid={1}", TbCity.Text, APIKey);
                var json = web.DownloadString(url);
                WeatherInfo.root Info = JsonConvert.DeserializeObject<WeatherInfo.root>(json);
                lab_conditions.Text = Info.weather[0].main;
                lab_sunrise.Text = convertDateTime(Info.sys.sunrise).ToString();
                lab_sunset.Text = convertDateTime(Info.sys.sunset).ToString();
                lab_humidity.Text = Info.main.humidity.ToString();
                lab_wind.Text = Info.wind.speed.ToString();
                lab_pressure.Text = Info.main.pressure.ToString();
                lab_temp1.Text = c_Temp(Info.main.temp).ToString();
            }
            
        }
        DateTime convertDateTime(long millisec)

        {

            DateTime day = new DateTime(1970, 1, 1, 0, 0, 0, DateTimeKind.Utc);

            day = day.AddSeconds(millisec).ToLocalTime();

            return day;

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
           lab_time.Text = DateTime.Now.ToLongTimeString();
        }

        private double c_Temp(double kel)
        {
            return kel - 273.15;
        }
 
    }
}
