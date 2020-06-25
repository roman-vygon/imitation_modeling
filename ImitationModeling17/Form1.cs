using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImitationModeling17
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        double t1,t2;
        double[] lambdas = new double[2];
        SortedSet<double> sortedFlow = new SortedSet<double>();
        List<double> flow = new List<double>();
        

        public Form1()
        {
            InitializeComponent();
        }        

        private double exponentialRV(double lambda)
        {
            return -1.0 * Math.Log(rnd.NextDouble()) / lambda;
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            t1 = t2 = 0;
            flow.Clear();            
            lambdas[0] = Convert.ToDouble(lambdaOneTextBox.Text);
            lambdas[1] = Convert.ToDouble(lambdaTwoTextBox.Text);
            timer1.Start();
        }
        private List<int> Bucketize(List<double> source, int totalBuckets)
        {
            var min = source.Min();
            var max = source.Max();
            int[] bucketsArray = new int[totalBuckets];
            List<int> buckets = new List<int>(bucketsArray);

            var bucketSize = (max - min) / totalBuckets;
            foreach (var value in source)
            {
                int bucketIndex = 0;
                if (bucketSize > 0.0)
                {
                    bucketIndex = (int)((value - min) / bucketSize);
                    if (bucketIndex == totalBuckets)
                    {
                        bucketIndex--;
                    }
                }
                buckets[bucketIndex]++;
            }
            return buckets;
        }

        private double probT(double lambda, int n, double T)
        {
            double prob = 1;
            for (int i = 1; i <= n; ++i)
            {
                prob *= lambda * T;
                prob /= i;
            }
            prob *= Math.Exp(-1 * lambda * T);
            return prob;
        }
        int lowerIndex(List<double> arr, double x)
        {
            int l = 0, h = arr.Count - 1;
            while (l <= h)
            {
                int mid = (l + h) / 2;
                if (arr[mid] >= x)
                    h = mid - 1;
                else
                    l = mid + 1;
            }
            return l;
        }

        
        int upperIndex(List<double> arr, double y)
        {
            int l = 0, h = arr.Count - 1;
            while (l <= h)
            {
                int mid = (l + h) / 2;
                if (arr[mid] <= y)
                    l = mid + 1;
                else
                    h = mid - 1;
            }
            return h;
        }

        
        int countInRange(List <double> arr, double x, double y)
        {            
            return upperIndex(arr, y) - lowerIndex(arr, x) + 1;            
        }
        private void button2_Click(object sender, EventArgs e)
        {
            chartTau.Series[0].Points.Clear();
            chartT.Series[0].Points.Clear();
            chartTau.Series[1].Points.Clear();
            chartT.Series[1].Points.Clear();
            timer1.Stop();
            double T1 = Math.Max(t1, t2);
            double T = T1 / 100;
            for (int n = 0; n < 1000; ++n)
            {
                double prob = probT(lambdas[0] + lambdas[1], n, T);
                if (n > (lambdas[0]+lambdas[1])*T &&  prob < 1e-5)
                    break;
                chartT.Series[0].Points.Add(prob);
            }
            for (double tau = 0; tau < 100; tau+=0.01)
            {
                double prob = (lambdas[0]+lambdas[1])*Math.Exp(-1 * tau * (lambdas[0] + lambdas[1]));
                if (tau > 10 && prob < 1e-3)
                    break;
                chartTau.Series[0].Points.AddXY(tau, prob);
            }
            flow.Sort();
            List<double> taus = new List<double>();
            for (int i = 1; i < flow.Count; ++i)
                taus.Add(flow[i] - flow[i - 1]);
            int numBuckets = 10;
            List<int> buckets = Bucketize(taus, numBuckets);
            var min = taus.Min();
            var max = taus.Max();
            var bucketSize = (max - min) / numBuckets;

            double k = min ;

            for (int i =0; i < numBuckets; ++i)
            {
                chartTau.Series[1].Points.AddXY(k, buckets[i]*1.0/buckets.Sum());
                k += bucketSize;
            }
            List<int> freq = new List<int>(new int[10000]);
            int maximum = 0;
            for(int i = 0; i < 100000; ++i)
            {
                double a = rnd.NextDouble() * (T1 - T);
                int count = countInRange(flow, a, a + T);
                if (maximum < count)
                    maximum = count;
                freq[count]++;
            }
            for (int i = 0; i <= maximum; ++i)
            {
                chartT.Series[1].Points.Add(freq[i]*1.0 / 100000);
            }
            timer1.Start();
        }

        private void chartTTwo_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            t1 += exponentialRV(lambdas[0]);
            t2 += exponentialRV(lambdas[0]);
            flow.Add(t1);
            flow.Add(t2);
            
            chart1.ChartAreas[0].AxisX.Maximum = Math.Round(Math.Max(t1,t2));
            chart1.ChartAreas[0].AxisX.Minimum = Math.Round(Math.Min(t1, t2) - 10);
            chart1.Series[0].Points.AddXY(Math.Round(t1,2), 1);
            chart1.Series[0].Points.AddXY(Math.Round(t2,2), 2);
        }
    }
}
