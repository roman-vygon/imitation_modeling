using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImitationModeling9
{
    public partial class Form1 : Form
    {
        Random r = new Random(42);
        public Form1()
        {
            InitializeComponent();
        }

        private void changeTextBox()
        {
            double left = 1.0;
            for (int i =0; i < 4; ++i)
            {
                Control textBox = this.Controls.Find("prob" + (i+1).ToString()+"TextBox", true)[0];
                double prob;
                if (Double.TryParse(textBox.Text, out prob))                
                    left -= prob;
            }
            prob5TextBox.Text = Convert.ToString(left);
        }

        private void prob1TextBox_TextChanged(object sender, EventArgs e)
        {
            changeTextBox();
        }

        private void prob2TextBox_TextChanged(object sender, EventArgs e)
        {
            changeTextBox();
        }

        private void prob3TextBox_TextChanged(object sender, EventArgs e)
        {
            changeTextBox();
        }

        private void prob4TextBox_TextChanged(object sender, EventArgs e)
        {
            changeTextBox();
        }
        private int SimulateExperiment(double[] probs)
        {
            int k = 0;
            double A = r.NextDouble();
            while (A > 0)
                A -= probs[k++];
            return k - 1;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            double prob5;
            if (!Double.TryParse(prob5TextBox.Text, out prob5))
                return;
            if (prob5 < 0)
                return;
            chart1.Series[0].Points.Clear();
            double[] probs = new double[5];
            for (int i = 1; i <= 5; ++i)
            {
                Control textBox = this.Controls.Find("prob" + i.ToString() + "TextBox", true)[0];
                double textProb;
                if (Double.TryParse(textBox.Text, out textProb))
                    probs[i - 1] = textProb;
            }
            
            int[] stat = new int[5];
            int numExperiments = Convert.ToInt32(numTextBox.Text);
            for (int i =0; i <numExperiments; ++i)
            {
                stat[SimulateExperiment(probs)]++;
            }
            double error = 0;
            for (int i = 0; i < 5; ++i)
            {
                double prob = stat[i] * 1.0 / numExperiments;
                error += (prob - probs[i]) * (prob - probs[i]);
                chart1.Series[0].Points.Add(prob);
            }
            error /= 5;
            errorLabel.Text = "MSE: " + error.ToString();
        }
    }
}
