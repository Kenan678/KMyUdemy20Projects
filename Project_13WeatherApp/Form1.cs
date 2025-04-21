using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_13WeatherApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private async void Form1_Load(object sender, EventArgs e)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://open-weather13.p.rapidapi.com/city/london/EN"),
                Headers =
    {
        { "x-rapidapi-key", "935f21a3camshea1457b5fa0dbd2p1599c3jsnee7df83a5909" },
        { "x-rapidapi-host", "open-weather13.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var farenheit = json["main"]["feels_like"].ToString();
                var windSpeed = json["wind"]["speed"].ToString();
                var humidity = json["main"]["humidity"].ToString();
                lblHumidty.Text = humidity;
                lblWindSpeed.Text = windSpeed;
                lblFarenheit.Text = farenheit;
                decimal celsius = (decimal.Parse(farenheit) - 32) * 5 / 9;
                lblCelcius.Text = celsius.ToString("0.00");

            }
        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
