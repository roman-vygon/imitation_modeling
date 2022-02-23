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
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.numTextBox = new System.Windows.Forms.TextBox();
            this.varianceTextBox = new System.Windows.Forms.TextBox();
            this.eLabel = new System.Windows.Forms.Label();
            this.dLabel = new System.Windows.Forms.Label();
            this.chiLabel = new System.Windows.Forms.Label();
            this.meanTextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
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
            series2.ChartArea = "ChartArea1";
            series2.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Spline;
            series2.Name = "Series2";
            this.chart1.Series.Add(series1);
            this.chart1.Series.Add(series2);
            this.chart1.Size = new System.Drawing.Size(513, 380);
            this.chart1.TabIndex = 0;
            this.chart1.Text = "chart1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(63, 127);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Variance";
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
            // numTextBox
            // 
            this.numTextBox.Location = new System.Drawing.Point(166, 159);
            this.numTextBox.Name = "numTextBox";
            this.numTextBox.Size = new System.Drawing.Size(100, 20);
            this.numTextBox.TabIndex = 9;
            // 
            // varianceTextBox
            // 
            this.varianceTextBox.Location = new System.Drawing.Point(166, 133);
            this.varianceTextBox.Name = "varianceTextBox";
            this.varianceTextBox.Size = new System.Drawing.Size(100, 20);
            this.varianceTextBox.TabIndex = 10;
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
            // meanTextBox
            // 
            this.meanTextBox.Location = new System.Drawing.Point(166, 107);
            this.meanTextBox.Name = "meanTextBox";
            this.meanTextBox.Size = new System.Drawing.Size(100, 20);
            this.meanTextBox.TabIndex = 18;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(94, 101);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(66, 25);
            this.label2.TabIndex = 17;
            this.label2.Text = "Mean";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.comboBox1.Location = new System.Drawing.Point(166, 80);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(100, 21);
            this.comboBox1.TabIndex = 19;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(76, 76);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 20;
            this.label3.Text = "Method";
            // 
            // timeLabel
            // 
            this.timeLabel.AutoSize = true;
            this.timeLabel.Location = new System.Drawing.Point(12, 228);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(0, 13);
            this.timeLabel.TabIndex = 21;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 400);
            this.Controls.Add(this.timeLabel);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.meanTextBox);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.chiLabel);
            this.Controls.Add(this.dLabel);
            this.Controls.Add(this.eLabel);
            this.Controls.Add(this.varianceTextBox);
            this.Controls.Add(this.numTextBox);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
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
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox numTextBox;
        private System.Windows.Forms.TextBox varianceTextBox;
        private System.Windows.Forms.Label eLabel;
        private System.Windows.Forms.Label dLabel;
        private System.Windows.Forms.Label chiLabel;
        private System.Windows.Forms.TextBox meanTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeLabel;
    }
}

