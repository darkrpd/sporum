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
    public partial class KayitListesi : Form
    {
        public KayitListesi()
        {
            InitializeComponent();
        }
        OleDbConnection baglanti
           = new OleDbConnection("Provider=Microsoft.ACE.OLEDB.12.0;Data Source=vt1.accdb");
        OleDbCommand komut = new OleDbCommand();
        OleDbDataAdapter adapter = new OleDbDataAdapter();
        DataSet ds = new DataSet();


        private void KayitListesi_Load(object sender, EventArgs e)
        {
            baglanti.Open();
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from Tablo1", baglanti);
            adtr.Fill(ds, "Tablo1");
            dataGridView1.DataSource = ds.Tables["Tablo1"];
            adtr.Dispose();
            baglanti.Close();

            
        }

        private void KayitListesi_FormClosing(object sender, FormClosingEventArgs e)
        {
            this.Hide();
            anasayfa a = new anasayfa();
            a.AutoScaleMode = AutoScaleMode.None;
            a.Show();
        }

        private void bt_ara_Click(object sender, EventArgs e)
        {
            baglanti.Open();
            
            OleDbDataAdapter adtr = new OleDbDataAdapter("select * from Tablo1 where ", baglanti);
            adtr.Fill(ds, "Tablo1");
            dataGridView1.DataSource = ds.Tables["Tablo1"];
            adtr.Dispose();
            baglanti.Close();
        }

        private void bt_sil_Click(object sender, EventArgs e)
        {
            //foreach (DataGridViewCell oneCell in dataGridView1.SelectedCells)
            //{
            //    if (oneCell.Selected)
            //        dataGridView1.Rows.RemoveAt(oneCell.RowIndex);
            //}

            //baglanti.Open();
            //string sorgu="delete * from Tablo1 where"
            //OleDbDataAdapter adtr = new OleDbDataAdapter("delete * from Tablo1 where", baglanti);
            //adtr.Fill(ds, "Tablo1");
            //dataGridView1.DataSource = ds.Tables["Tablo1"];
            //adtr.Dispose();
            //baglanti.Close();

            

        }
    }
}
