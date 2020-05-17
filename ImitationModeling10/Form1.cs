using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImitationModeling10
{
    public partial class Form1 : Form
    {
        Random r = new Random(422);
        int[] dice;
        int dice_left;
        double eps = 1e-9;
        int score = 0;
        double[] probs = { 1.0/ 6, 1.0 / 6, 1.0 / 6, 1.0 / 6, 1.0 / 6, 1.0 / 6 };
        double[] cheating_probs = { 2.0 / 6, 1.0 / 12, 1.0 / 12, 1.0 / 12, 2.0 / 6, 1.0 / 12 };
        int[] temp_dice;
        bool cheating_dice;
        List<int> added_dice;
        Bitmap[] dice_images =
        {
           Properties.Resources.dice1,
           Properties.Resources.dice2,
           Properties.Resources.dice3,
           Properties.Resources.dice4,
           Properties.Resources.dice5,
           Properties.Resources.dice6
        };

        private int SimulateExperiment(double[] probs)
        {
            int k = 0;
            double A = r.NextDouble();
            while (A > eps)
                A -= probs[k++];
            return k - 1;
        }
        private void setInitialState()
        {
            dice = new int[6];
            dice_left = 6;
            cheating_dice = false;
            added_dice = new List<int>();
            dice1.Enabled = false;
            dice2.Enabled = false;
            dice3.Enabled = false;
            dice4.Enabled = false;
            dice5.Enabled = false;
            dice6.Enabled = false;
        }

        private void dice_Click(object sender, EventArgs e)
        {
            PictureBox pbox = ((PictureBox)sender);
            int dice_num = Convert.ToInt32(pbox.Tag) - 1;
            added_dice.Add(dice[dice_num]+1);
            pbox.Enabled = false;
            String s = "Выбрано: ";
            for (int i = 0; i < added_dice.Count; ++i)
            {
                s += (added_dice[i]).ToString() + ' ';
            }
            label2.Text = s;
        }
        public Form1()
        {
            InitializeComponent();
            setInitialState();

            this.dice1.Click += dice_Click;
            this.dice2.Click += dice_Click;
            this.dice3.Click += dice_Click;
            this.dice4.Click += dice_Click;
            this.dice5.Click += dice_Click;
            this.dice6.Click += dice_Click;
        }

        private void set_images()
        {
            for (int i = 0; i < dice_left; ++i)
            {
                Control pictureBox = this.Controls.Find("dice" + (i + 1).ToString(), true)[0];
                pictureBox.Enabled = true;
                pictureBox.BackgroundImage = dice_images[dice[i]];
            }
            for (int i = dice_left; i < 6; ++i)
            {
                Control pictureBox = this.Controls.Find("dice" + (i + 1).ToString(), true)[0];
                pictureBox.Enabled = false;
                pictureBox.BackgroundImage = null;
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {          

            for (int i =0; i < dice_left; ++i)
            {
                if (cheating_dice && i == 0)
                    dice[i] = SimulateExperiment(cheating_probs);
                else
                    dice[i] = SimulateExperiment(probs);                
            }
            set_images();

            int[] results = new int[6];
            for (int i =0; i < 6; ++i)
            {
                results[dice[i]]++;
            }
            temp_dice = dice;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            cheating_dice = true;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Text = "Выбрано:";
            if (added_dice.Count == 1)
            {
                if (added_dice[0] == 1)
                {
                    score += 100;
                    dice_left -= added_dice.Count;
                }
                else
                    if (added_dice[0] == 5)
                {
                    score += 50;
                    dice_left -= added_dice.Count;
                }
                else
                {
                    added_dice.Clear();
                    dice = temp_dice;
                    set_images();
                }                                                                         
            }
            if (added_dice.Count == 2)
            {
                added_dice.Clear();
                dice = temp_dice;
                set_images();
            }
            if (added_dice.Count == 3)
            {
                if (added_dice[0] == added_dice[1] && added_dice[1] == added_dice[2])
                {
                    if (added_dice[0] == 1)
                        score += 1000;
                    else                    
                        score += added_dice[0] * 100;
                    
                    dice_left -= added_dice.Count;
                }
                else
                {
                    added_dice.Clear();
                    dice = temp_dice;
                    set_images();
                }
            }
            if (added_dice.Count > 3)
            {
                bool f = false;
                for (int i =1; i < added_dice.Count; ++i)
                {
                    if (added_dice[i] != added_dice[i - 1])
                        f = true;
                }
                if (f)
                {
                    added_dice.Clear();
                    dice = temp_dice;
                    set_images();
                }
                else
                {
                    int base_score = ((added_dice[0] == 1) ? 1000 : added_dice[0] * 100);
                    base_score *= Convert.ToInt32(Math.Pow(2, added_dice.Count - 3));
                    score += base_score;
                    dice_left -= added_dice.Count;
                }
            }
            added_dice.Clear();
            label1.Text = score.ToString();               
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            linkLabel1.LinkVisited = true;
            System.Diagnostics.Process.Start("https://kingdom-come-deliverance.fandom.com/wiki/Dice");
        }
    }
}
