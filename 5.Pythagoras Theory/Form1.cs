using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5.Pythagoras_Theory
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sideA = Convert.ToDouble(textBox1.Text);
            double sideB = Convert.ToDouble(textBox2.Text);

            //calculate the hypotenuse using pythagoras theory
            double hypotenuse = Math.Sqrt(Math.Pow(sideA, 2) +  Math.Pow(sideB, 2));

            //display the result
            textBox3.Text = hypotenuse.ToString ();


        }
    }
}
