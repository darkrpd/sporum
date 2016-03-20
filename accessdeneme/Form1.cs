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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti
           //  Source=
            = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt1.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataSet ds = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text != "" && textBox2.Text != "" && textBox2.Text != "") ///////// editlenecek
            {
                int tcsorgula;
                komut.Connection = baglanti;
                komut.CommandText = "select * from Tablo1 where Tc_Kimlik_No=" + textBox1.Text.ToString();

                baglanti.Open();
               // tcsorgula = komut.ExecuteNonQuery();
                komut.Dispose();
                baglanti.Close();

                if (true)
                {

                    komut.CommandText =
                        "Insert Into Tablo1(Tc Kimlik No,Ad,Soyad,Telefon Numarası,Meslek,Doğum Tarihi,Boy,Kilo) values ('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox5.Text + "','" + textBox6.Text + "','" + textBox7.Text + "','" + textBox8.Text + "')";

                    baglanti.Open();
                    komut.ExecuteNonQuery();
                    komut.Dispose();
                    baglanti.Close();
                    MessageBox.Show("kisi eklendi");
                    ds.Clear();
                    listele();


                }

                else
                {
                    MessageBox.Show("sistemde kayit var!!!");
                
                
                }

                

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

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
