using System;
using System.Windows.Forms;

namespace Agencia_de_Viajes
{
    public partial class frmPrincipal : Form
    {
        frmPrecios precios = frmPrecios.singleton();
        DateTime inicial;
        DateTime final;
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
            lblHora.Text = DateTime.Now.ToString("HH:mm:ss");
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
            frmPrecios precios = frmPrecios.singleton();
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
                btnValidar.Enabled = true;
                iniciarBarraProgeso();
                mostrarPrecio();
                lblPrecio.Text = calcularPrecio().ToString() + " €";
            }
        }

        private int calcularPrecio()
        {
            return precios.destinos[lstbDestino.SelectedIndex] + precioEstrellas() + precioPersonas() + precioEstancia() + precioDias();
        }

        private void mostrarPrecio()
        {
            txtValidar.AppendText("Destino " + lstbDestino.SelectedItem.ToString() + " tiene un precio de: " + precios.destinos[lstbDestino.SelectedIndex] + " €\r\n");
            txtValidar.AppendText("Hotel de  " + nupdEstrellas.Value.ToString() + " estrellas,  tiene un precio de:  " + precioEstrellas() + " €\r\n");
            txtValidar.AppendText("Total de personas " + nupdPersonas.Value.ToString() + " tiene un precio de:  " + precioPersonas() + "€ \r\n");
            txtValidar.AppendText("Tipo de estancia " + mostrarEstancia() + " tiene un precio de:  " + precioEstancia() + "€ \r\n"); ;
            txtValidar.AppendText("Total de días " + dias() + " tiene un precio de: " + precioDias() + "€ \r\n");
            calcularActividades();
        }

        private string mostrarEstancia()
        {
            string estancia = "";
            if (rdbDormir.Checked)
            {
                estancia = "Solo dormir";
            }else if (rdbMedia.Checked)
            {
                estancia = "Media Pensión";
            }
            else
            {
                estancia = "Pensión Completa";
            }
            return estancia;
        }

        private void calcularActividades()
        {
            if (chlbActividades.CheckedIndices.Count >0)
            {
                for (int i = 0; i < chlbActividades.CheckedIndices.Count; i++)
                {
                    txtValidar.AppendText("Actividad " + chlbActividades.CheckedItems[i] + " tiene un precio de: " + precios.actividades[chlbActividades.CheckedIndices[i]] +"€ \r\n");

                }
            }

        }

        private int precioDias()
        {
            int precio = 0;
            for (int i = 0; i < dias(); i++)
            {
                precio += precioTemporada(inicial.AddDays(i).Month);
            }
            return precio;

        }

        private int precioTemporada(int mes)
        {
            switch (mes)
            {
                case 7:
                case 8:
                    return precios.fechas[0];
                case 1:
                case 9:
                case 10:
                case 11:
                case 12:
                    return precios.fechas[1];
                case 2:
                case 3:
                case 4:
                case 5:
                case 6:
                    return precios.fechas[2];
                default:
                    return 0;
            }
        }

        private int precioEstancia()
        {
            int precio = 0;
            if (rdbDormir.Checked)
            {
                precio = precios.estancia[0];
            }
            else if (rdbMedia.Checked)
            {
                precio = precios.estancia[1];
            }
            else
            {
                precio = precios.estancia[2];
            }
            return precio;
        }

        private int precioPersonas()
        {
            return (int)(nupdPersonas.Value * precios.persona);
        }

        private int precioEstrellas()
        {
            int precioEstrella = 0;
            switch ((int)(nupdEstrellas.Value))
            {
                case 1:
                    precioEstrella = precios.estrellas[0];
                    break;
                case 2:
                    precioEstrella = precios.estrellas[1];
                    break;
                case 3:
                    precioEstrella = precios.estrellas[2];
                    break;
                case 4:
                    precioEstrella = precios.estrellas[3];
                    break;
                case 5:
                    precioEstrella = precios.estrellas[4];
                    break;

            }
            return precioEstrella;
        }

        private int dias()
        {
            inicial = mntclndFechas.SelectionStart;
            final = mntclndFechas.SelectionEnd;
            var dif = final - inicial;
            return dif.Days + 1;
        }

        private void iniciarBarraProgeso()
        {
            tmrBarra.Tick += new EventHandler(incrementarBarra);
            tmrBarra.Start();
        }

        private void incrementarBarra(object sender, EventArgs e)
        {
            tsBarraProgeso.Increment(1);
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            tsBarraProgeso.Value = 100;
            btnValidar.Enabled = false;
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblDia.Text = DateTime.Now.ToString("dddd").ToString().ToUpper();
        }
    }
}
