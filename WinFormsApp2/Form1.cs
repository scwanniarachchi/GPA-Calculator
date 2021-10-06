using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            txt1.Text = "";
            txt2.Text = "";
            txt3.Text = "";
            txt4.Text = "";
            txt5.Text = "";
            lblavg.Text = "";
            lblcls.Text = "";
            lbltot.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double Module1 = double.Parse(txt1.Text);
            double Module2 = double.Parse(txt2.Text);
            double Module3 = double.Parse(txt3.Text);
            double Module4 = double.Parse(txt4.Text);
            double Module5 = double.Parse(txt5.Text);

            double Total = Module1 + Module2 + Module3 + Module4 + Module5;

            double Average = Total / 5;

            lbltot.Text = Total.ToString();

            lblavg.Text = Average.ToString();

            if(Average>=75)
            {
                lblcls.Text = "First Class Upper";
            }
            else if(Average>=65 && Average<=74)
            {
                lblcls.Text = "2nd Class Upper";
            }
            else if(Average>=55 && Average<=64)
            {
                lblcls.Text = "2nd Class Lower";
            }
            else if(Average>=45 && Average<=54)
            {
                lblcls.Text = "General Pass";
            }
            else
            {
                lblcls.Text = "You are not progressing to the next semester";
            }

        }
    }
}
