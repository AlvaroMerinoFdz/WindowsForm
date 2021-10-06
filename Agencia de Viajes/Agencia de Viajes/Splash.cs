using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Agencia_de_Viajes
{
    public partial class frmSplash : Form
    {
        public frmSplash()
        {
            InitializeComponent();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Stop();
            frmPrincipal ventana = new frmPrincipal();
            ventana.Show();
            this.Hide();
        }

        private void frmSplash_Shown(object sender, EventArgs e)
        {
            timer1.Start();
        }
    }
}
