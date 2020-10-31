using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiNegocio.Desktop.Views
{
    public partial class frmMain : Form
    {
        #region Members Variables
        #endregion

        #region Constructor
        public frmMain()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Methods
        private void FormCliente()
        {
            frmCliente frmCliente = new frmCliente { MdiParent = this };
            frmCliente.Show();
        }
        private void FormOrden()
        {
            frmOrden frmOrden = new frmOrden { MdiParent = this };
            frmOrden.Show();
        }
        private void FormVenta()
        {
            frmVenta frmVenta = new frmVenta { MdiParent = this };
            frmVenta.Show();
        }
        private void FormInventario()
        {
            frmInventario frmInventario = new frmInventario { MdiParent = this };
            frmInventario.Show();
        }
        private void FormServicio()
        {
            frmServicio frmServicio = new frmServicio { MdiParent = this };
            frmServicio.Show();
        }
        private void FormCredito()
        {
            frmCredito frmCredito = new frmCredito { MdiParent = this };
            frmCredito.Show();
        }
        private void FormAjuste()
        {
            frmAjuste frmAjuste = new frmAjuste { MdiParent = this };
            frmAjuste.Show();
        }
        #endregion

        #region Events
        private async void btnCliente_Click(object sender, System.EventArgs e)
        {
            FormCliente();
            await Task.Delay(1);
        }
        private async void btnOrden_Click(object sender, System.EventArgs e)
        {
            FormOrden();
            await Task.Delay(1);
        }
        private async void btnVenta_Click(object sender, System.EventArgs e)
        {
            FormVenta();
            await Task.Delay(1);
        }
        private async void btnInventario_Click(object sender, System.EventArgs e)
        {
            FormInventario();
            await Task.Delay(1);
        }
        private async void btnServicio_Click(object sender, System.EventArgs e)
        {
            FormServicio();
            await Task.Delay(1);
        }
        private async void btnCredito_Click(object sender, System.EventArgs e)
        {
            FormCredito();
            await Task.Delay(1);
        }
        private async void btnAjuste_Click(object sender, System.EventArgs e)
        {
            FormAjuste();
            await Task.Delay(1);
        }
        private void btnSesion_Click(object sender, System.EventArgs e)
        {

        }
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }
        private void btnMinimize_Click(object sender, System.EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        #endregion


    }
}
