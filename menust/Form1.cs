using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace menust
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void sumaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt1.Text);
            double b= Convert.ToDouble(txt2.Text);
            double r = a + b;
            lblresultado.Text = r.ToString();



        }

        private void restaToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt1.Text);
            double b = Convert.ToDouble(txt2.Text);
            double r = a - b;
            lblresultado.Text = r.ToString();

        }

        private void multiplicacionToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt1.Text);
            double b = Convert.ToDouble(txt2.Text);
            double r = a * b;
            lblresultado.Text = r.ToString();

        }

        private void divisionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            double a = Convert.ToDouble(txt1.Text);
            double b = Convert.ToDouble(txt2.Text);
            double r = a / b;
            lblresultado.Text = r.ToString();

        }
    }
}
