/*This project is supposed to get information
 * from a source website and publish on the aplication.*/

/*Author: Caio Victor Goncalves
 *Date: 2020-12-18
 */

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace horoscopelab
{
    public partial class Form1 : Form
    {
        public String zsign;
        public String task;
        public bool ariesClicked, taurosClicked, cancerClicked, leoClicked, virgoClicked, libraClicked,
            scorpioClicked, sagittariusClicked, capricornClicked, aquariusClicked, geminiClicked ,piscesClicked = false;

        private void virgo_Click(object sender, EventArgs e)
        {
            virgoClicked = true;
            zsign = "virgo";
            if (virgoClicked && zsign == "virgo")
            {
                this.Hide();
                Form2 f2 = new Form2(zsign);
                f2.ShowDialog();
            }
        }

        private void libra_Click(object sender, EventArgs e)
        {
            libraClicked = true;
            zsign = "libra";
            if (libraClicked && zsign == "libra")
            {
                this.Hide();
                Form2 f2 = new Form2(zsign);
                f2.ShowDialog();
            }
        }

        private void scorpio_Click(object sender, EventArgs e)
        {
            scorpioClicked = true;
            zsign = "scorpio";
            if (scorpioClicked && zsign == "scorpio")
            {
                this.Hide();
                Form2 f2 = new Form2(zsign);
                f2.ShowDialog();
            }
        }

        private void sagittarius_Click(object sender, EventArgs e)
        {
            sagittariusClicked = true;
            zsign = "sagittarius";
            if (sagittariusClicked && zsign == "sagittarius")
            {
                this.Hide();
                Form2 f2 = new Form2(zsign);
                f2.ShowDialog();
            }
        }

        private void capricorn_Click(object sender, EventArgs e)
        {
            capricornClicked = true;
            zsign = "capricorn";
            if (capricornClicked && zsign == "capricorn")
            {
                this.Hide();
                Form2 f2 = new Form2(zsign);
                f2.ShowDialog();
            }
        }

        private void aquarius_Click(object sender, EventArgs e)
        {
            aquariusClicked = true;
            zsign = "aquarius";
            if (aquariusClicked && zsign == "aquarius")
            {
                this.Hide();
                Form2 f2 = new Form2(zsign);
                f2.ShowDialog();
            }
        }

        private void leo_Click(object sender, EventArgs e)
        {
            leoClicked = true;
            zsign = "leo";
            if (leoClicked && zsign == "leo")
            {
                this.Hide();
                Form2 f2 = new Form2(zsign);
                f2.ShowDialog();
            }
        }

        private void cancer_Click(object sender, EventArgs e)
        {
            cancerClicked = true;
            zsign = "cancer";
            if (cancerClicked && zsign == "cancer")
            {
                this.Hide();
                Form2 f2 = new Form2(zsign);
                f2.ShowDialog();
            }
        }

        private void gemini_Click(object sender, EventArgs e)
        {
            geminiClicked = true;
            zsign = "gemini";
            if (geminiClicked && zsign == "gemini")
            {
                this.Hide();
                Form2 f2 = new Form2(zsign);
                f2.ShowDialog();
            }
        }

        private void select_date_ValueChanged(object sender, EventArgs e)
        {
            DateTime datex = select_date.Value.Date;
            datex = DateTime.ParseExact(datex.ToString("MMMM d"), "MMMM d", CultureInfo.InvariantCulture);
            if (datex.Date >= DateTime.ParseExact("March 21", "MMMM d", null) && datex.Date <= DateTime.ParseExact("April 19", "MMMM d", null)) { zsign = "Aries".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("April 20", "MMMM d", null) && datex.Date <= DateTime.ParseExact("May 20", "MMMM d", null)) { zsign = "Taurus".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("May 21", "MMMM d", null) && datex.Date <= DateTime.ParseExact("June 21", "MMMM d", null)) { zsign = "Gemini".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("June 22", "MMMM d", null) && datex.Date <= DateTime.ParseExact("July 22", "MMMM d", null)) { zsign = "Cancer".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("July 23", "MMMM d", null) && datex.Date <= DateTime.ParseExact("August 22", "MMMM d", null)) { zsign = "Leo".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("August 23", "MMMM d", null) && datex.Date <= DateTime.ParseExact("September 22", "MMMM d", null)) { zsign = "Virgo".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("September 23", "MMMM d", null) && datex.Date <= DateTime.ParseExact("October 23", "MMMM d", null)) { zsign = "Libra".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("October 24", "MMMM d", null) && datex.Date <= DateTime.ParseExact("November 22", "MMMM d", null)) { zsign = "Scorpio".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("November 23", "MMMM d", null) && datex.Date <= DateTime.ParseExact("December 21", "MMMM d", null)) { zsign = "Sagittarius".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("December 22", "MMMM d", null) && datex.Date <= DateTime.ParseExact("January 19", "MMMM d", null)) { zsign = "Capricorn".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("January 20", "MMMM d", null) && datex.Date <= DateTime.ParseExact("February 18", "MMMM d", null)) { zsign = "Aquarius".ToLower(); }
            if (datex.Date >= DateTime.ParseExact("February 19", "MMMM d", null) && datex.Date <= DateTime.ParseExact("March 20", "MMMM d", null)) { zsign = "Pisces".ToLower(); }
        }        

        private void taurus_Click(object sender, EventArgs e)
        {
            taurosClicked = true;
            zsign = "taurus";
            if (taurosClicked && zsign == "taurus")
            {
                this.Hide();
                Form2 f2 = new Form2(zsign);
                f2.ShowDialog();
            }
        }

        

        private void aries_Click(object sender, EventArgs e)
        {
            try
            {
                ariesClicked = true;
                zsign = "aries"; //this is the msg sent when this button is clicked
                if (ariesClicked && zsign == "aries")
                {
                    this.Hide();
                    Form2 f2 = new Form2(zsign);
                    f2.ShowDialog();
                }
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message);
            }
        }

        
        public Form1()
        {
            InitializeComponent();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            try
            {
                if (String.IsNullOrEmpty(zsign))
                {
                    MessageBox.Show("Empty Date");
                }
                else
                {
                    this.Hide();
                    Form2 f2 = new Form2(zsign);
                    f2.ShowDialog();
                }
            }
            catch (Exception es)
            {

                MessageBox.Show(es.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void pisces_Click(object sender, EventArgs e)
        {
            piscesClicked = true;
            zsign = "pisces"; //this is the msg sent when this button is clicked
            if (piscesClicked && zsign == "pisces")
            {
                this.Hide();
                Form2 f2 = new Form2(zsign);
                f2.ShowDialog();
            }
        }
    }
}
