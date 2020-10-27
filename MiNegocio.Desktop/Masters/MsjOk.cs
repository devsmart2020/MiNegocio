using System.Windows.Forms;

namespace MiNegocio.Desktop.Masters
{
    public partial class MsjOk : Form
    {
        public MsjOk(string msj)
        {
            InitializeComponent();
            lblDetail.Text = msj;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
