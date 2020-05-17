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

            double E = 0;
            for (int i = 0; i < 5; ++i)
                E += probs[i] * (i + 1);
            double D = 0;
            for (int i = 0; i < 5; ++i)
                D += (i + 1) * (i + 1) * probs[i];
            D -= E * E;

            int[] stat = new int[5];
            int numExperiments = Convert.ToInt32(numTextBox.Text);
            double Ex = 0;
            double Dx = 0;
            for (int i =0; i <numExperiments; ++i)
            {
                stat[SimulateExperiment(probs)]++;
            }

            
            for (int i = 0; i < 5; ++i)
            {
                double prob = stat[i] * 1.0 / numExperiments;
                Ex += prob * (i + 1);
                Dx += prob * (i + 1) * (i + 1);
                chart1.Series[0].Points.Add(prob);
            }
            Dx -= Ex * Ex;

            double Er = Math.Abs(E - Ex) / E;
            double Dr = Math.Abs(D - Dx) / D;
            eLabel.Text = String.Format("Average: {0} (error = {1}%)",
                         Ex, Convert.ToInt32(Er*100));
            dLabel.Text = String.Format("Variance: {0} (error = {1}%)",
                         Dx, Convert.ToInt32(Dr * 100));

            double chi = 0;
            for (int i =0; i < 5; ++i)
            {
                chi += (stat[i] * stat[i]) / (probs[i] * numExperiments);
            }
            chi -= numExperiments;
            chiLabel.Text = String.Format("{0} > 11.07 is {2}",
                         chi, (chi > 11.07) ? "true" : "false");            
        }
    }
}
