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
    public partial class Kayıtİslem : Form
    {
        public Kayıtİslem()
        {
            InitializeComponent();
        }
        public OleDbConnection con = new OleDbConnection("Provider=Microsoft.ACE.Oledb.12.0;Data Source=Ostim1.accdb");
        public OleDbCommand kmt = new OleDbCommand();
        public OleDbDataAdapter adtr = new OleDbDataAdapter();
        DataTable dt = new DataTable();

        public void listelesene()
        {
            try
            {
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }
                dt.Clear();
                OleDbDataAdapter listele = new OleDbDataAdapter("select * from giris", con);
                listele.Fill(dt);
                dataGridView1.DataSource = dt;
                listele.Dispose();
                dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dataGridView1.Columns[0].Visible = false;
                con.Close();
                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";
                comboBox1.Text = "";
            }
            catch (Exception hata)
            {
                MessageBox.Show(hata.Message);
            }
        }

        private void Kayıtİslem_Load_1(object sender, EventArgs e)
        {
            listelesene();
        }


        private void button4_Click(object sender, EventArgs e)
        {
            Yetkilimenu pers = new Yetkilimenu();
            pers.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == textBox6.Text)
            {
                OleDbCommand komut = new OleDbCommand("insert into giris(TcKimlikNo,Adi,Soyadi,Ceptel,Msifre,Gizli_Soru,Yanit) values('" + textBox1.Text + "','" + textBox2.Text + "','" + textBox3.Text + "','" + textBox4.Text + "','" + textBox6.Text + "','" + comboBox1.Text + "','" + textBox7.Text + "')", con);
                
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
                listelesene();
            }
            else
            {
                MessageBox.Show("Şifreler Eşleşmiyor");
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            textBox1.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            textBox2.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            textBox3.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            textBox4.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();

            textBox5.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            textBox6.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
            comboBox1.Text = dataGridView1.CurrentRow.Cells[6].Value.ToString();
            textBox7.Text = dataGridView1.CurrentRow.Cells[7].Value.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OleDbCommand guncelle = new OleDbCommand("delete from giris where TcKimlikNo='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", con);
            con.Open();
            guncelle.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Silme İşlemi Başarılı");
            textBox1.Clear();
            textBox7.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            comboBox1.Text = "Seçiniz";
            listelesene();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            OleDbCommand guncelle = new OleDbCommand("update giris set TcKimlikNo='" + textBox1.Text + "',Adi='" + textBox2.Text + "',Soyadi='" + textBox3.Text + "',Ceptel='" + textBox4.Text + "',Msifre='" + textBox5.Text + "',Gizli_Soru='" + comboBox1.Text + "',Yanit='" + textBox7.Text + "' where TcKimlikNo='" + dataGridView1.CurrentRow.Cells[1].Value.ToString() + "'", con);
            con.Open();
            guncelle.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Güncelleme İşlemi Başarılı");
            textBox1.Clear();
            textBox7.Clear();
            textBox6.Clear();
            textBox5.Clear();
            textBox4.Clear();
            textBox3.Clear();
            textBox2.Clear();
            comboBox1.Text = "Seçiniz";
            listelesene();
        }

        

      
    }
}
