using System;
using System.Data;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml;

namespace LecturaXML
{
    public partial class FrmLecturaXML : Form
    {
        string ruta;
        
        public FrmLecturaXML()
        {
            InitializeComponent();
        }

        private void btnLeerXML_Click(object sender, EventArgs e)
        {

            if (abrir.ShowDialog() == DialogResult.OK)
            {
                btnFicheroGenerado.Enabled = true;
                btnGuardar.Enabled = true;
                btnMostrar.Enabled = true;
                btnTelefonos.Enabled = true;
                ruta = abrir.FileName;
                LimpiarDatos();
                dsDatos.ReadXml(ruta);
                dgvDatos.DataSource = dsDatos.Tables[0];

                /* XmlDocument xDoc = new XmlDocument();
                 xDoc.Load(ruta);
                 XmlNodeList clase = xDoc.GetElementsByTagName("clase");
                 XmlNodeList lista = ((XmlElement)clase[0]).GetElementsByTagName("persona");*/

            }
            /*else
            {
                MessageBox.Show("Tienes que seleccionar un archivo", "Error", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }*/
        }

        private void LimpiarDatos()
        {
            dsDatos = new DataSet(); ;
            dgvDatos.DataSource = null;
            dgvDatos.Rows.Clear();
            dgvDatos.Columns.Clear();
            dgvDatos.Refresh();
            rtbEsquema.Text = "";
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            StringWriter swXML = new StringWriter();
            this.dsDatos.WriteXmlSchema(swXML);
            this.rtbEsquema.Text = swXML.ToString();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {

            FileStream fichXML = new FileStream(ruta, FileMode.Create);
            this.dsDatos.WriteXml(fichXML);
            fichXML.Close();
            MessageBox.Show("Datos guardados correctamente.", "Datos Guardados", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnTelefonos_Click(object sender, EventArgs e)
        {
            frmTelefonos frmtelefonos = new frmTelefonos(dsDatos);
            frmtelefonos.ShowDialog();
        }

        private void btnFicheroGenerado_Click(object sender, EventArgs e)
        {
            //1º se crea el elemento raíz y se asocio al documento
            XmlDocument xDoc = new XmlDocument();
            XmlElement elementoRaiz = xDoc.CreateElement(string.Empty, "raiz", String.Empty);
            xDoc.AppendChild(elementoRaiz);

            //Para crear un hijo, se crea, se le ponen los atributos ( si tiene)
            XmlElement xHijo = xDoc.CreateElement(string.Empty, "hijo", string.Empty);
            xHijo.SetAttribute("id", "el_valor_que_yo_quiera");
            

            //Creamos las 2 hijas
            XmlElement xUna = xDoc.CreateElement(string.Empty, "una", string.Empty);
            XmlElement otra = xDoc.CreateElement(string.Empty, "otra", string.Empty);

            //meto los valores de las etiquetas hijas
            XmlText xTxUna = xDoc.CreateTextNode("un_valor");
            xUna.AppendChild(xTxUna);
            xHijo.AppendChild(xUna);

            XmlText xTxotra = xDoc.CreateTextNode("otro_valor");
            otra.AppendChild(xTxotra);
            xHijo.AppendChild(otra);

            //por ultimo metemos a xHijo como hijo de elementoRaiz
            elementoRaiz.AppendChild(xHijo);

            //Ahora vamos a guardar el documento con formato correcto
            XmlTextWriter xtw = new XmlTextWriter("prueba.xml", Encoding.UTF8);
            xtw.Formatting = Formatting.Indented;
            xDoc.Save(xtw);
            xtw.Close();
        }
    }
}
