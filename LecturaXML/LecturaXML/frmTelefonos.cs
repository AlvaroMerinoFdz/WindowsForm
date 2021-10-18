using System;
using System.Data;
using System.Windows.Forms;

namespace LecturaXML
{
    public partial class frmTelefonos : Form
    {
        private DataSet dsDatos;

        public frmTelefonos(DataSet dsDatos)
        {
            InitializeComponent();
            this.dsDatos = dsDatos;
        }

        private void frmTelefonos_Load(object sender, EventArgs e)
        {
            DataTable tabla = dsDatos.Tables[0];
            foreach (DataRow fila in tabla.Rows)
            {
                foreach (DataColumn columna in tabla.Columns)
                {
                    if (columna.ColumnName.Equals("nombre_apellidos"))
                    {
                        rtbTelefonos.Text += fila[columna] + " -> ";
                    }
                    else if (columna.ColumnName.Equals("tcontacto"))
                    {
                        rtbTelefonos.Text += fila[columna] + Environment.NewLine;
                    }
                }
            }
        }
    }
}
