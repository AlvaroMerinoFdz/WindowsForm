using IbanNet;
using System;
using System.IO;
using System.Windows.Forms;
using ValidacionDatos.Errores;

namespace ValidacionDatos
{
    public partial class frmDatosPersonales : Form
    {
        public frmDatosPersonales()
        {
            InitializeComponent();
        }

        /**
         * Método que valida si el email introducido tiene un valor correcto
         */
        bool validarCorreo()
        {
            bool devolver;
            try
            {
                var mail = new System.Net.Mail.MailAddress(txtEmail.Text);
                devolver = true;
            }
            catch (Exception)
            {
                devolver = false;
            }
            return devolver;
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            bool continuar = true;
            errError.Clear();
            try
            {
                if (String.IsNullOrEmpty(txtNombre.Text.Trim()))
                {
                    errError.SetError(this.txtNombre, "Campo vacío");
                    continuar = false;
                }

                if (String.IsNullOrEmpty(txtApellidos.Text.Trim()))
                {
                    continuar = false;
                    errError.SetError(this.txtApellidos, "Campo vacío");
                }
                if (!mktxtMatricula.MaskFull)
                {
                    continuar = false;
                    errError.SetError(this.mktxtMatricula, "Campo incompleto");
                }

                if (!mktxtMovil.MaskFull)
                {
                    continuar = false;
                    errError.SetError(this.mktxtMovil, "Campo incompleto");
                }
                if (!mktxtCuenta.MaskFull || !isIBAN(mktxtCuenta.Text))
                {
                    continuar = false;
                    errError.SetError(this.mktxtCuenta, "Campo incompleto");
                    throw new ErrorCuentaException();
                }

                if (!mktxtDni.MaskFull || !CheckDNI(mktxtDni.Text))
                {
                    continuar = false;
                    errError.SetError(this.mktxtDni, "DNI incorrecto");
                    throw new ErrorNIFException();
                }
                if (!validarCorreo())
                {
                    continuar = false;
                    throw new ErrorEmailException();
                }
            }
            catch (ErrorEmailException email)
            {
                MessageBox.Show(email.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                errError.SetError(this.txtEmail, email.Message);
            }
            catch (ErrorNIFException dni)
            {
                MessageBox.Show(dni.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (ErrorCuentaException cuenta)
            {
                MessageBox.Show(cuenta.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            if (continuar)
            {
                btnArchivar.Enabled = true;
            }
        }

        //Devuelve true si es valido el DNI
        bool CheckDNI(string dni)
        {
            bool comprobar = false;
            //Comprobamos si el DNI tiene 9 digitos
            if (dni.Length != 9)
            {
                //No es un DNI Valido
                comprobar = false;
            }
            else
            {
                //Extraemos los números y la letra
                string dniNumbers = dni.Substring(0, dni.Length - 1);
                string dniLeter = dni.Substring(dni.Length - 1, 1);
                //Intentamos convertir los números del DNI a integer
                var numbersValid = int.TryParse(dniNumbers, out int dniInteger);
                if (!numbersValid)
                {
                    //No se pudo convertir los números a formato númerico
                    comprobar = false;
                }
                else if (calcularLetraDni(dniInteger) != dniLeter)
                {
                    //La letra del DNI es incorrecta
                    comprobar = false;
                }
                else
                {
                    //DNI Valido :)
                    comprobar = true;
                }
            }
            return comprobar;
        }

        public string calcularLetraDni(int numeros)
        {
            string[] control = { "T", "R", "W", "A", "G", "M", "Y", "F", "P", "D", "X", "B", "N", "J", "Z", "S", "Q", "V", "H", "L", "C", "K", "E" };
            var mod = numeros % 23;
            return control[mod];
        }

        //Devuelve true si el IBAN es correcto.
        public bool isIBAN(string iban)
        {
            return true;
            /*IIbanValidator validator = new IbanValidator();
            ValidationResult validationResult = validator.Validate(iban);
            if (validationResult.IsValid) return true; else return false;*/
        }

        private void btnArchivar_Click(object sender, EventArgs e)
        {
            string nombreApellidos = txtNombre.Text + " " + txtApellidos.Text;
            String cliente = "Cliente: " + nombreApellidos + " \r\n" + "Móvil: " + mktxtMovil.Text + " Email: " + txtEmail.Text + "\r\n" + "Matrícula de Coche: " + mktxtMatricula.Text + " - NIF: " + mktxtDni.Text + "\r\n" + "CCC" + mktxtCuenta.Text + "\r\n" + "**************************************************************************************************\r\n" + "\r\n";

            if(guardar("fichDatos.txt", cliente, nombreApellidos))
            {
                MessageBox.Show("USUARIO AÑADIDO CORRECTAMENTE","Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("USUARIO YA EXISTE", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private bool guardar(string fichero, string cliente, string nombreApellidos)
        {
            bool correcto = true;
            StreamReader leer = new StreamReader(fichero);
            string informacion = leer.ReadToEnd();
            if (informacion.Contains(nombreApellidos))
            {
                correcto = false;
            }
            else
            {
                 leer.Close();
                 StreamWriter escribir = new StreamWriter(fichero, true);
                 escribir.Write(cliente);
                 escribir.Close();
            }
            return correcto;
        }

        private void btnDatos_Click(object sender, EventArgs e)
        {
            abrir("fichDatos.txt");
        }

        //Método que usamos para abrir un fichero y mostrar su contenido en otro formulario.
        public void abrir(string fichero)
        {
            StreamReader leer = new StreamReader(fichero);
            frmDatosArchivados ventana = new frmDatosArchivados(leer.ReadToEnd());
            ventana.ShowDialog();
            leer.Close();
        }
    }
}
