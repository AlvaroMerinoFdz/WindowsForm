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
    public partial class frmPrincipal : Form
    {
        frmPrecios precios = new frmPrecios();
        private int precio;
        public frmPrincipal()
        {
            InitializeComponent();
            
        }

        private void frmPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void tmrHora_Tick(object sender, EventArgs e)
        {
            lblHora.Text = DateTime.Now.ToString("hh:mm:ss");
        }

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void acuerdoEmpresaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new frmAcuerdo().ShowDialog();
        }

        private void preciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            precios.ShowDialog();
        }

        private void lstbDestino_SelectedIndexChanged(object sender, EventArgs e)
        {
            pcbImagen.Image = imgListDestino.Images[lstbDestino.SelectedIndex];
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            txtValidar.Text = "";
            tsBarraProgeso.Value = 0;
            if (lstbDestino.SelectedIndex < 0)
            {
                MessageBox.Show("Tienes que seleccionar un destino. ", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                iniciarBarraProgeso();
                mostrarPrecio();
               // lblPrecio.Text = calcularPrecio().ToString() + " €";
            }
        }

        private object calcularPrecio()
        {
            object a = null;
            return a;
        }

        private void mostrarPrecio()
        {
            txtValidar.AppendText("Destino " + lstbDestino.SelectedItem.ToString() + " tiene un precio de:  \r\n");
            txtValidar.AppendText("Hotel de  " + nupdEstrellas.Value.ToString() + " estrellas,  tiene un precio de:  \r\n");
            txtValidar.AppendText("Total de personas " + nupdPersonas.Value.ToString() + " tiene un precio de:  \r\n");
            txtValidar.AppendText("Tipo de estancia " + gpbEstancia.Text.ToString() + " tiene un precio de:  \r\n");
            txtValidar.AppendText("Total de días " + dias() + " tiene un precio de:  \r\n");
        }

        private int dias()
        {
            DateTime inicio = mntclndFechas.SelectionStart;
            DateTime final = mntclndFechas.SelectionEnd;
            var diferencia = final - inicio;
            return diferencia.Days + 1;
        }

        private void iniciarBarraProgeso()
        {
            tmrBarra.Tick += new EventHandler(incrementarBarra);
            tmrBarra.Start();
        }

        private void incrementarBarra(object sender, EventArgs e)
        {
            tsBarraProgeso.Increment(1);
            if (tsBarraProgeso.Value == tsBarraProgeso.Maximum) tsBarraProgeso.Value = 0;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            
        }
    }
}
