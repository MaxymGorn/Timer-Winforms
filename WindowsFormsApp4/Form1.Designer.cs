namespace WindowsFormsApp4
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.hour = new System.Windows.Forms.TextBox();
            this.second = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.hsec = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.minut = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.h2 = new System.Windows.Forms.NumericUpDown();
            this.h1text = new System.Windows.Forms.Label();
            this.m1text = new System.Windows.Forms.Label();
            this.m2 = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.s2 = new System.Windows.Forms.NumericUpDown();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.label11 = new System.Windows.Forms.Label();
            this.MessgeText = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = global::WindowsFormsApp4.Properties.Resources.images__2_;
            this.pictureBox1.Location = new System.Drawing.Point(-1, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(263, 213);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(330, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "H:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.Blue;
            this.label2.Location = new System.Drawing.Point(491, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(25, 39);
            this.label2.TabIndex = 2;
            this.label2.Text = ":";
            // 
            // hour
            // 
            this.hour.Enabled = false;
            this.hour.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hour.ForeColor = System.Drawing.Color.Blue;
            this.hour.Location = new System.Drawing.Point(319, 63);
            this.hour.Multiline = true;
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(62, 45);
            this.hour.TabIndex = 3;
            this.hour.Text = "00";
            // 
            // second
            // 
            this.second.Enabled = false;
            this.second.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.second.ForeColor = System.Drawing.Color.Blue;
            this.second.Location = new System.Drawing.Point(524, 64);
            this.second.Multiline = true;
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(62, 45);
            this.second.TabIndex = 6;
            this.second.Text = "00";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(598, 68);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 39);
            this.label3.TabIndex = 5;
            this.label3.Text = ":";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.Yellow;
            this.label4.Location = new System.Drawing.Point(435, 20);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 48);
            this.label4.TabIndex = 4;
            this.label4.Text = "M:";
            // 
            // hsec
            // 
            this.hsec.Enabled = false;
            this.hsec.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.hsec.ForeColor = System.Drawing.Color.Blue;
            this.hsec.Location = new System.Drawing.Point(631, 64);
            this.hsec.Multiline = true;
            this.hsec.Name = "hsec";
            this.hsec.Size = new System.Drawing.Size(91, 45);
            this.hsec.TabIndex = 9;
            this.hsec.Text = "00";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.Blue;
            this.label5.Location = new System.Drawing.Point(387, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 39);
            this.label5.TabIndex = 8;
            this.label5.Text = ":";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.Yellow;
            this.label6.Location = new System.Drawing.Point(541, 20);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(45, 48);
            this.label6.TabIndex = 7;
            this.label6.Text = "S:";
            // 
            // minut
            // 
            this.minut.Enabled = false;
            this.minut.Font = new System.Drawing.Font("Mistral", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.minut.ForeColor = System.Drawing.Color.Blue;
            this.minut.Location = new System.Drawing.Point(417, 63);
            this.minut.Multiline = true;
            this.minut.Name = "minut";
            this.minut.Size = new System.Drawing.Size(62, 45);
            this.minut.TabIndex = 12;
            this.minut.Text = "00";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Mistral", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label8.ForeColor = System.Drawing.Color.Yellow;
            this.label8.Location = new System.Drawing.Point(631, 20);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(66, 48);
            this.label8.TabIndex = 10;
            this.label8.Text = "HS:";
            // 
            // h2
            // 
            this.h2.Font = new System.Drawing.Font("Mistral", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.h2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.h2.Location = new System.Drawing.Point(494, 214);
            this.h2.Name = "h2";
            this.h2.Size = new System.Drawing.Size(65, 40);
            this.h2.TabIndex = 13;
            // 
            // h1text
            // 
            this.h1text.AutoSize = true;
            this.h1text.BackColor = System.Drawing.Color.Transparent;
            this.h1text.Font = new System.Drawing.Font("Mistral", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.h1text.ForeColor = System.Drawing.Color.Yellow;
            this.h1text.Location = new System.Drawing.Point(306, 208);
            this.h1text.Name = "h1text";
            this.h1text.Size = new System.Drawing.Size(49, 46);
            this.h1text.TabIndex = 14;
            this.h1text.Text = "H:";
            // 
            // m1text
            // 
            this.m1text.AutoSize = true;
            this.m1text.BackColor = System.Drawing.Color.Transparent;
            this.m1text.Font = new System.Drawing.Font("Mistral", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m1text.ForeColor = System.Drawing.Color.Yellow;
            this.m1text.Location = new System.Drawing.Point(435, 214);
            this.m1text.Name = "m1text";
            this.m1text.Size = new System.Drawing.Size(53, 46);
            this.m1text.TabIndex = 16;
            this.m1text.Text = "M:";
            // 
            // m2
            // 
            this.m2.Font = new System.Drawing.Font("Mistral", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.m2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.m2.Location = new System.Drawing.Point(367, 214);
            this.m2.Name = "m2";
            this.m2.Size = new System.Drawing.Size(62, 40);
            this.m2.TabIndex = 15;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Transparent;
            this.label10.Font = new System.Drawing.Font("Mistral", 22.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label10.ForeColor = System.Drawing.Color.Yellow;
            this.label10.Location = new System.Drawing.Point(567, 214);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 46);
            this.label10.TabIndex = 18;
            this.label10.Text = "S:";
            // 
            // s2
            // 
            this.s2.Font = new System.Drawing.Font("Mistral", 16.2F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.s2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.s2.Location = new System.Drawing.Point(631, 214);
            this.s2.Name = "s2";
            this.s2.Size = new System.Drawing.Size(62, 40);
            this.s2.TabIndex = 17;
            // 
            // button1
            // 
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Aqua;
            this.button1.Location = new System.Drawing.Point(309, 274);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(172, 77);
            this.button1.TabIndex = 19;
            this.button1.Text = "Установить таймер";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.Aqua;
            this.button2.Location = new System.Drawing.Point(541, 274);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(173, 77);
            this.button2.TabIndex = 20;
            this.button2.Text = "Сбросить таймер";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button3
            // 
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button3.Location = new System.Drawing.Point(239, 357);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(124, 56);
            this.button3.TabIndex = 21;
            this.button3.Text = "Старт";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button4.BackgroundImage")));
            this.button4.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button4.Location = new System.Drawing.Point(439, 357);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(127, 56);
            this.button4.TabIndex = 22;
            this.button4.Text = "Стоп";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button5
            // 
            this.button5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button5.BackgroundImage")));
            this.button5.Font = new System.Drawing.Font("Ravie", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button5.Location = new System.Drawing.Point(640, 357);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(121, 56);
            this.button5.TabIndex = 23;
            this.button5.Text = "Сброс";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 2;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(22, 317);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(207, 27);
            this.progressBar1.TabIndex = 24;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Vladimir Script", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Yellow;
            this.label11.Location = new System.Drawing.Point(49, 262);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(154, 40);
            this.label11.TabIndex = 25;
            this.label11.Text = "Progresss....";
            // 
            // MessgeText
            // 
            this.MessgeText.AutoSize = true;
            this.MessgeText.BackColor = System.Drawing.Color.Transparent;
            this.MessgeText.Font = new System.Drawing.Font("Impact", 10.8F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.MessgeText.ForeColor = System.Drawing.Color.Red;
            this.MessgeText.Location = new System.Drawing.Point(255, 153);
            this.MessgeText.Name = "MessgeText";
            this.MessgeText.Size = new System.Drawing.Size(483, 23);
            this.MessgeText.TabIndex = 26;
            this.MessgeText.Text = "Остановите таймер чтобы остановить сбросить его";
            this.MessgeText.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::WindowsFormsApp4.Properties.Resources._304997;
            this.ClientSize = new System.Drawing.Size(781, 433);
            this.Controls.Add(this.MessgeText);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.progressBar1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.s2);
            this.Controls.Add(this.m1text);
            this.Controls.Add(this.m2);
            this.Controls.Add(this.h1text);
            this.Controls.Add(this.h2);
            this.Controls.Add(this.minut);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.hsec);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.second);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Timer";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.h2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.m2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.s2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox hour;
        private System.Windows.Forms.TextBox second;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox hsec;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox minut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.NumericUpDown h2;
        private System.Windows.Forms.Label h1text;
        private System.Windows.Forms.Label m1text;
        private System.Windows.Forms.NumericUpDown m2;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.NumericUpDown s2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label MessgeText;
    }
}

