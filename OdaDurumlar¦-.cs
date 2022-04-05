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
    public partial class OdaDurumları : Form
    {
        public OdaDurumları()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button10_Click(object sender, EventArgs e)
        {
            Yetkilimenu pers = new Yetkilimenu();
            pers.Show();
            this.Hide();
        }
    }
}
