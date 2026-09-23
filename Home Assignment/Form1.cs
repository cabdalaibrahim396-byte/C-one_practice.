using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Home_assignment
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnshowdata_Click(object sender, EventArgs e)
        {
            String Dayofweek, Nameofmonth, numericday, year, fulldate;

            Dayofweek = txtdayoftheweek.Text;

            Nameofmonth = txtdayofthemonth.Text;

            numericday =txtmonth.Text;

            year = txtyear.Text;


            fulldate = Dayofweek + " ,"+Nameofmonth +","+numericday +","+year;

            lbloutput.Text = fulldate;


        }

        private void lbldayoftheweek_Click(object sender, EventArgs e)
        {

        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtdayoftheweek.Clear();
            txtdayofthemonth.Clear  ();
            txtyear.Clear ();


            lbloutput.Text = "";
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnexit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
