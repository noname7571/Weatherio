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
using System.Net.Http;
using System.Net;

namespace Weatherio
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            getWeather();
        }

        string APIKey = "2fde3d3a8ff84891808213950242512";

        void getWeather()
        {
            using (WebClient webClient = new WebClient())
            {
                string url = string.Format("http://api.weatherapi.com/v1/current.json?key={0}&q={1}&aqi=no", APIKey, textBoxCity.Text);
                try
                {
                    var json = webClient.DownloadString(url);
                    WeatherInfo.Root Info = JsonConvert.DeserializeObject<WeatherInfo.Root>(json);

                    IconBox.ImageLocation = Info.Current.Condition.Icon;
                    RegionLabel.Text = Info.Location.Region;
                    CountryLabel.Text = Info.Location.Country;
                    TimeLabel.Text = Info.Location.Localtime;
                    TempLabel.Text = Info.Current.Temp_c.ToString() + "°C";
                    CondLabel.Text = Info.Current.Condition.Text;
                    if (Info.Current.Wind_kph != 0)
                    {
                        WindLabel.Text = Info.Current.Wind_kph.ToString() + " kph, " + Info.Current.Wind_dir;
                    }
                    else
                    {
                        WindLabel.Text = Info.Current.Wind_kph.ToString() + " kph";
                    }
                    HumLabel.Text = Info.Current.Humidity.ToString();
                    UvLabel.Text = Info.Current.Uv.ToString();
                    PressureLabel.Text = Info.Current.Pressure_mb.ToString() + " hPa";
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error: " + ex.Message);
                }
            }
        }
    }
}
