namespace CafeForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.ClientWish_Label = new System.Windows.Forms.Label();
            this.Choice_Label = new System.Windows.Forms.Label();
            this.Earned_Label = new System.Windows.Forms.Label();
            this.Balance_Label = new System.Windows.Forms.Label();
            this.Tries_Label = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.button5 = new System.Windows.Forms.Button();
            this.WinLoseimg = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinLoseimg)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button2.BackgroundImage")));
            this.button2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Location = new System.Drawing.Point(186, 12);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(150, 150);
            this.button2.TabIndex = 1;
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button_Click);
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.Black;
            this.button3.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button3.BackgroundImage")));
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button3.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button3.Location = new System.Drawing.Point(12, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(150, 150);
            this.button3.TabIndex = 2;
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(581, 240);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(350, 350);
            this.pictureBox1.TabIndex = 3;
            this.pictureBox1.TabStop = false;
            // 
            // ClientWish_Label
            // 
            this.ClientWish_Label.BackColor = System.Drawing.Color.Transparent;
            this.ClientWish_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ClientWish_Label.Location = new System.Drawing.Point(115, 203);
            this.ClientWish_Label.Name = "ClientWish_Label";
            this.ClientWish_Label.Size = new System.Drawing.Size(100, 30);
            this.ClientWish_Label.TabIndex = 4;
            this.ClientWish_Label.Text = "Client wish";
            this.ClientWish_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Choice_Label
            // 
            this.Choice_Label.BackColor = System.Drawing.Color.Transparent;
            this.Choice_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold);
            this.Choice_Label.Location = new System.Drawing.Point(355, 203);
            this.Choice_Label.Name = "Choice_Label";
            this.Choice_Label.Size = new System.Drawing.Size(100, 30);
            this.Choice_Label.TabIndex = 5;
            this.Choice_Label.Text = "Your choice";
            this.Choice_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Earned_Label
            // 
            this.Earned_Label.BackColor = System.Drawing.Color.Transparent;
            this.Earned_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Earned_Label.Location = new System.Drawing.Point(69, 388);
            this.Earned_Label.Name = "Earned_Label";
            this.Earned_Label.Size = new System.Drawing.Size(150, 40);
            this.Earned_Label.TabIndex = 6;
            this.Earned_Label.Text = "Earned";
            this.Earned_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Balance_Label
            // 
            this.Balance_Label.BackColor = System.Drawing.Color.Transparent;
            this.Balance_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Balance_Label.Location = new System.Drawing.Point(67, 490);
            this.Balance_Label.Name = "Balance_Label";
            this.Balance_Label.Size = new System.Drawing.Size(200, 50);
            this.Balance_Label.TabIndex = 7;
            this.Balance_Label.Text = "Balance:";
            this.Balance_Label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Tries_Label
            // 
            this.Tries_Label.BackColor = System.Drawing.Color.Transparent;
            this.Tries_Label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Tries_Label.Location = new System.Drawing.Point(530, 12);
            this.Tries_Label.Name = "Tries_Label";
            this.Tries_Label.Size = new System.Drawing.Size(150, 60);
            this.Tries_Label.TabIndex = 8;
            this.Tries_Label.Text = "Tries";
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.Location = new System.Drawing.Point(621, 151);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(263, 70);
            this.label6.TabIndex = 9;
            this.label6.Text = "State:";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("button1.BackgroundImage")));
            this.button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Location = new System.Drawing.Point(359, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(150, 150);
            this.button1.TabIndex = 10;
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button_Click);
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(119, 251);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(100, 100);
            this.pictureBox2.TabIndex = 12;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox3.Location = new System.Drawing.Point(359, 244);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(100, 100);
            this.pictureBox3.TabIndex = 13;
            this.pictureBox3.TabStop = false;
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.Info;
            this.button5.Enabled = false;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.button5.Location = new System.Drawing.Point(655, 28);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(229, 77);
            this.button5.TabIndex = 14;
            this.button5.Text = "New client";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // WinLoseimg
            // 
            this.WinLoseimg.BackColor = System.Drawing.Color.Transparent;
            this.WinLoseimg.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.WinLoseimg.Location = new System.Drawing.Point(581, 240);
            this.WinLoseimg.Name = "WinLoseimg";
            this.WinLoseimg.Size = new System.Drawing.Size(350, 350);
            this.WinLoseimg.TabIndex = 15;
            this.WinLoseimg.TabStop = false;
            this.WinLoseimg.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(947, 602);
            this.Controls.Add(this.WinLoseimg);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.Tries_Label);
            this.Controls.Add(this.Balance_Label);
            this.Controls.Add(this.Earned_Label);
            this.Controls.Add(this.Choice_Label);
            this.Controls.Add(this.ClientWish_Label);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CAFE";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WinLoseimg)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label ClientWish_Label;
        private System.Windows.Forms.Label Choice_Label;
        private System.Windows.Forms.Label Earned_Label;
        private System.Windows.Forms.Label Balance_Label;
        private System.Windows.Forms.Label Tries_Label;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.PictureBox WinLoseimg;
    }
}

