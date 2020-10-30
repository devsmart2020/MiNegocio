using System.Windows.Forms;

namespace MiNegocio.Desktop.Masters
{
    public partial class MsjFail : Form
    {
        public MsjFail(string error)
        {
            InitializeComponent();
            lblError.Text = error;
        }

        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Close();
        }
    }
}
