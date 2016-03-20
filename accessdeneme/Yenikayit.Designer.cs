namespace accessdeneme
{
    partial class Yenikayit
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
            this.tb_Tckimlik = new System.Windows.Forms.TextBox();
            this.tb_Ad = new System.Windows.Forms.TextBox();
            this.tb_Soyad = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.tb_kilo = new System.Windows.Forms.TextBox();
            this.tb_boy = new System.Windows.Forms.TextBox();
            this.tb_dogumtarihi = new System.Windows.Forms.TextBox();
            this.cb_aysayisi = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.button2 = new System.Windows.Forms.Button();
            this.monthCalendar2 = new System.Windows.Forms.MonthCalendar();
            this.tb_ilkuyelik = new System.Windows.Forms.TextBox();
            this.bt_temizle = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_telefon = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // tb_Tckimlik
            // 
            this.tb_Tckimlik.Location = new System.Drawing.Point(177, 36);
            this.tb_Tckimlik.MaxLength = 11;
            this.tb_Tckimlik.Name = "tb_Tckimlik";
            this.tb_Tckimlik.Size = new System.Drawing.Size(175, 22);
            this.tb_Tckimlik.TabIndex = 0;
            this.tb_Tckimlik.TextChanged += new System.EventHandler(this.tb_Tckimlik_TextChanged);
            this.tb_Tckimlik.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_Tckimlik_KeyPress);
            // 
            // tb_Ad
            // 
            this.tb_Ad.Location = new System.Drawing.Point(177, 74);
            this.tb_Ad.Name = "tb_Ad";
            this.tb_Ad.Size = new System.Drawing.Size(175, 22);
            this.tb_Ad.TabIndex = 1;
            // 
            // tb_Soyad
            // 
            this.tb_Soyad.Location = new System.Drawing.Point(177, 112);
            this.tb_Soyad.Name = "tb_Soyad";
            this.tb_Soyad.Size = new System.Drawing.Size(175, 22);
            this.tb_Soyad.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(176, 396);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 60);
            this.button1.TabIndex = 3;
            this.button1.Text = "Kişi Ekle";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(793, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(576, 543);
            this.dataGridView1.TabIndex = 4;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(38, 517);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(276, 173);
            this.textBox4.TabIndex = 5;
            this.textBox4.Text = "Spor Salonu Logosu";
            // 
            // tb_kilo
            // 
            this.tb_kilo.Location = new System.Drawing.Point(177, 302);
            this.tb_kilo.Name = "tb_kilo";
            this.tb_kilo.Size = new System.Drawing.Size(100, 22);
            this.tb_kilo.TabIndex = 10;
            this.tb_kilo.TextChanged += new System.EventHandler(this.tb_kilo_TextChanged);
            this.tb_kilo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_kilo_KeyPress);
            // 
            // tb_boy
            // 
            this.tb_boy.Location = new System.Drawing.Point(177, 264);
            this.tb_boy.Name = "tb_boy";
            this.tb_boy.Size = new System.Drawing.Size(100, 22);
            this.tb_boy.TabIndex = 9;
            this.tb_boy.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_boy_KeyPress);
            // 
            // tb_dogumtarihi
            // 
            this.tb_dogumtarihi.Location = new System.Drawing.Point(177, 188);
            this.tb_dogumtarihi.Name = "tb_dogumtarihi";
            this.tb_dogumtarihi.Size = new System.Drawing.Size(137, 22);
            this.tb_dogumtarihi.TabIndex = 8;
            // 
            // cb_aysayisi
            // 
            this.cb_aysayisi.FormattingEnabled = true;
            this.cb_aysayisi.Items.AddRange(new object[] {
            "Günlük",
            "Haftalık",
            "Aylık",
            "Altı Aylık",
            "Yıllık"});
            this.cb_aysayisi.Location = new System.Drawing.Point(177, 340);
            this.cb_aysayisi.Name = "cb_aysayisi";
            this.cb_aysayisi.Size = new System.Drawing.Size(100, 24);
            this.cb_aysayisi.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(38, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 12;
            this.label1.Text = "Tc Kimlik No : ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(38, 77);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 13;
            this.label2.Text = "Ad :";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(38, 229);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 15;
            this.label3.Text = "İlk Üyelik Tarihi :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(38, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 14;
            this.label4.Text = "Soyad :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(38, 305);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 17;
            this.label5.Text = "Kilo :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(38, 267);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 16;
            this.label6.Text = "Boy :";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(38, 343);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 18;
            this.label7.Text = "Alınan Paket :";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(38, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 19;
            this.label8.Text = "Doğum Tarihi :";
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(364, 188);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 20;
            this.monthCalendar1.Visible = false;
            this.monthCalendar1.DateChanged += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateChanged);
            this.monthCalendar1.DateSelected += new System.Windows.Forms.DateRangeEventHandler(this.monthCalendar1_DateSelected);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(320, 188);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 22);
            this.button2.TabIndex = 21;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // monthCalendar2
            // 
            this.monthCalendar2.Location = new System.Drawing.Point(1135, 526);
            this.monthCalendar2.Name = "monthCalendar2";
            this.monthCalendar2.TabIndex = 22;
            this.monthCalendar2.Visible = false;
            // 
            // tb_ilkuyelik
            // 
            this.tb_ilkuyelik.Enabled = false;
            this.tb_ilkuyelik.Location = new System.Drawing.Point(177, 226);
            this.tb_ilkuyelik.Name = "tb_ilkuyelik";
            this.tb_ilkuyelik.Size = new System.Drawing.Size(100, 22);
            this.tb_ilkuyelik.TabIndex = 23;
            // 
            // bt_temizle
            // 
            this.bt_temizle.Location = new System.Drawing.Point(33, 396);
            this.bt_temizle.Name = "bt_temizle";
            this.bt_temizle.Size = new System.Drawing.Size(100, 60);
            this.bt_temizle.TabIndex = 24;
            this.bt_temizle.Text = "Temizle";
            this.bt_temizle.UseVisualStyleBackColor = true;
            this.bt_temizle.Click += new System.EventHandler(this.bt_temizle_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(38, 153);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 26;
            this.label9.Text = "Telefon No : ";
            // 
            // tb_telefon
            // 
            this.tb_telefon.Location = new System.Drawing.Point(177, 150);
            this.tb_telefon.MaxLength = 11;
            this.tb_telefon.Name = "tb_telefon";
            this.tb_telefon.Size = new System.Drawing.Size(175, 22);
            this.tb_telefon.TabIndex = 25;
            this.tb_telefon.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_telefon_KeyPress);
            // 
            // Yenikayit
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(1381, 712);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.tb_telefon);
            this.Controls.Add(this.bt_temizle);
            this.Controls.Add(this.tb_ilkuyelik);
            this.Controls.Add(this.monthCalendar2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.monthCalendar1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cb_aysayisi);
            this.Controls.Add(this.tb_kilo);
            this.Controls.Add(this.tb_boy);
            this.Controls.Add(this.tb_dogumtarihi);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tb_Soyad);
            this.Controls.Add(this.tb_Ad);
            this.Controls.Add(this.tb_Tckimlik);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Yenikayit";
            this.Text = "[ İsim Gelecek ] Spor Salonu Uygulaması";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Yenikayit_FormClosed);
            this.Load += new System.EventHandler(this.Yenikayit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tb_Tckimlik;
        private System.Windows.Forms.TextBox tb_Ad;
        private System.Windows.Forms.TextBox tb_Soyad;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox tb_kilo;
        private System.Windows.Forms.TextBox tb_boy;
        private System.Windows.Forms.TextBox tb_dogumtarihi;
        private System.Windows.Forms.ComboBox cb_aysayisi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MonthCalendar monthCalendar2;
        private System.Windows.Forms.TextBox tb_ilkuyelik;
        private System.Windows.Forms.Button bt_temizle;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_telefon;
    }
}

