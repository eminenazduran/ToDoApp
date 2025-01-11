using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gorev_Yonetim_Sistemi
{
    public partial class SistemGiris : Form
    {
        public SistemGiris()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            GorevYonetim gorev = new GorevYonetim();
            gorev.Show();
            this.Hide();
        }
    }
}
