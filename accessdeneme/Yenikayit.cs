using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace accessdeneme
{
    public partial class Yenikayit : Form
    {
        public Yenikayit()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti
            = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt1.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataSet ds = new DataSet();
        

        private void button1_Click(object sender, EventArgs e)
        {
            if (tb_Tckimlik.Text != "" && tb_Ad.Text != "" && tb_Ad.Text != "" && cb_aysayisi.Text!="" )
            {
                komut.Connection = baglanti;
                komut.CommandText = 
"Insert Into Tablo1(Tc_Kimlik_No,Ad,Soyad,Telefon,Meslek,Doğum_Tarihi,Boy,Kilo,Kayıt_Süresi) values ('" 
+ tb_Tckimlik.Text + "','" + tb_Ad.Text + "','" + tb_Soyad.Text+ "','" + tb_telefon.Text + "','" 
+ tb_dogumtarihi.Text + "','" + tb_boy.Text + "','" 
+ tb_kilo.Text + "','" + cb_aysayisi.Text + "')";

                baglanti.Open();
                komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();
                MessageBox.Show("deger eklendi");
                ds.Clear();
                listele();


            }
            else
                MessageBox.Show("deger ekleyiniz");

        }

        void listele()
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from Tablo1", baglanti);
            adtr.Fill(ds, "Tablo1");
            dataGridView1.DataSource = ds.Tables["Tablo1"];
            adtr.Dispose();
            baglanti.Close();
        
        
        
        }

        private void Yenikayit_Load(object sender, EventArgs e)
        {
            listele();
            //cb_aysayisi.Items.Add("Aylık");
            //cb_aysayisi.Items.Add("3 Aylık");
            //cb_aysayisi.Items.Add("Yıllık");

            tb_ilkuyelik.Text = monthCalendar2.SelectionStart.Day.ToString() + " / " + monthCalendar2.SelectionStart.Month.ToString() + " / " + monthCalendar2.SelectionStart.Year.ToString();
     


        }

        private void Yenikayit_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Hide();
            anasayfa anasayfa = new anasayfa();
            anasayfa.Show();

        }

        private void tb_Tckimlik_TextChanged(object sender, EventArgs e)
        {
          
        }

        private void tb_Tckimlik_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {
                  }

        private void monthCalendar1_DateSelected(object sender, DateRangeEventArgs e)
        {
            tb_dogumtarihi.Text = monthCalendar1.SelectionStart.Day.ToString() + " / " + monthCalendar1.SelectionStart.Month.ToString() + " / " + monthCalendar1.SelectionStart.Year.ToString();
            monthCalendar1.Visible = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (monthCalendar1.Visible == true)
                monthCalendar1.Visible = false;
            else
                monthCalendar1.Visible = true;
        }

        private void bt_temizle_Click(object sender, EventArgs e)
        {
            tb_Ad.Clear();
            tb_boy.Clear();
            tb_dogumtarihi.Clear();
            tb_kilo.Clear();
            tb_Soyad.Clear();
            tb_Tckimlik.Clear();
            tb_telefon.Clear();
            cb_aysayisi.Text = "";
        }

        private void tb_boy_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_kilo_TextChanged(object sender, EventArgs e)
        {

        }

        private void tb_kilo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }
        }

        private void tb_telefon_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
