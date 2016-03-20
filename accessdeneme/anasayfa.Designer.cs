namespace accessdeneme
{
    partial class anasayfa
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
            this.bt_yeniKayit = new System.Windows.Forms.Button();
            this.bt_kayıtListesi = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tp_kayitEkle = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.monthCalendar1 = new System.Windows.Forms.MonthCalendar();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_telefon = new System.Windows.Forms.TextBox();
            this.tb_Tckimlik = new System.Windows.Forms.TextBox();
            this.bt_temizle = new System.Windows.Forms.Button();
            this.tb_Ad = new System.Windows.Forms.TextBox();
            this.tb_ilkuyelik = new System.Windows.Forms.TextBox();
            this.tb_Soyad = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_dogumtarihi = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_boy = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.tb_kilo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cb_aysayisi = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.tp_kayitListesi = new System.Windows.Forms.TabPage();
            this.bt_programHakkinda = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.tp_hakkinda = new System.Windows.Forms.TabPage();
            this.tp_cikis = new System.Windows.Forms.TabPage();
            this.bt_programdanCikis = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tp_kayitEkle.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tp_kayitListesi.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // bt_yeniKayit
            // 
            this.bt_yeniKayit.Location = new System.Drawing.Point(12, 12);
            this.bt_yeniKayit.Name = "bt_yeniKayit";
            this.bt_yeniKayit.Size = new System.Drawing.Size(192, 50);
            this.bt_yeniKayit.TabIndex = 0;
            this.bt_yeniKayit.Text = "Yeni Kayıt Ekle";
            this.bt_yeniKayit.UseVisualStyleBackColor = true;
            this.bt_yeniKayit.Click += new System.EventHandler(this.bt_yeniKayit_Click);
            // 
            // bt_kayıtListesi
            // 
            this.bt_kayıtListesi.Location = new System.Drawing.Point(230, 12);
            this.bt_kayıtListesi.Name = "bt_kayıtListesi";
            this.bt_kayıtListesi.Size = new System.Drawing.Size(206, 50);
            this.bt_kayıtListesi.TabIndex = 1;
            this.bt_kayıtListesi.Text = "Kayıt Listesi";
            this.bt_kayıtListesi.UseVisualStyleBackColor = true;
            this.bt_kayıtListesi.Click += new System.EventHandler(this.bt_kayıtListesi_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tp_kayitEkle);
            this.tabControl1.Controls.Add(this.tp_kayitListesi);
            this.tabControl1.Controls.Add(this.tp_hakkinda);
            this.tabControl1.Controls.Add(this.tp_cikis);
            this.tabControl1.Location = new System.Drawing.Point(12, 122);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.Padding = new System.Drawing.Point(60, 15);
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1438, 710);
            this.tabControl1.TabIndex = 4;
            this.tabControl1.Click += new System.EventHandler(this.tabControl1_Click);
            // 
            // tp_kayitEkle
            // 
            this.tp_kayitEkle.Controls.Add(this.dataGridView1);
            this.tp_kayitEkle.Controls.Add(this.monthCalendar1);
            this.tp_kayitEkle.Controls.Add(this.textBox4);
            this.tp_kayitEkle.Controls.Add(this.label9);
            this.tp_kayitEkle.Controls.Add(this.label1);
            this.tp_kayitEkle.Controls.Add(this.tb_telefon);
            this.tp_kayitEkle.Controls.Add(this.tb_Tckimlik);
            this.tp_kayitEkle.Controls.Add(this.bt_temizle);
            this.tp_kayitEkle.Controls.Add(this.tb_Ad);
            this.tp_kayitEkle.Controls.Add(this.tb_ilkuyelik);
            this.tp_kayitEkle.Controls.Add(this.tb_Soyad);
            this.tp_kayitEkle.Controls.Add(this.button2);
            this.tp_kayitEkle.Controls.Add(this.button1);
            this.tp_kayitEkle.Controls.Add(this.label8);
            this.tp_kayitEkle.Controls.Add(this.tb_dogumtarihi);
            this.tp_kayitEkle.Controls.Add(this.label7);
            this.tp_kayitEkle.Controls.Add(this.tb_boy);
            this.tp_kayitEkle.Controls.Add(this.label5);
            this.tp_kayitEkle.Controls.Add(this.tb_kilo);
            this.tp_kayitEkle.Controls.Add(this.label6);
            this.tp_kayitEkle.Controls.Add(this.cb_aysayisi);
            this.tp_kayitEkle.Controls.Add(this.label3);
            this.tp_kayitEkle.Controls.Add(this.label2);
            this.tp_kayitEkle.Controls.Add(this.label4);
            this.tp_kayitEkle.Location = new System.Drawing.Point(4, 49);
            this.tp_kayitEkle.Name = "tp_kayitEkle";
            this.tp_kayitEkle.Padding = new System.Windows.Forms.Padding(3);
            this.tp_kayitEkle.Size = new System.Drawing.Size(1430, 657);
            this.tp_kayitEkle.TabIndex = 0;
            this.tp_kayitEkle.Text = "Yeni Kayıt Ekle";
            this.tp_kayitEkle.UseVisualStyleBackColor = true;
            this.tp_kayitEkle.Click += new System.EventHandler(this.tp_kayitEkle_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(800, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(627, 568);
            this.dataGridView1.TabIndex = 50;
            // 
            // monthCalendar1
            // 
            this.monthCalendar1.Location = new System.Drawing.Point(359, 170);
            this.monthCalendar1.Name = "monthCalendar1";
            this.monthCalendar1.TabIndex = 49;
            this.monthCalendar1.Visible = false;
            // 
            // textBox4
            // 
            this.textBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox4.Location = new System.Drawing.Point(19, 468);
            this.textBox4.Multiline = true;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(276, 173);
            this.textBox4.TabIndex = 48;
            this.textBox4.Text = "Spor Salonu Logosu";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 135);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(90, 17);
            this.label9.TabIndex = 47;
            this.label9.Text = "Telefon No : ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(33, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 17);
            this.label1.TabIndex = 35;
            this.label1.Text = "Tc Kimlik No : ";
            // 
            // tb_telefon
            // 
            this.tb_telefon.Location = new System.Drawing.Point(172, 132);
            this.tb_telefon.MaxLength = 11;
            this.tb_telefon.Name = "tb_telefon";
            this.tb_telefon.Size = new System.Drawing.Size(175, 22);
            this.tb_telefon.TabIndex = 46;
            // 
            // tb_Tckimlik
            // 
            this.tb_Tckimlik.Location = new System.Drawing.Point(172, 18);
            this.tb_Tckimlik.MaxLength = 11;
            this.tb_Tckimlik.Name = "tb_Tckimlik";
            this.tb_Tckimlik.Size = new System.Drawing.Size(175, 22);
            this.tb_Tckimlik.TabIndex = 27;
            // 
            // bt_temizle
            // 
            this.bt_temizle.Location = new System.Drawing.Point(28, 378);
            this.bt_temizle.Name = "bt_temizle";
            this.bt_temizle.Size = new System.Drawing.Size(100, 60);
            this.bt_temizle.TabIndex = 45;
            this.bt_temizle.Text = "Temizle";
            this.bt_temizle.UseVisualStyleBackColor = true;
            // 
            // tb_Ad
            // 
            this.tb_Ad.Location = new System.Drawing.Point(172, 56);
            this.tb_Ad.Name = "tb_Ad";
            this.tb_Ad.Size = new System.Drawing.Size(175, 22);
            this.tb_Ad.TabIndex = 28;
            // 
            // tb_ilkuyelik
            // 
            this.tb_ilkuyelik.Enabled = false;
            this.tb_ilkuyelik.Location = new System.Drawing.Point(172, 208);
            this.tb_ilkuyelik.Name = "tb_ilkuyelik";
            this.tb_ilkuyelik.Size = new System.Drawing.Size(100, 22);
            this.tb_ilkuyelik.TabIndex = 44;
            // 
            // tb_Soyad
            // 
            this.tb_Soyad.Location = new System.Drawing.Point(172, 94);
            this.tb_Soyad.Name = "tb_Soyad";
            this.tb_Soyad.Size = new System.Drawing.Size(175, 22);
            this.tb_Soyad.TabIndex = 29;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(315, 170);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(32, 22);
            this.button2.TabIndex = 43;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(171, 378);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 60);
            this.button1.TabIndex = 30;
            this.button1.Text = "Kişi Ekle";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(33, 173);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 17);
            this.label8.TabIndex = 42;
            this.label8.Text = "Doğum Tarihi :";
            // 
            // tb_dogumtarihi
            // 
            this.tb_dogumtarihi.Location = new System.Drawing.Point(172, 170);
            this.tb_dogumtarihi.Name = "tb_dogumtarihi";
            this.tb_dogumtarihi.Size = new System.Drawing.Size(137, 22);
            this.tb_dogumtarihi.TabIndex = 31;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(33, 325);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 17);
            this.label7.TabIndex = 41;
            this.label7.Text = "Alınan Paket :";
            // 
            // tb_boy
            // 
            this.tb_boy.Location = new System.Drawing.Point(172, 246);
            this.tb_boy.Name = "tb_boy";
            this.tb_boy.Size = new System.Drawing.Size(100, 22);
            this.tb_boy.TabIndex = 32;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(33, 287);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(39, 17);
            this.label5.TabIndex = 40;
            this.label5.Text = "Kilo :";
            // 
            // tb_kilo
            // 
            this.tb_kilo.Location = new System.Drawing.Point(172, 284);
            this.tb_kilo.Name = "tb_kilo";
            this.tb_kilo.Size = new System.Drawing.Size(100, 22);
            this.tb_kilo.TabIndex = 33;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(33, 249);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(40, 17);
            this.label6.TabIndex = 39;
            this.label6.Text = "Boy :";
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
            this.cb_aysayisi.Location = new System.Drawing.Point(172, 322);
            this.cb_aysayisi.Name = "cb_aysayisi";
            this.cb_aysayisi.Size = new System.Drawing.Size(100, 24);
            this.cb_aysayisi.TabIndex = 34;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(33, 211);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(111, 17);
            this.label3.TabIndex = 38;
            this.label3.Text = "İlk Üyelik Tarihi :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(33, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(33, 17);
            this.label2.TabIndex = 36;
            this.label2.Text = "Ad :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(33, 97);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(56, 17);
            this.label4.TabIndex = 37;
            this.label4.Text = "Soyad :";
            // 
            // tp_kayitListesi
            // 
            this.tp_kayitListesi.Controls.Add(this.dataGridView2);
            this.tp_kayitListesi.Location = new System.Drawing.Point(4, 49);
            this.tp_kayitListesi.Name = "tp_kayitListesi";
            this.tp_kayitListesi.Padding = new System.Windows.Forms.Padding(3);
            this.tp_kayitListesi.Size = new System.Drawing.Size(1430, 657);
            this.tp_kayitListesi.TabIndex = 1;
            this.tp_kayitListesi.Text = "Kayıt Listesi";
            this.tp_kayitListesi.UseVisualStyleBackColor = true;
            // 
            // bt_programHakkinda
            // 
            this.bt_programHakkinda.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.bt_programHakkinda.Location = new System.Drawing.Point(451, 12);
            this.bt_programHakkinda.Name = "bt_programHakkinda";
            this.bt_programHakkinda.Size = new System.Drawing.Size(206, 50);
            this.bt_programHakkinda.TabIndex = 4;
            this.bt_programHakkinda.Text = "Program Hakkında";
            this.bt_programHakkinda.UseVisualStyleBackColor = true;
            this.bt_programHakkinda.Click += new System.EventHandler(this.bt_programHakkinda_Click_1);
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(724, 6);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 24;
            this.dataGridView2.Size = new System.Drawing.Size(680, 546);
            this.dataGridView2.TabIndex = 1;
            // 
            // tp_hakkinda
            // 
            this.tp_hakkinda.Location = new System.Drawing.Point(4, 49);
            this.tp_hakkinda.Name = "tp_hakkinda";
            this.tp_hakkinda.Padding = new System.Windows.Forms.Padding(3);
            this.tp_hakkinda.Size = new System.Drawing.Size(1430, 657);
            this.tp_hakkinda.TabIndex = 2;
            this.tp_hakkinda.Text = "Program Hakkında";
            this.tp_hakkinda.UseVisualStyleBackColor = true;
            this.tp_hakkinda.Click += new System.EventHandler(this.tp_hakkinda_Click);
            // 
            // tp_cikis
            // 
            this.tp_cikis.Location = new System.Drawing.Point(4, 49);
            this.tp_cikis.Name = "tp_cikis";
            this.tp_cikis.Padding = new System.Windows.Forms.Padding(3);
            this.tp_cikis.Size = new System.Drawing.Size(1430, 657);
            this.tp_cikis.TabIndex = 3;
            this.tp_cikis.Text = "Çıkış";
            this.tp_cikis.UseVisualStyleBackColor = true;
            this.tp_cikis.Click += new System.EventHandler(this.tp_cikis_Click);
            // 
            // bt_programdanCikis
            // 
            this.bt_programdanCikis.Location = new System.Drawing.Point(678, 12);
            this.bt_programdanCikis.Name = "bt_programdanCikis";
            this.bt_programdanCikis.Size = new System.Drawing.Size(200, 50);
            this.bt_programdanCikis.TabIndex = 5;
            this.bt_programdanCikis.Text = "Çıkış";
            this.bt_programdanCikis.UseVisualStyleBackColor = true;
            this.bt_programdanCikis.Click += new System.EventHandler(this.bt_programdanCikis_Click_1);
            // 
            // anasayfa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1438, 710);
            this.Controls.Add(this.bt_programdanCikis);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.bt_programHakkinda);
            this.Controls.Add(this.bt_kayıtListesi);
            this.Controls.Add(this.bt_yeniKayit);
            this.Name = "anasayfa";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.anasayfa_FormClosing);
            this.Load += new System.EventHandler(this.anasayfa_Load);
            this.tabControl1.ResumeLayout(false);
            this.tp_kayitEkle.ResumeLayout(false);
            this.tp_kayitEkle.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tp_kayitListesi.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button bt_yeniKayit;
        private System.Windows.Forms.Button bt_kayıtListesi;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tp_kayitEkle;
        private System.Windows.Forms.TabPage tp_kayitListesi;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_telefon;
        private System.Windows.Forms.TextBox tb_Tckimlik;
        private System.Windows.Forms.Button bt_temizle;
        private System.Windows.Forms.TextBox tb_Ad;
        private System.Windows.Forms.TextBox tb_ilkuyelik;
        private System.Windows.Forms.TextBox tb_Soyad;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_dogumtarihi;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_boy;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox tb_kilo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cb_aysayisi;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MonthCalendar monthCalendar1;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button bt_programHakkinda;
        private System.Windows.Forms.TabPage tp_hakkinda;
        private System.Windows.Forms.TabPage tp_cikis;
        private System.Windows.Forms.Button bt_programdanCikis;
    }
}