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
    public partial class Rezervasyon : Form
    {
        public Rezervasyon()
        {
            InitializeComponent();
        }
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Ostim1.accdb");
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataSet dtst = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            OleDbCommand guncelle = new OleDbCommand("update giris set TcKimlikNo='" + textBoxtc.Text + "',Adi='" + textBoxad.Text + "',Soyadi='" + textBoxsoyad.Text + "',CepTel='" + textBoxceptel.Text + "',Msifre='" + textBoxsifre.Text + "',Gizli_Soru='" + comboBox1.Text + "',Yanit='" + textBoxyanit.Text + "' where TcKimlikNo='" + Form1.musteritc + "'", con);
            con.Open();
            guncelle.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
        }

        private void CikisButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
