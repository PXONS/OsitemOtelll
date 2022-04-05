using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OSİTEM_OTEL
{
    public partial class Yetkilimenu : Form
    {
        public Yetkilimenu()
        {
            InitializeComponent();
        }

        private void Yetkilimenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Kayıtİslem gecis = new Kayıtİslem();
            gecis.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            OdaKayit gecis = new OdaKayit();
            gecis.Show();
            this.Hide();

        }

        private void button3_Click(object sender, EventArgs e)
        {
            OdaCikis gecis = new OdaCikis();
            gecis.Show();
            this.Hide();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OdaDurumları gecis = new OdaDurumları();
            gecis.Show();
            this.Hide();
        }
    }
}
