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
        private int SimulateExperiment(double[] probs)
        {
            int k = 0;
            double A = r.NextDouble();
            while (A > 0)
                A -= probs[k++];
            return k - 1;
        }
        private int generatePoisson(double lambda)
        {
            
            int m = 0;
            double S = 0;
            while (true)
            {
                double alpha = r.NextDouble();
                S += Math.Log(alpha);
                if (S < -lambda)
                    break;
                else
                    ++m;
            }
            return m;

        }
        private int factorial(int n)
        {
            int res = 1;
            if (n == 0)
                return 0;
            while (n != 1)
            {
                res = res * n;
                n = n - 1;
            }
            return res;
        }
        private double poissonProb(double lambda, int k)
        {
            return (Math.Pow(lambda, k) / factorial(k)) * Math.Exp(-lambda);
        }

        private double normal_first_method()
        {
            double result = 0;
            for (int i = 0; i < 12; ++i)
                result += r.NextDouble();
            return result - 6;            
        }

        private double normal_second_method()
        {
            double dzeta = normal_first_method();
            return dzeta + ((dzeta * dzeta * dzeta - 3 * dzeta) / 240);
        }

        private double normal_third_method()
        {
            double alpha1 = r.NextDouble();
            double alpha2 = r.NextDouble();
            return Math.Sqrt(-2 * Math.Log(alpha1)) * Math.Cos(2 * Math.PI * alpha2);
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
        private double normal_density(double x, double mean, double var)
        {
            return (1.0 / Math.Sqrt(var * 2 * Math.PI)) * Math.Exp((-1 * (x - mean) * (x - mean)) / (2 * var));
        }
        private void button1_Click(object sender, EventArgs e)
        {
            chart1.Series[0].Points.Clear();
            chart1.Series[1].Points.Clear();
            chart1.ChartAreas[0].AxisX.CustomLabels.Clear();
            double mean = Convert.ToDouble(meanTextBox.Text);
            double variance = Convert.ToDouble(varianceTextBox.Text);
            int num = Convert.ToInt32(numTextBox.Text);
            int method = Convert.ToInt32(comboBox1.SelectedItem);
            Func<double>[] methods = {normal_first_method, normal_second_method, normal_third_method};
            List<double> results = new List<double>();
            var watch = System.Diagnostics.Stopwatch.StartNew();            
            
            for (int i = 0; i < num;++i)            
                results.Add(methods[method - 1]()*Math.Sqrt(variance) + mean);
            watch.Stop();            
            var elapsedMs = watch.ElapsedMilliseconds;
            timeLabel.Text = String.Format("Time :{0}", Convert.ToString(elapsedMs));
            double meanX = results.Average();
            double varX = results.Sum(x => x * x)/num - meanX*meanX;

            double Er = Math.Abs(mean - meanX) / (mean+1e-8);
            double Dr = Math.Abs(variance - varX) / (variance+1e-8);
            
            eLabel.Text = String.Format("Average: {0} (error = {1}%)",
                         meanX, Convert.ToInt32(Er * 100));
            
            dLabel.Text = String.Format("Variance: {0} (error = {1}%)",
                         varX, Convert.ToInt32(Dr * 100));

            List<int> buckets = Bucketize(results, Convert.ToInt32(Math.Log(num)) + 1);

            var min = results.Min();
            var max = results.Max();
            int numBuckets = (Convert.ToInt32(Math.Log(num)) + 1);
            var bucketSize = (max - min) / numBuckets;
            double k = min;

            chart1.ChartAreas[0].AxisX.LabelStyle.Angle = 0;

            double[] chis = {3.841,5.991,7.815,9.488,11.07,12.592,14.067,15.507,16.919,
                             18.307, 19.675,21.026,22.362,23.685,24.996, 26.296, 27.587,
                             28.869,30.144,31.410};
            double chi = 0;
            for (int i =0; i < buckets.Count; ++i)
            {
                double stat = buckets[i] * 1.0 / num;
                chart1.Series[0].Points.Add(stat);
                chart1.Series[1].Points.Add(stat);
                double p = normal_density((k + 1.0*bucketSize/2), mean, variance);
                chart1.ChartAreas[0].AxisX.CustomLabels.Add(i + 0.5, i + 1.5, String.Format("[{0}:{1})",Math.Round(k,2),Math.Round(k + bucketSize, 2)));
                chi += (buckets[i] * buckets[i] * 1.0) / (num * p * bucketSize);                
                k += bucketSize;                
            }            
            chi -= num;
            chi = Math.Round(chi, 3);
            chiLabel.Text = String.Format("Chi-squared: {0} > {1} is {2}",chi, chis[numBuckets-4], ((chi > chis[numBuckets-4])?"true":"false"));
        }
    }
}
