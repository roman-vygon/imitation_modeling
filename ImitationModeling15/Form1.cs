using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace ImitationModeling15
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        double[,] q = new double[,] { { -0.4, 0.3, 0.1 }, { 0.4, -0.8, 0.4 }, { 0.1, 0.4, -0.5 } };
        bool tickEnabled = false;
        int state = 0;
        string[] states = { "Ясно", "Облачно", "Пасмурно" };
        double tau = 0;
        public Form1()
        {
            InitializeComponent();            

        }

        private double generate_tau(int state)
        {
            return Math.Log(rnd.NextDouble()) / q[state, state];
        }
        private void button1_Click(object sender, EventArgs e)
        {
            tickTimer.Start();
            state = 0;
            tau = Math.Log(rnd.NextDouble()) / q[state, state];
            chart1.Series[0].Points.Add(state+1);
        }
        private int simulate_experiment(double[] probs)
        {
            int k = 0;
            double A = rnd.NextDouble();
            while (A > 0)
                A -= probs[k++];
            return k - 1;
        }

        private void tickTimer_Tick(object sender, EventArgs e)
        {            
            tau -= 1;
            if (tau < 0)
            {
                double[] p = new double[3];
                for (int j = 0; j < 3; ++j)
                {
                    if (state == j)
                        p[j] = 0;
                    else
                        p[j] = -1 * q[state, j] / q[state, state];
                }
                int next_state = simulate_experiment(p);
                tau = generate_tau(next_state);

                state = next_state;                
                chart1.Series[0].Points.Add(state+1);
            }
        }
    }
}
