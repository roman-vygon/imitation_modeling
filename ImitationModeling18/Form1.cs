using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImitationModeling18
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        List<double> freq = new List<double>(new double[1000]);

        double mu;
        int N;
        double lambda;
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            N = Convert.ToInt32(nTextBox.Text);
            mu = Convert.ToDouble(muTextBox.Text);
            lambda = Convert.ToDouble(lambdaTextBox.Text);
            int numEvents = Convert.ToInt32(numTextBox.Text);
            double t = 0;
            listBox1.Items.Clear();
            Queue q = new Queue(mu, rnd);
            for (int i = 0; i < N; ++i)
                q.addOperator(new Operator(lambda, rnd, q, i + 1));
            if (numEvents > 10000)
            {
                listBox1.Items.Add("Output disabled due to big number of events");
            }
            for (int _ = 0; _ < numEvents; ++_)
            {
                int total_people = q.cnt_all;
                Agent a = q;
                double tmin = q.NextEventTime(t);
                foreach (Operator op in q.ops)
                {
                    double t_cur = op.NextEventTime(t);
                    if (t_cur < tmin)
                    {
                        tmin = t_cur;
                        a = op;
                    }
                }                
                a.processEvent(tmin);
                freq[total_people] += tmin - t;
                if (numEvents <= 10000)
                {
                    string time = string.Format("{0:D2}:{1:D2}",
                    Convert.ToInt32(t / 60),
                    Convert.ToInt32(t) % 60) + " ";
                    listBox1.Items.Add(time + a.ToString() + " processed num people:" + tmin );
                }
                t = tmin;
            }

        }
        private double binpow(double a, int b)
        {
            double res = 1;
            while (b != 0)
            {
                if ((b & 1) == 1)
                    res *= a;
                a *= a;
                b /= 2;
            }
            return res;
        }

        private long fact(int i)
        {
            long ans = 1;
            while (i > 1)
                ans *= --i;
            return ans;
        }
        private List<double> getProbs(int n)
        {
            double p = mu / lambda;

            List <double> probs = new List<double>() {0};

            for (int i = 0; i <= n; i++)            
                probs[0] +=binpow(p, i) / fact(i);
            

            probs[0] += binpow(p, n + 1) / (fact(n) * (n - p));
            probs[0] = 1.0 / probs[0];

            for (int i = 1; i <= 20; i++)
            {
                probs.Add(0);
                if (i < n)                
                    probs[i] = probs[0] * binpow(p, i) / fact(i);                
                else                
                    probs[i] = probs[0] * binpow(p, i) / (fact(n) * binpow(n, i - n));                
            }
            return probs;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            List<double> probs = getProbs(10);
            foreach (double prob in probs)
                chart1.Series[0].Points.Add(prob);
            for (int i = 0; i < 10; ++i)
                chart1.Series[1].Points.Add(freq[i] * 1.0 / freq.Sum());
            Console.WriteLine(probs.Sum());
        }

    }
}


