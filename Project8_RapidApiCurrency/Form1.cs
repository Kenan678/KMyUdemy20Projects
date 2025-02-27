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

namespace Project8_RapidApiCurrency
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        decimal dollar = 0;
        decimal euro = 0;
        decimal pound = 0;

        private async void Form1_Load(object sender, EventArgs e)
        {

            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=USD&to=try&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "935f21a3camshea1457b5fa0dbd2p1599c3jsnee7df83a5909" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                response.EnsureSuccessStatusCode();
                var body = await response.Content.ReadAsStringAsync();
                var json = JObject.Parse(body);
                var value = json["result"].ToString();
                lblDollar.Text = "Dollar:    " + value;
                dollar = Convert.ToDecimal(value);
                // Console.WriteLine(body);
                //Euro
            }
            var client2 = new HttpClient();
            var request2 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=EUR&to=try&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "935f21a3camshea1457b5fa0dbd2p1599c3jsnee7df83a5909" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response2 = await client2.SendAsync(request2))
            {
                response2.EnsureSuccessStatusCode();
                var body2 = await response2.Content.ReadAsStringAsync();
                var json2 = JObject.Parse(body2);
                var value2 = json2["result"].ToString();
                lblEuro.Text = "Euro:   " + value2;
                euro = Convert.ToDecimal(value2);
                // Console.WriteLine(body);
            }
            //Pound
            var client3 = new HttpClient();
            var request3 = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://currency-conversion-and-exchange-rates.p.rapidapi.com/convert?from=GBP&to=try&amount=1"),
                Headers =
    {
        { "x-rapidapi-key", "935f21a3camshea1457b5fa0dbd2p1599c3jsnee7df83a5909" },
        { "x-rapidapi-host", "currency-conversion-and-exchange-rates.p.rapidapi.com" },
    },
            };
            using (var response3 = await client3.SendAsync(request3))
            {
                response3.EnsureSuccessStatusCode();
                var body3 = await response3.Content.ReadAsStringAsync();
                var json3 = JObject.Parse(body3);
                var value3 = json3["result"].ToString();
                lblGpb.Text = "Pound:   " + value3;
                pound = Convert.ToDecimal(value3);
                // Console.WriteLine(body);
            }

            txtTotalPrice.Enabled = false;
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            decimal unitPrice = decimal.Parse(txtBrimPrice.Text);

            decimal totalPrice = 0;

            if (rdbDollar.Checked)
            {
                totalPrice = unitPrice * dollar;
            }
            if (rdbEuro.Checked)
            {
                totalPrice = unitPrice * euro;
            }
            if (rdbPound.Checked)
            {
                totalPrice = unitPrice * pound;
            }
            txtTotalPrice.Text = totalPrice.ToString();
        }
    }
}