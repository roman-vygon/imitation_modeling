namespace ImitationModeling10
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
            this.button1 = new System.Windows.Forms.Button();
            this.dice1 = new System.Windows.Forms.PictureBox();
            this.dice2 = new System.Windows.Forms.PictureBox();
            this.dice6 = new System.Windows.Forms.PictureBox();
            this.dice5 = new System.Windows.Forms.PictureBox();
            this.dice4 = new System.Windows.Forms.PictureBox();
            this.dice3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(76, 171);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(106, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Бросить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dice1
            // 
            this.dice1.BackColor = System.Drawing.Color.Transparent;
            this.dice1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dice1.Location = new System.Drawing.Point(76, 68);
            this.dice1.Name = "dice1";
            this.dice1.Size = new System.Drawing.Size(50, 50);
            this.dice1.TabIndex = 1;
            this.dice1.TabStop = false;
            this.dice1.Tag = "1";
            // 
            // dice2
            // 
            this.dice2.BackColor = System.Drawing.Color.Transparent;
            this.dice2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dice2.Location = new System.Drawing.Point(132, 68);
            this.dice2.Name = "dice2";
            this.dice2.Size = new System.Drawing.Size(50, 50);
            this.dice2.TabIndex = 2;
            this.dice2.TabStop = false;
            this.dice2.Tag = "2";
            // 
            // dice6
            // 
            this.dice6.BackColor = System.Drawing.Color.Transparent;
            this.dice6.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dice6.Location = new System.Drawing.Point(356, 68);
            this.dice6.Name = "dice6";
            this.dice6.Size = new System.Drawing.Size(50, 50);
            this.dice6.TabIndex = 3;
            this.dice6.TabStop = false;
            this.dice6.Tag = "6";
            // 
            // dice5
            // 
            this.dice5.BackColor = System.Drawing.Color.Transparent;
            this.dice5.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dice5.Location = new System.Drawing.Point(300, 68);
            this.dice5.Name = "dice5";
            this.dice5.Size = new System.Drawing.Size(50, 50);
            this.dice5.TabIndex = 4;
            this.dice5.TabStop = false;
            this.dice5.Tag = "5";
            // 
            // dice4
            // 
            this.dice4.BackColor = System.Drawing.Color.Transparent;
            this.dice4.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dice4.Location = new System.Drawing.Point(244, 68);
            this.dice4.Name = "dice4";
            this.dice4.Size = new System.Drawing.Size(50, 50);
            this.dice4.TabIndex = 5;
            this.dice4.TabStop = false;
            this.dice4.Tag = "4";
            // 
            // dice3
            // 
            this.dice3.BackColor = System.Drawing.Color.Transparent;
            this.dice3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.dice3.Location = new System.Drawing.Point(188, 68);
            this.dice3.Name = "dice3";
            this.dice3.Size = new System.Drawing.Size(50, 50);
            this.dice3.TabIndex = 6;
            this.dice3.TabStop = false;
            this.dice3.Tag = "3";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(497, 247);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(33, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Счет:";
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(188, 171);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(106, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "Выбрать";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(300, 176);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Выбрано:";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(12, 234);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(170, 23);
            this.button3.TabIndex = 10;
            this.button3.Text = "Добавить читерский кубик";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(264, 246);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(51, 13);
            this.linkLabel1.TabIndex = 11;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Правила";
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ImitationModeling10.Properties.Resources.table;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(604, 269);
            this.Controls.Add(this.linkLabel1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dice3);
            this.Controls.Add(this.dice4);
            this.Controls.Add(this.dice5);
            this.Controls.Add(this.dice6);
            this.Controls.Add(this.dice2);
            this.Controls.Add(this.dice1);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dice1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dice3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox dice1;
        private System.Windows.Forms.PictureBox dice2;
        private System.Windows.Forms.PictureBox dice6;
        private System.Windows.Forms.PictureBox dice5;
        private System.Windows.Forms.PictureBox dice4;
        private System.Windows.Forms.PictureBox dice3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.LinkLabel linkLabel1;
    }
}

