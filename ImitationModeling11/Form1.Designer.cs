namespace ImitationModeling9
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.prob5TextBox = new System.Windows.Forms.TextBox();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.prob1TextBox = new System.Windows.Forms.TextBox();
            this.prob2TextBox = new System.Windows.Forms.TextBox();
            this.prob3TextBox = new System.Windows.Forms.TextBox();
            this.prob4TextBox = new System.Windows.Forms.TextBox();
            this.eLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.chiLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            this.SuspendLayout();
            // 
            // chart1
            // 
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            this.chart1.Location = new System.Drawing.Point(275, 12);
            this.chart1.Name = "chart1";
            series1.ChartArea = "ChartArea1";
            series1.Name = "Series1";
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(513, 380);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Вероятность 1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Вероятность 2";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 72);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Вероятность 3";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 102);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(81, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Вероятность 4";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 132);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(81, 13);
            this.label5.TabIndex = 5;
            this.label5.Text = "Вероятность 5";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 162);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(148, 13);
            this.label6.TabIndex = 6;
            this.label6.Text = "Количество экспериментов";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 369);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(145, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Выполнить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // prob5TextBox
            // 
            this.prob5TextBox.Enabled = false;
            this.prob5TextBox.Location = new System.Drawing.Point(99, 129);
            this.prob5TextBox.Name = "prob5TextBox";
            this.prob5TextBox.Size = new System.Drawing.Size(100, 20);
            this.prob5TextBox.TabIndex = 8;
            // 
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(166, 159);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(100, 20);
            this.numTextBox.TabIndex = 9;
            // 
            // prob1TextBox
            // 
            this.prob1TextBox.Location = new System.Drawing.Point(99, 9);
            this.prob1TextBox.Name = "prob1TextBox";
            this.prob1TextBox.Size = new System.Drawing.Size(100, 20);
            this.prob1TextBox.TabIndex = 10;
            this.prob1TextBox.TextChanged += new System.EventHandler(this.prob1TextBox_TextChanged);
            // 
            // prob2TextBox
            // 
            this.prob2TextBox.Location = new System.Drawing.Point(99, 39);
            this.prob2TextBox.Name = "prob2TextBox";
            this.prob2TextBox.Size = new System.Drawing.Size(100, 20);
            this.prob2TextBox.TabIndex = 11;
            this.prob2TextBox.TextChanged += new System.EventHandler(this.prob2TextBox_TextChanged);
            // 
            // prob3TextBox
            // 
            this.prob3TextBox.Location = new System.Drawing.Point(99, 69);
            this.prob3TextBox.Name = "prob3TextBox";
            this.prob3TextBox.Size = new System.Drawing.Size(100, 20);
            this.prob3TextBox.TabIndex = 12;
            this.prob3TextBox.TextChanged += new System.EventHandler(this.prob3TextBox_TextChanged);
            // 
            // prob4TextBox
            // 
            this.prob4TextBox.Location = new System.Drawing.Point(99, 99);
            this.prob4TextBox.Name = "prob4TextBox";
            this.prob4TextBox.Size = new System.Drawing.Size(100, 20);
            this.prob4TextBox.TabIndex = 13;
            this.prob4TextBox.TextChanged += new System.EventHandler(this.prob4TextBox_TextChanged);
            // 
            // eLabel
            // 
            this.eLabel.AutoSize = true;
            this.eLabel.Location = new System.Drawing.Point(93, 245);
            this.eLabel.Name = "eLabel";
            this.eLabel.Size = new System.Drawing.Size(0, 13);
            this.eLabel.TabIndex = 14;
            // 
            // dLabel
            // 
            this.dLabel.AutoSize = true;
            this.dLabel.Location = new System.Drawing.Point(93, 271);
            this.dLabel.Name = "dLabel";
            this.dLabel.Size = new System.Drawing.Size(0, 13);
            this.dLabel.TabIndex = 15;
            // 
            // chiLabel
            // 
            this.chiLabel.AutoSize = true;
            this.chiLabel.Location = new System.Drawing.Point(96, 288);
            this.chiLabel.Name = "chiLabel";
            this.chiLabel.Size = new System.Drawing.Size(0, 13);
            this.chiLabel.TabIndex = 16;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.chiLabel);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.prob4TextBox);
            this.Controls.Add(this.prob3TextBox);
            this.Controls.Add(this.prob2TextBox);
            this.Controls.Add(this.prob1TextBox);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.prob5TextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chart1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox prob5TextBox;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox prob1TextBox;
        private System.Windows.Forms.TextBox prob2TextBox;
        private System.Windows.Forms.TextBox prob3TextBox;
        private System.Windows.Forms.TextBox prob4TextBox;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label chiLabel;
    }
}

