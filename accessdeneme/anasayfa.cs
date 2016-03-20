using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace accessdeneme
{
    public partial class anasayfa : Form
    {
        public anasayfa()
        {
            InitializeComponent();
        }

        private void bt_programdanCikis_Click(object sender, EventArgs e)
        {
        //    FormClosingEventArgs newe = (FormClosingEventArgs)e;
        //    anasayfa_FormClosing(sender, newe);   


            DialogResult dr = MessageBox.Show("Programdan Çıkmak Mı İstiyorsunuz?", "Çıkış", MessageBoxButtons.OKCancel);

            if (DialogResult.OK == dr)
                Application.ExitThread();
            else if (DialogResult.Cancel == dr)
            {
                //((FormClosingEventArgs)e).Cancel = true;
                 this.Show();


            }

            
        }

        private void bt_yeniKayit_Click(object sender, EventArgs e)
        {
            
            //this.Hide();
            //yenikayit.Show();
            
            
            this.IsMdiContainer = true;
            Yenikayit yenikayit = new Yenikayit();
            yenikayit.MdiParent = this;
            yenikayit.Show();




        }

        private void anasayfa_FormClosing(object sender, FormClosingEventArgs e)
        {   
            DialogResult dr = MessageBox.Show("Programdan Çıkmak Mı İstiyorsunuz?", "Çıkış", MessageBoxButtons.OKCancel);

            if (DialogResult.OK == dr)
                Application.ExitThread();
            else if (DialogResult.Cancel == dr)
            {

                e.Cancel = true;


            }
            
        }

        private void anasayfa_Load(object sender, EventArgs e)
        {
            
        }

        private void bt_kayıtListesi_Click(object sender, EventArgs e)
        {

            this.Hide();
            KayitListesi kl = new KayitListesi();
            kl.Show();

        }

        private void bt_programHakkinda_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program Ali Aşkın Tarafından Yazılmıştır.\n Yazılım projeleriniz için iletişim: aliaskin@outlook.com");

        }

        private void tp_kayitEkle_Click(object sender, EventArgs e)
        {
            bt_yeniKayit_Click(sender,e);
            
        }

        private void tp_hakkinda_Click(object sender, EventArgs e)
        {
            bt_programHakkinda_Click(sender, e);
        }

        private void tp_cikis_Click(object sender, EventArgs e)
        {
            bt_programdanCikis_Click(sender, e);
        }

        private void bt_programHakkinda_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("Bu Program Ali Aşkın Tarafından Yazılmıştır.\n Yazılım projeleriniz için iletişim: aliaskin@outlook.com");

        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void bt_programdanCikis_Click_1(object sender, EventArgs e)
        {
            bt_programdanCikis_Click(sender, e);
        }

       


        
    }
}
