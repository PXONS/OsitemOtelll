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
    public partial class OdaKayit : Form
    {
        public OdaKayit()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Yetkilimenu pers = new Yetkilimenu();
            pers.Show();
            this.Hide();
        }

        private void OdaKayit_Load(object sender, EventArgs e)
        {

        }
    }
}
