using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Oefening3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }       

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                double berekeningdollar = Double.Parse(textBox2.Text)*0.98;
                textBox1.Text = berekeningdollar.ToString();

                
                textBox3.Text = "";
                
                textBox4.Text ="";
                textBox5.Text= "";
                textBox6.Text= "";
            }
        }

        private void textBox3_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double berekeningdollar = Double.Parse(textBox3.Text)*1.11;
                textBox1.Text = berekeningdollar.ToString();

                
                textBox2.Text = "";
                textBox4.Text ="";
                textBox5.Text= "";
                textBox6.Text= "";
            }

        }

       
        private void textBox4_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double berekeningdollar = Double.Parse(textBox4.Text)*0.0069;
                textBox1.Text = berekeningdollar.ToString();

               
                textBox2.Text = "";
                textBox3.Text ="";
                textBox5.Text= "";
                textBox6.Text= "";
            }


        }

        private void textBox5_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double berekeningdollar = Double.Parse(textBox5.Text)*0.012;
                textBox1.Text = berekeningdollar.ToString();

                
                textBox2.Text ="";
                textBox3.Text ="";
                textBox4.Text= "";
                textBox6.Text= "";
            }

        }

        private void textBox6_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                double berekeningdollar = Double.Parse(textBox6.Text)*1.02;
                textBox1.Text = berekeningdollar.ToString();

              ;
                textBox2.Text ="";
                textBox3.Text ="";
                textBox4.Text= "";
                textBox5.Text= "";
            }


        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {
                double berekeningeuro = Double.Parse(textBox1.Text)*1.03;
                double berekeningpound = Double.Parse(textBox1.Text)*0.90;
                double berekeningyen = Double.Parse(textBox1.Text)*145.32;
                double berekeningrupees = Double.Parse(textBox1.Text)*82.83;
                double berekeningfrank = Double.Parse(textBox1.Text)*0.99;



                textBox2.Text = berekeningeuro.ToString();
                textBox3.Text = berekeningpound.ToString();
                textBox4.Text = berekeningyen.ToString();
                textBox5.Text = berekeningrupees.ToString();
                textBox6.Text = berekeningfrank.ToString();




            }

        }
    }
}
