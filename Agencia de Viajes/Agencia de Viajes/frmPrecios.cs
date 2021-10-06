using System;
using System.Windows.Forms;

namespace Agencia_de_Viajes
{
    public partial class frmPrecios : Form
    {
        public int[] destinos = new int[4];
        public int[] estancia = new int[3];
        public int[] estrellas = new int[5];
        public int persona;
        public int[] actividades = new int[5];
        public int[] fechas = new int[3];
        public int num;


        public frmPrecios()
        {
            InitializeComponent();
        }

        /**
         * Al pulsar esté botón volvemos al formulario principal. 
         */
        private void tsbtnVolver_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        /**
         * Este método almacena los valores de los text box, al mostrarse el formulario precios.
         */
        private void frmPrecios_Shown(object sender, EventArgs e)
        {
            //Almacenamos los valores de los destinos
            destinos[0] = int.Parse(txtCiudad.Text);
            destinos[1] = int.Parse(txtPlaya.Text);
            destinos[2] = int.Parse(txtMontain.Text);
            destinos[3] = int.Parse(txtTour.Text);

            //Almacenamos los valores de las estancias
            estancia[0] = int.Parse(txtDormir.Text);
            estancia[1] = int.Parse(txtMedia.Text);
            estancia[2] = int.Parse(txtCompleta.Text);

            //Almacenamos los valores de las estrellas

            estrellas[0] = int.Parse(txtUnaEstrella.Text);
            estrellas[1] = int.Parse(txtDosEstrella.Text);
            estrellas[2] = int.Parse(txtTresEstrella.Text);
            estrellas[3] = int.Parse(txtCuatroEstrella.Text);
            estrellas[4] = int.Parse(txtCincoEstrella.Text);

            //Almacenamos valores iniciales del precio por persona
            persona = int.Parse(txtPersona.Text);

            //Almacenamos valores iniciales del group box de las actividades
            actividades[0] = int.Parse(txtCena.Text);
            actividades[1] = int.Parse(txtExcursion.Text);
            actividades[2] = int.Parse(txtLavanderia.Text);
            actividades[3] = int.Parse(txtNaturAventura.Text);
            actividades[4] = int.Parse(txtSpa.Text);

            //Almacenamos valores iniciales del group box de fechas
            fechas[0] = int.Parse(txtAlta.Text);
            fechas[1] = int.Parse(txtMediaTem.Text);
            fechas[2] = int.Parse(txtBaja.Text);

        }

        /*
        private void numeroValido(int numero, TextBox txt)
        {
            Boolean valido = int.TryParse(txt.Text, out num);
            if (txt.Text.Equals(String.Empty))
            {
                MessageBox.Show("Este campo no puede estar vacio", "Advertencia",
               MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Text = numero.ToString();

            }
            else if (!valido)
            {

                MessageBox.Show("Solo puedes introducir valores númericos", "Advertencia",
                MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txt.Text = numero.ToString();

            }
            else
            {

                txt.Text = num.ToString();
            }
        }*/
    }

}
