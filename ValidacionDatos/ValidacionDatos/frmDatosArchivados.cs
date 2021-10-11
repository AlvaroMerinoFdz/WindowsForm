using System.Windows.Forms;

namespace ValidacionDatos
{
    public partial class frmDatosArchivados : Form
    {
        public frmDatosArchivados(string texto)
        {
            InitializeComponent();

            txtTexto.ScrollBars = ScrollBars.Vertical;
            txtTexto.AcceptsReturn = true;
            txtTexto.AcceptsTab = true;

            txtTexto.Text = texto;
        }
    }
}
