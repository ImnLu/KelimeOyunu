namespace KelimeOyunu
{
    partial class KelimeOyunu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(KelimeOyunu));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBoxSoru = new System.Windows.Forms.TextBox();
            this.textBoxCevap = new System.Windows.Forms.TextBox();
            this.labelCevap = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.labelSure = new System.Windows.Forms.Label();
            this.labelSoru = new System.Windows.Forms.Label();
            this.labelPuan = new System.Windows.Forms.Label();
            this.buttonOyunuBaslat = new System.Windows.Forms.Button();
            this.timerSure = new System.Windows.Forms.Timer(this.components);
            this.timerSureyiDurdur = new System.Windows.Forms.Timer(this.components);
            this.buttonHarfAl = new System.Windows.Forms.Button();
            this.buttonSureyiDurdur = new System.Windows.Forms.Button();
            this.pictureBox0 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox9 = new System.Windows.Forms.PictureBox();
            this.label0 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.Transparent;
            this.groupBox1.Controls.Add(this.textBoxSoru);
            this.groupBox1.Font = new System.Drawing.Font("Outfit", 20F);
            this.groupBox1.Location = new System.Drawing.Point(12, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(537, 237);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Soru";
            // 
            // textBoxSoru
            // 
            this.textBoxSoru.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBoxSoru.Location = new System.Drawing.Point(6, 36);
            this.textBoxSoru.Multiline = true;
            this.textBoxSoru.Name = "textBoxSoru";
            this.textBoxSoru.ReadOnly = true;
            this.textBoxSoru.Size = new System.Drawing.Size(525, 195);
            this.textBoxSoru.TabIndex = 0;
            this.textBoxSoru.TabStop = false;
            // 
            // textBoxCevap
            // 
            this.textBoxCevap.Font = new System.Drawing.Font("Outfit", 20F);
            this.textBoxCevap.Location = new System.Drawing.Point(194, 312);
            this.textBoxCevap.Name = "textBoxCevap";
            this.textBoxCevap.ReadOnly = true;
            this.textBoxCevap.Size = new System.Drawing.Size(341, 41);
            this.textBoxCevap.TabIndex = 11;
            this.textBoxCevap.TextChanged += new System.EventHandler(this.textBoxCevap_TextChanged);
            // 
            // labelCevap
            // 
            this.labelCevap.AutoSize = true;
            this.labelCevap.Font = new System.Drawing.Font("Outfit", 20F);
            this.labelCevap.Location = new System.Drawing.Point(3, 312);
            this.labelCevap.Name = "labelCevap";
            this.labelCevap.Size = new System.Drawing.Size(185, 34);
            this.labelCevap.TabIndex = 12;
            this.labelCevap.Text = "Cevabı giriniz:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.labelSure);
            this.groupBox2.Controls.Add(this.labelSoru);
            this.groupBox2.Controls.Add(this.labelPuan);
            this.groupBox2.Font = new System.Drawing.Font("Outfit", 40F);
            this.groupBox2.Location = new System.Drawing.Point(555, -10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 248);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Durum";
            // 
            // labelSure
            // 
            this.labelSure.AutoSize = true;
            this.labelSure.BackColor = System.Drawing.Color.Transparent;
            this.labelSure.Font = new System.Drawing.Font("Outfit", 27F);
            this.labelSure.Location = new System.Drawing.Point(6, 195);
            this.labelSure.Name = "labelSure";
            this.labelSure.Size = new System.Drawing.Size(187, 45);
            this.labelSure.TabIndex = 14;
            this.labelSure.Text = "Süre: 3:00";
            // 
            // labelSoru
            // 
            this.labelSoru.AutoSize = true;
            this.labelSoru.Font = new System.Drawing.Font("Outfit", 27F);
            this.labelSoru.Location = new System.Drawing.Point(6, 105);
            this.labelSoru.Name = "labelSoru";
            this.labelSoru.Size = new System.Drawing.Size(135, 45);
            this.labelSoru.TabIndex = 1;
            this.labelSoru.Text = "Soru: 0";
            // 
            // labelPuan
            // 
            this.labelPuan.AutoSize = true;
            this.labelPuan.BackColor = System.Drawing.Color.Transparent;
            this.labelPuan.Font = new System.Drawing.Font("Outfit", 27F);
            this.labelPuan.Location = new System.Drawing.Point(6, 150);
            this.labelPuan.Name = "labelPuan";
            this.labelPuan.Size = new System.Drawing.Size(143, 45);
            this.labelPuan.TabIndex = 0;
            this.labelPuan.Text = "Puan: 0";
            // 
            // buttonOyunuBaslat
            // 
            this.buttonOyunuBaslat.Font = new System.Drawing.Font("Outfit", 25F);
            this.buttonOyunuBaslat.Location = new System.Drawing.Point(555, 251);
            this.buttonOyunuBaslat.Name = "buttonOyunuBaslat";
            this.buttonOyunuBaslat.Size = new System.Drawing.Size(265, 103);
            this.buttonOyunuBaslat.TabIndex = 14;
            this.buttonOyunuBaslat.Text = "Oyunu Başlat";
            this.buttonOyunuBaslat.UseVisualStyleBackColor = true;
            this.buttonOyunuBaslat.Click += new System.EventHandler(this.buttonOyunuBaslat_Click);
            // 
            // timerSure
            // 
            this.timerSure.Interval = 1000;
            this.timerSure.Tick += new System.EventHandler(this.timerSure_Tick);
            // 
            // timerSureyiDurdur
            // 
            this.timerSureyiDurdur.Interval = 1000;
            this.timerSureyiDurdur.Tick += new System.EventHandler(this.timerSureyiDurdur_Tick);
            // 
            // buttonHarfAl
            // 
            this.buttonHarfAl.Font = new System.Drawing.Font("Outfit", 20F);
            this.buttonHarfAl.Location = new System.Drawing.Point(555, 250);
            this.buttonHarfAl.Name = "buttonHarfAl";
            this.buttonHarfAl.Size = new System.Drawing.Size(130, 104);
            this.buttonHarfAl.TabIndex = 14;
            this.buttonHarfAl.Text = "Harf Al";
            this.buttonHarfAl.UseVisualStyleBackColor = true;
            this.buttonHarfAl.Visible = false;
            this.buttonHarfAl.Click += new System.EventHandler(this.buttonHarfAl_Click);
            // 
            // buttonSureyiDurdur
            // 
            this.buttonSureyiDurdur.Font = new System.Drawing.Font("Outfit", 20F);
            this.buttonSureyiDurdur.Location = new System.Drawing.Point(691, 250);
            this.buttonSureyiDurdur.Name = "buttonSureyiDurdur";
            this.buttonSureyiDurdur.Size = new System.Drawing.Size(130, 104);
            this.buttonSureyiDurdur.TabIndex = 15;
            this.buttonSureyiDurdur.Text = "Süreyi Durdur";
            this.buttonSureyiDurdur.UseVisualStyleBackColor = true;
            this.buttonSureyiDurdur.Visible = false;
            this.buttonSureyiDurdur.Click += new System.EventHandler(this.buttonSureyiDurdur_Click);
            // 
            // pictureBox0
            // 
            this.pictureBox0.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox0.Image = global::KelimeOyunu.Properties.Resources.altigen;
            this.pictureBox0.Location = new System.Drawing.Point(18, 250);
            this.pictureBox0.Name = "pictureBox0";
            this.pictureBox0.Size = new System.Drawing.Size(45, 45);
            this.pictureBox0.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox0.TabIndex = 16;
            this.pictureBox0.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.Image = global::KelimeOyunu.Properties.Resources.altigen;
            this.pictureBox1.Location = new System.Drawing.Point(69, 250);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 45);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = global::KelimeOyunu.Properties.Resources.altigen;
            this.pictureBox2.Location = new System.Drawing.Point(120, 250);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(45, 45);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 18;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox3.Image = global::KelimeOyunu.Properties.Resources.altigen;
            this.pictureBox3.Location = new System.Drawing.Point(171, 250);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(45, 45);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 19;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox4.Image = global::KelimeOyunu.Properties.Resources.altigen;
            this.pictureBox4.Location = new System.Drawing.Point(222, 250);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(45, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 20;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Visible = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox5.Image = global::KelimeOyunu.Properties.Resources.altigen;
            this.pictureBox5.Location = new System.Drawing.Point(273, 250);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 45);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 21;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Visible = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox6.Image = global::KelimeOyunu.Properties.Resources.altigen;
            this.pictureBox6.Location = new System.Drawing.Point(324, 250);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(45, 45);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 22;
            this.pictureBox6.TabStop = false;
            this.pictureBox6.Visible = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox7.Image = global::KelimeOyunu.Properties.Resources.altigen;
            this.pictureBox7.Location = new System.Drawing.Point(375, 250);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(45, 45);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 23;
            this.pictureBox7.TabStop = false;
            this.pictureBox7.Visible = false;
            // 
            // pictureBox8
            // 
            this.pictureBox8.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox8.Image = global::KelimeOyunu.Properties.Resources.altigen;
            this.pictureBox8.Location = new System.Drawing.Point(426, 250);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(45, 45);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 24;
            this.pictureBox8.TabStop = false;
            this.pictureBox8.Visible = false;
            // 
            // pictureBox9
            // 
            this.pictureBox9.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox9.Image = global::KelimeOyunu.Properties.Resources.altigen;
            this.pictureBox9.Location = new System.Drawing.Point(477, 250);
            this.pictureBox9.Name = "pictureBox9";
            this.pictureBox9.Size = new System.Drawing.Size(45, 45);
            this.pictureBox9.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox9.TabIndex = 25;
            this.pictureBox9.TabStop = false;
            this.pictureBox9.Visible = false;
            // 
            // label0
            // 
            this.label0.AutoSize = true;
            this.label0.BackColor = System.Drawing.Color.Transparent;
            this.label0.Font = new System.Drawing.Font("Outfit Black", 14F, System.Drawing.FontStyle.Bold);
            this.label0.Location = new System.Drawing.Point(29, 260);
            this.label0.Name = "label0";
            this.label0.Size = new System.Drawing.Size(0, 24);
            this.label0.TabIndex = 26;
            this.label0.Visible = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Outfit Black", 14F, System.Drawing.FontStyle.Bold);
            this.label1.Location = new System.Drawing.Point(80, 260);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 24);
            this.label1.TabIndex = 27;
            this.label1.Visible = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Outfit Black", 14F, System.Drawing.FontStyle.Bold);
            this.label2.Location = new System.Drawing.Point(131, 260);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 24);
            this.label2.TabIndex = 28;
            this.label2.Visible = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Outfit Black", 14F, System.Drawing.FontStyle.Bold);
            this.label3.Location = new System.Drawing.Point(182, 260);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(0, 24);
            this.label3.TabIndex = 29;
            this.label3.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Outfit Black", 14F, System.Drawing.FontStyle.Bold);
            this.label4.Location = new System.Drawing.Point(233, 260);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(0, 24);
            this.label4.TabIndex = 30;
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Outfit Black", 14F, System.Drawing.FontStyle.Bold);
            this.label5.Location = new System.Drawing.Point(284, 260);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(0, 24);
            this.label5.TabIndex = 31;
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Outfit Black", 14F, System.Drawing.FontStyle.Bold);
            this.label6.Location = new System.Drawing.Point(335, 260);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(0, 24);
            this.label6.TabIndex = 32;
            this.label6.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Outfit Black", 14F, System.Drawing.FontStyle.Bold);
            this.label7.Location = new System.Drawing.Point(386, 260);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(0, 24);
            this.label7.TabIndex = 33;
            this.label7.Visible = false;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Transparent;
            this.label8.Font = new System.Drawing.Font("Outfit Black", 14F, System.Drawing.FontStyle.Bold);
            this.label8.Location = new System.Drawing.Point(437, 260);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(0, 24);
            this.label8.TabIndex = 34;
            this.label8.Visible = false;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Outfit Black", 14F, System.Drawing.FontStyle.Bold);
            this.label9.Location = new System.Drawing.Point(488, 260);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(0, 24);
            this.label9.TabIndex = 35;
            this.label9.Visible = false;
            // 
            // KelimeOyunu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 366);
            this.Controls.Add(this.buttonOyunuBaslat);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label0);
            this.Controls.Add(this.pictureBox9);
            this.Controls.Add(this.pictureBox8);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox6);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.pictureBox0);
            this.Controls.Add(this.buttonSureyiDurdur);
            this.Controls.Add(this.buttonHarfAl);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.labelCevap);
            this.Controls.Add(this.textBoxCevap);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Outfit", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6);
            this.MaximizeBox = false;
            this.Name = "KelimeOyunu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kelime Oyunu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KelimeOyunu_FormClosing);
            this.Load += new System.EventHandler(this.KelimeOyunu_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox0)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox9)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox textBoxSoru;
        private System.Windows.Forms.TextBox textBoxCevap;
        private System.Windows.Forms.Label labelCevap;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label labelSoru;
        private System.Windows.Forms.Label labelPuan;
        private System.Windows.Forms.Label labelSure;
        private System.Windows.Forms.Timer timerSure;
        private System.Windows.Forms.Button buttonOyunuBaslat;
        private System.Windows.Forms.Timer timerSureyiDurdur;
        private System.Windows.Forms.Button buttonHarfAl;
        private System.Windows.Forms.Button buttonSureyiDurdur;
        private System.Windows.Forms.PictureBox pictureBox0;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox9;
        private System.Windows.Forms.Label label0;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
    }
}

