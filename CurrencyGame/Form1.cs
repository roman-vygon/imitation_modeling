using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace currencyExchange
{
    public partial class Form1 : Form
    {
        Random rand = new Random();        
        private double money_amount = 10000.0;
        private string current = "RUB";

        private double eurToRub = 70.0;
        private double usdToRub = 60.0;        

        private int time = 0;
        const double k = 0.02;

        double muEurToRub = 0.1;
        double muUsdToRub = 0.1;

        double sigmaEurToRub = 0.5;
        double sigmaUsdToRub = 0.5;

        double wEurToRub = 0.0;
        double wUsdToRub = 0.0;

        public Form1()
        {            
            InitializeComponent();
        }

        private void startButton_Click(object sender, EventArgs e)
        {
            updateCurrencyLabels();
            currencyChart.Series[0].Name = "EUR";
            currencyChart.ChartAreas[0].AxisY.IsStartedFromZero = false;
            currencyChart.ChartAreas[0].AxisX.Minimum = 0;
            currencyChart.Series[0].IsValueShownAsLabel = true;
            currencyChart.Series[0].Color = Color.Gold;

            currencyChart.Series[1].Name = "USD";            
            currencyChart.Series[1].IsValueShownAsLabel = true;
            currencyChart.Series[1].Color = Color.DarkOliveGreen;

            if (!gameTimer.Enabled)
            {
                currencyChart.Series[0].Points.AddXY(time, eurToRub);
                currencyChart.Series[1].Points.AddXY(time, usdToRub);
                gameTimer.Start();
                startButton.Text = "Pause";
            }
            else
            {
                gameTimer.Stop();
                startButton.Text = "Start";
            }
        }        

        double get_next_brownian(double x, double mu, double sigma, double w)
        {
            return x*Math.Exp((mu - (sigma * sigma) / 2) * (1) + sigma * w);
        }
        private double normal_third_method()
        {
            double alpha1 = rand.NextDouble();
            double alpha2 = rand.NextDouble();
            return Math.Sqrt(-2 * Math.Log(alpha1)) * Math.Cos(2 * Math.PI * alpha2);
        }
        double get_next_wiener(double w)
        {
            return w + normal_third_method();
        }
        private void gameTimer_Tick(object sender, EventArgs e)
        {
            updateCurrencyLabels();

            time++;

            double x = rand.NextDouble();


            wEurToRub = get_next_wiener(wEurToRub);
            wUsdToRub = get_next_wiener(wUsdToRub);

            eurToRub = get_next_brownian(eurToRub, muEurToRub, sigmaEurToRub, wEurToRub);

            usdToRub = get_next_brownian(usdToRub, muUsdToRub, sigmaUsdToRub, wUsdToRub);



            

            currencyChart.Series[0].Points.AddXY(time, eurToRub);
            currencyChart.Series[1].Points.AddXY(time, usdToRub);
        }

        private void clearButton_Click(object sender, EventArgs e)
        {            
            currencyChart.Series[0].Points.Clear();
            currencyChart.Series[1].Points.Clear();            
            currencyChart.ChartAreas[0].AxisX.Minimum = 0;
        }

        private void updateCurrencyLabels()
        {
            moneyLabel.Text = Math.Round(money_amount,2).ToString() + " " + current;            
        }

        private void eurButton_Click(object sender, EventArgs e)
        {
            eurButton.Enabled = false;
            rubButton.Enabled = true;
            usdButton.Enabled = true;

            if (current == "RUB")            
                money_amount /= eurToRub;
            if (current == "USD")
                money_amount /= (eurToRub / usdToRub);

            current = "EUR";
        }

        private void usdButton_Click(object sender, EventArgs e)
        {
            eurButton.Enabled = true;
            rubButton.Enabled = true;
            usdButton.Enabled = false;

            if (current == "RUB")
                money_amount /= usdToRub;
            if (current == "EUR")
                money_amount *= (eurToRub / usdToRub);

            current = "USD";
        }

        private void rubButton_Click(object sender, EventArgs e)
        {
            eurButton.Enabled = true;
            rubButton.Enabled = false;
            usdButton.Enabled = true;

            if (current == "EUR")
                money_amount *= eurToRub;
            if (current == "USD")
                money_amount *= usdToRub;

            current = "RUB";
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }
    }
}
