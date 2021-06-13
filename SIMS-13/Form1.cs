using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SIMS_13
{
    public partial class Form1 : Form
    {
        Generator gen;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            gen = new Generator();
            try
            {
                gen.createExperiments(Convert.ToDouble(p5TB.Text), Convert.ToInt32(nTB.Text));
                int[] X = new int[4] { 0, 1, 2, 3 };
                chart1.Series[0].Points.DataBindXY(X, gen.freq);

                meanLabel.Text = Math.Round(gen.average, 3).ToString() + " (error = " + Math.Round(gen.error_ave, 2).ToString() + "%)";
                variLabel.Text = Math.Round(gen.variance, 3).ToString() + " (error = " + Math.Round(gen.error_var, 2).ToString() + "%)";

                if (gen.chi_square > gen.chi_square_norm)
                {
                    chiLabel.Text = Math.Round(gen.chi_square, 3).ToString() + " > " + gen.chi_square_norm.ToString() + "False";
                }
                else
                {

                    chiLabel.Text = Math.Round(gen.chi_square, 3).ToString() + " <= " + gen.chi_square_norm.ToString() + "True";
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
