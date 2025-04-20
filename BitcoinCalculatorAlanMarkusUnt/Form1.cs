using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;

namespace BitcoinCalculatorAlanMarkusUnt
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void Display(float rate, string symbol)
        {
            ResultLabel.Visible = true;
            TulemusLabel.Visible = true;
            float result = float.Parse(BitcoinAmountInput.Text) * rate;
            ResultLabel.Text = $"{result} {symbol}";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            float amount;
            bool success = float.TryParse(BitcoinAmountInput.Text, out amount);
            if (!success || amount <= 0f)
            {
                MessageBox.Show("Arv on negatiivne või ei ole arv", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (CurrencySelector.SelectedItem == null)
            {
                MessageBox.Show("Palun vali valuuta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            string selectedCurrency = CurrencySelector.SelectedItem.ToString();
            if (selectedCurrency == "USD")
            {
                BitcoinRates bitcoinRates = GetRates();
                Display((float)bitcoinRates.Data.BTCUSD.VALUE, "$");
            }
            else if (selectedCurrency == "EUR")
            {
                BitcoinRates bitcoinRates = GetRates();
                Display((float)bitcoinRates.Data.BTCEUR.VALUE, "€");
            }
            else if (selectedCurrency == "GBP")
            {
                BitcoinRates bitcoinRates = GetRates();
                Display((float)bitcoinRates.Data.BTCGBP.VALUE, "£");
            }
            else if (selectedCurrency == "EEK")
            {
                BitcoinRates bitcoinRates = GetRates();
                Display((float)bitcoinRates.Data.BTCEUR.VALUE * 15.6466f, "EEK");
            }
            else
            {
                MessageBox.Show("Palun vali valuuta", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static BitcoinRates GetRates()
        {
            string url = "https://data-api.coindesk.com/index/cc/v1/latest/tick?market=cadli&instruments=BTC-USD,BTC-EUR,BTC-GBP&apply_mapping=true&groups=VALUE&KEY=96488e47e6b8cffc371231d2df0a7d4503ca3acb8ec834780ab99cb9d2f07a80";
            HttpWebRequest request = (HttpWebRequest)WebRequest.Create(url);
            request.Method = "GET";

            var webResponse = request.GetResponse();
            var webStream = webResponse.GetResponseStream();

            BitcoinRates bitcoin;
            using (var responseReader = new StreamReader(webStream))
            {
                var data = responseReader.ReadToEnd();
                bitcoin = JsonConvert.DeserializeObject<BitcoinRates>(data);
            }
            return bitcoin;
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void ResultLabel_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
