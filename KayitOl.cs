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
    public partial class KayitOl : Form
    {
        public KayitOl()
        {
            InitializeComponent();
        }
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Ostim1.accdb");
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        public DataSet dtst = new DataSet();

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == textBox5.Text)
            {
               
                OleDbCommand komut = new OleDbCommand("insert into giris(TcKimlikNo,Adi,Soyadi,Ceptel,MSifre,Gizli_Soru,Yanit) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "')",con);
               
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                komut.ExecuteNonQuery();
                MessageBox.Show("Kayıt Olma İşleminiz Başarılı");
                con.Close();
                textBox1.Clear();
                textBox7.Clear();
                textBox6.Clear();
                textBox5.Clear();

                textBox4.Clear();
                textBox3.Clear();
                textBox2.Clear();
                comboBox1.Text = "Seçiniz";
            }
            else
            {
                MessageBox.Show("Şifreler Eşleşmiyor");
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
