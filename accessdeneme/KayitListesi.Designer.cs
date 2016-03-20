namespace accessdeneme
{
    partial class KayitListesi
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.bt_ara = new System.Windows.Forms.Button();
            this.bt_sil = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(422, 26);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(522, 417);
            this.dataGridView1.TabIndex = 0;
            // 
            // bt_ara
            // 
            this.bt_ara.Location = new System.Drawing.Point(230, 47);
            this.bt_ara.Name = "bt_ara";
            this.bt_ara.Size = new System.Drawing.Size(95, 35);
            this.bt_ara.TabIndex = 1;
            this.bt_ara.Text = "Kişi Ara";
            this.bt_ara.UseVisualStyleBackColor = true;
            this.bt_ara.Click += new System.EventHandler(this.bt_ara_Click);
            // 
            // bt_sil
            // 
            this.bt_sil.Location = new System.Drawing.Point(230, 118);
            this.bt_sil.Name = "bt_sil";
            this.bt_sil.Size = new System.Drawing.Size(95, 35);
            this.bt_sil.TabIndex = 2;
            this.bt_sil.Text = "Kişi Sil";
            this.bt_sil.UseVisualStyleBackColor = true;
            this.bt_sil.Click += new System.EventHandler(this.bt_sil_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Tc Kimlik No",
            "Ad",
            "Soyad",
            "Telefon",
            "Meslek",
            "Doğum Tarihi",
            "Boy",
            "Kilo",
            "Kayıt Süresi"});
            this.comboBox1.Location = new System.Drawing.Point(3, 124);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 3;
            // 
            // KayitListesi
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Inherit;
            this.ClientSize = new System.Drawing.Size(971, 473);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.bt_sil);
            this.Controls.Add(this.bt_ara);
            this.Controls.Add(this.dataGridView1);
            this.Name = "KayitListesi";
            this.Text = "KayitListesi";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.KayitListesi_FormClosing);
            this.Load += new System.EventHandler(this.KayitListesi_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button bt_ara;
        private System.Windows.Forms.Button bt_sil;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}