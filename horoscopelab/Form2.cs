/*This project */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json.Linq;
using System.Net.Http;
using Newtonsoft.Json;
using System.Net;

namespace horoscopelab
{
    public partial class Form2 : Form
    {
        public String zsign;
        public String xdate;
        public string day = "today";
        public string day2 = "today";

        public object Settings { get; private set; }

        string rdzsign { get; set; }
        string rdxdate { get; set; }
        //public String task;
        //public Form2()
        //{
        //    InitializeComponent();
        //}

        public Form2(string zsign)
        {
            InitializeComponent();
            //Provided by Mr. Bandi
            this.rd_today.Checked = true;
            rd_yesterday.CheckedChanged += new EventHandler(rd_changed);
            rd_today.CheckedChanged += new EventHandler(rd_changed);
            rd_tomorrow.CheckedChanged += new EventHandler(rd_changed);
            //
            rdzsign = zsign;
            rdxdate = xdate;
            //results.Text += zsign; // this is placing the msg on the txt box
            this.Text = "Daily Horoscope v1.0";

            var finalResult = call2(zsign, day);
            var second = call(zsign);
            results.AppendText(finalResult.Result + "\n\nAnother tip from ohmanda: \n" + second.Result);

            //label3.Text = xdate;
            label3.Text = xdate;

            byte[] newBytes = new Byte[] { 169 };
            var encoding = Encoding.GetEncoding(1252);
            string string1 = encoding.GetString(newBytes, 0, newBytes.Length);
            label2.Text = string1 + " Ayraa Informatics inc 2020";

            if (zsign == "aries") { aries.BackgroundImage = Properties.Resources.aries; }
            if (zsign == "taurus") { aries.BackgroundImage = Properties.Resources.taurus; }
            if (zsign == "gemini") { aries.BackgroundImage = Properties.Resources.gemini; }
            if (zsign == "cancer") { aries.BackgroundImage = Properties.Resources.cancer; }
            if (zsign == "leo") { aries.BackgroundImage = Properties.Resources.leo; }
            if (zsign == "virgo") { aries.BackgroundImage = Properties.Resources.virgo; }
            if (zsign == "scorpio") { aries.BackgroundImage = Properties.Resources.scorpio; }
            if (zsign == "sagittarius") { aries.BackgroundImage = Properties.Resources.sagittarius; }
            if (zsign == "capricorn") { aries.BackgroundImage = Properties.Resources.capricorn; }
            if (zsign == "aquarius") { aries.BackgroundImage = Properties.Resources.aquarius; }
            if (zsign == "pisces") { aries.BackgroundImage = Properties.Resources.pisces; }
            if (zsign == "libra") { aries.BackgroundImage = Properties.Resources.libra; }
        }        

        async Task<string> call(string zsing){
            HttpClient httpClient = new HttpClient();
            using var client = httpClient;
            var response = await client.GetStringAsync("http://ohmanda.com/api/horoscope/"+zsing).ConfigureAwait(false);
            var o = JObject.Parse(response);
            var sign = (string)o["sign"];
            
            var horoscope = (string)o["horoscope"];
            return horoscope;
        }

        async Task<string> call2(string zsign, string day)
        {
            var uri = String.Format("https://aztro.sameerkumar.website/?sign={0}&day={1}", zsign, day);
            var xdata = new Dictionary<string, string> { { "sign", zsign }, { "day", day } };
            var json = JsonConvert.SerializeObject(xdata);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            using (var client = new HttpClient())
            {
                Console.WriteLine("Posting...");
                var response = client.PostAsync(uri, httpContent).Result;

                if (response.StatusCode == HttpStatusCode.OK)
                {
                    response.EnsureSuccessStatusCode();
                    var responseBody = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(responseBody);
                    var o = JObject.Parse(responseBody);
                    this.xdate = (string)o["current_date"];
                    var xcompatibility = (string)o["compatibility"];
                    var xlucky_time = (string)o["lucky_time"];
                    var xlucky_number = (string)o["lucky_number"];
                    var xcolor = (string)o["color"];
                    var xdate_range = (string)o["date_range"];
                    var xmood = (string)o["mood"];
                    var xdescription = (string)o["description"];
                    return
                        xdate 
                        + "\nCompatibility: " + xcompatibility 
                        + "\nLucky time: " + xlucky_time 
                        + "\nLucky number: " + xlucky_number
                        + "\nColor: " + xcolor 
                        + "\nDate range: " + xdate_range 
                        +"\nMood: "+ xmood 
                        +"\nDescription: "+ xdescription;
                }
                else
                {
                    return "Data Off";
                }
            }
        }
        //provided by Mr.Bandi
        private void rd_changed(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton; // not used?

            if (rd_yesterday.Checked)
            {
                this.day2 = "yesterday";
                
            }
            else if (rd_today.Checked)
            {
                this.day2 = "today";
            }
            else if (rd_tomorrow.Checked)
            {
                this.day2 = "tomorrow";
            }
            xdate = rdxdate;
            results.Clear();
            zsign = rdzsign;
            
            var secondResult = call(zsign);
            var finalResult2 = call2(zsign, day2);
            
            results.AppendText(finalResult2.Result + "\n\nAnother tip from ohmanda: \n" + secondResult.Result);
            label3.Text = xdate;
        }
        //
        private void pisces_Click(object sender, EventArgs e)
        {

        }

        private void virgo_Click(object sender, EventArgs e)
        {

        }

        private void aquarius_Click(object sender, EventArgs e)
        {

        }

        private void menu_Click(object sender, EventArgs e)
        {
            try
            {
                bool menuClicked = true;
                if (menuClicked)
                {
                    this.Hide();
                    Form1 f1 = new Form1();
                    f1.ShowDialog();
                }
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message);
            }
        }

        private void leo_Click(object sender, EventArgs e)
        {

        }

        private void capricorn_Click(object sender, EventArgs e)
        {

        }

        private void cancer_Click(object sender, EventArgs e)
        {

        }

        private void sagittarius_Click(object sender, EventArgs e)
        {

        }

        private void gemini_Click(object sender, EventArgs e)
        {

        }

        private void scorpio_Click(object sender, EventArgs e)
        {

        }

        private void taurus_Click(object sender, EventArgs e)
        {

        }

        private void libra_Click(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            //string day = "yesterday";
            //string zsign = this.zsign;            
            //var other = call2(zsign, day);
            //results.Clear();
            //results.AppendText(other.Result);                     
        }

        private void radioButton1_Click(object sender, EventArgs e)
        {
            //this.day = "Yesterday";
            //var finalResult = call2(zsign, day);
            //results.AppendText(finalResult.Result);
        }
    }
}
