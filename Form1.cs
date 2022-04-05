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

namespace OSİTEM_OTEL
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Ostim1.accdb");
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataSet dtst = new DataSet();
        public static string musteritc = null;






        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void buttongirs_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from giris where TcKimlikNo='" + textKullanici.Text + "' and Msifre ='" + textSifre.Text + "'", con);
            con.Open();


            OleDbDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                musteritc = textKullanici.Text;
                MessageBox.Show("Giriş Başarılı !");
                con.Close();
                Rezervasyon menu = new Rezervasyon();
                menu.Show();
                this.Hide();

            }
            else
            {
                con.Close();
                MessageBox.Show("Kullanıcı Adınız Yada Şifreniz Yanlış Yazılmıştır");
                textKullanici.Text = "";
                textSifre.Text = "";

            }
        }

        private void buttonygiris_Click(object sender, EventArgs e)
        {
            OleDbCommand komut = new OleDbCommand("select * from yetkili where KullaniciAdi='" + textYKullanici.Text + "' and KullaniciSifre ='" + textYSifre.Text + "'", con);

            con.Open();

            OleDbDataReader oku = komut.ExecuteReader();

            if (oku.Read())
            {
                musteritc = textYKullanici.Text;
                MessageBox.Show("Giriş Başarılı !");
                con.Close();
                Yetkilimenu menu = new Yetkilimenu();
                menu.Show();
                this.Hide();

            }
            else
            {
                con.Close();
                MessageBox.Show("Kullanıcı Adınız Yada Şifreniz Yanlış Yazılmıştır");
                textYKullanici.Text = "";
                textYSifre.Text = "";
                
            }
        }

        private void buttonkayıt_Click(object sender, EventArgs e)
        {
            KayitOl kayit = new KayitOl();
            kayit.Show();
        }
    }
}
