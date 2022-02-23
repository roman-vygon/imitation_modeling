using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ImitationModeling9_10
{
    public partial class Form1 : Form
    {
        Random r = new Random(42);
        double p = 0.5;
        double[] ballProbabilities = new double[20];
        String[] ballAnswers = {"Бесспорно", "Предрешено", "Никаких сомнений",
                                "Определённо да", "Можешь быть уверен в этом", "Мне кажется - да",
                                "Вероятнее всего", "Хорошие перспективы", "Знаки говорят - да", "Да",
                                "Пока не ясно, попробуй снова", "Спроси позже", "Лучше не рассказывать",
                                "Сейчас нельзя предсказать", "Сконцентрируйся и спроси опять",
                                "Даже не думай", "Мой ответ - нет", "По моим данным - нет",
                                "Перспективы не очень хорошие", "Весьма сомнительно" };

        public Form1()
        {
            InitializeComponent();

            for (int i =0; i < 19; ++i)                            
                ballProbabilities[i] = 1.0/20;              
        }

        private void asnwerButton_Click(object sender, EventArgs e)
        {
            double alpha = r.NextDouble();
            if (alpha < p)
                answerLabel.Text = "Да";
            else
                answerLabel.Text = "Нет";
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            double A = r.NextDouble();
            int k = 0;
            while(A > 0)            
                A -= ballProbabilities[k++];
            ballAnswerLabel.Text = ballAnswers[k-1];
        }
    }
}
