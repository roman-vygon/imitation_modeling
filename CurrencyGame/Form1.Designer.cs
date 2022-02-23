namespace currencyExchange
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
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.moneyLabel = new System.Windows.Forms.Label();
            this.currencyChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.eurButton = new System.Windows.Forms.Button();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.startButton = new System.Windows.Forms.Button();
            this.usdButton = new System.Windows.Forms.Button();
            this.rubButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.currencyChart)).BeginInit();
            this.SuspendLayout();
            // 
            // moneyLabel
            // 
            this.moneyLabel.AutoSize = true;
            this.moneyLabel.Location = new System.Drawing.Point(872, 378);
            this.moneyLabel.Name = "moneyLabel";
            this.moneyLabel.Size = new System.Drawing.Size(39, 13);
            this.moneyLabel.TabIndex = 0;
            this.moneyLabel.Text = "0 RUB";
            // 
            // currencyChart
            // 
            chartArea2.Name = "ChartArea1";
            this.currencyChart.ChartAreas.Add(chartArea2);
            legend2.Name = "Legend1";
            this.currencyChart.Legends.Add(legend2);
            this.currencyChart.Location = new System.Drawing.Point(-39, 12);
            this.currencyChart.Name = "currencyChart";
            this.currencyChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.None;
            series3.ChartArea = "ChartArea1";
            series3.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series3.Legend = "Legend1";
            series3.Name = "Series1";
            series3.YValuesPerPoint = 4;
            series4.ChartArea = "ChartArea1";
            series4.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series4.Legend = "Legend1";
            series4.Name = "Series2";
            this.currencyChart.Series.Add(series3);
            this.currencyChart.Series.Add(series4);
            this.currencyChart.Size = new System.Drawing.Size(905, 556);
            this.currencyChart.SuppressExceptions = true;
            this.currencyChart.TabIndex = 2;
            this.currencyChart.Text = "chart1";
            // 
            // eurButton
            // 
            this.eurButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.eurButton.Image = ((System.Drawing.Image)(resources.GetObject("eurButton.Image")));
            this.eurButton.Location = new System.Drawing.Point(875, 25);
            this.eurButton.Name = "eurButton";
            this.eurButton.Size = new System.Drawing.Size(90, 90);
            this.eurButton.TabIndex = 4;
            this.eurButton.UseVisualStyleBackColor = false;
            this.eurButton.Click += new System.EventHandler(this.eurButton_Click);
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 3000;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(871, 339);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(90, 24);
            this.startButton.TabIndex = 6;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // usdButton
            // 
            this.usdButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.usdButton.Image = ((System.Drawing.Image)(resources.GetObject("usdButton.Image")));
            this.usdButton.Location = new System.Drawing.Point(871, 134);
            this.usdButton.Name = "usdButton";
            this.usdButton.Size = new System.Drawing.Size(90, 90);
            this.usdButton.TabIndex = 7;
            this.usdButton.UseVisualStyleBackColor = false;
            this.usdButton.Click += new System.EventHandler(this.usdButton_Click);
            // 
            // rubButton
            // 
            this.rubButton.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.rubButton.Enabled = false;
            this.rubButton.Image = ((System.Drawing.Image)(resources.GetObject("rubButton.Image")));
            this.rubButton.Location = new System.Drawing.Point(871, 243);
            this.rubButton.Name = "rubButton";
            this.rubButton.Size = new System.Drawing.Size(90, 90);
            this.rubButton.TabIndex = 8;
            this.rubButton.UseVisualStyleBackColor = false;
            this.rubButton.Click += new System.EventHandler(this.rubButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(872, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "Обменять в EUR";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(872, 118);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 13);
            this.label4.TabIndex = 12;
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(872, 118);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "Обменять в USD";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(872, 227);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(93, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Обменять в RUB";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(973, 551);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.rubButton);
            this.Controls.Add(this.usdButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.eurButton);
            this.Controls.Add(this.currencyChart);
            this.Controls.Add(this.moneyLabel);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.currencyChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label moneyLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart currencyChart;
        private System.Windows.Forms.Button eurButton;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button usdButton;
        private System.Windows.Forms.Button rubButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

