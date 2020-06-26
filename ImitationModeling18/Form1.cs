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
        public Form1()
        {
            InitializeComponent();
        }        

        private void button1_Click(object sender, EventArgs e)
        {
            int N = Convert.ToInt32(nTextBox.Text);
            double mu = Convert.ToDouble(muTextBox.Text);
            double lambda = Convert.ToDouble(lambdaTextBox.Text);
            int numEvents = Convert.ToInt32(numTextBox.Text);
            double t = 0;
            Queue q = new Queue(mu, rnd);
            for (int i = 0; i <N; ++i)            
                q.addOperator(new Operator(lambda, rnd, q, i+1));
            
            for (int _ = 0; _ < numEvents; ++_)
            {
                Agent a = q;
                double tmin = q.nextEventTime(t);
                foreach (Operator op in q.ops)
                {
                    double t_cur = op.nextEventTime(t);
                    if (t_cur < tmin)
                    {
                        tmin = t_cur;
                        a = op;
                    }
                }
                a.processEvent();
                t = tmin;
                string time = string.Format("{0:D2}:{1:D2}",
                Convert.ToInt32(t/60),
                Convert.ToInt32(t) % 60) + " ";
                listBox1.Items.Add(time + a.ToString() + " processed");
            }

        }
    }
}

