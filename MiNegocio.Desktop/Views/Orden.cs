using MiNegocio.Desktop.Masters;
using MiNegocio.ViewModels.ViewModels;
using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiNegocio.Desktop.Views
{
    public partial class frmOrden : Form
    {
        #region Members Variables
        private protected frmBuscarCliente _frmBuscaCliente;
        private protected ClienteVIewModel _clienteVm;
        #endregion

        #region Constructor
        public frmOrden()
        {
            InitializeComponent();
            _clienteVm = new ClienteVIewModel();
        }
        #endregion

        #region Private Methods
        private async Task FormShown()
        {
            await GetClientes();
        }
        private void BindingEquipo()
        {

        }
        private void BindingOrden()
        {

        }
        private async Task GetClientes()
        {
            await _clienteVm.GetClientesCmd();
        }       
        private void FormMasterEquipo()
        {
            using (frmMasterEquipo masterEquipo = new frmMasterEquipo())
            {
                masterEquipo.ShowDialog();
            }
        }
        private void FormBuscaCliente()
        {
            using (_frmBuscaCliente = new frmBuscarCliente(_clienteVm.List))
            {
                _frmBuscaCliente.FormClosing += BuscarCliente_FormClosing;
                txtClienteEquipo.Focus();
                _frmBuscaCliente.ShowDialog();
            }
        }
        private void FormBuscaClienteClose()
        {
            if (_frmBuscaCliente.ClienteSeleccionado != null)
            {
                txtClienteEquipo.Text = _frmBuscaCliente.ClienteSeleccionado.DocId;
                lblNomClienteEquipo.Text = $"{_frmBuscaCliente.ClienteSeleccionado.Nombres} {_frmBuscaCliente.ClienteSeleccionado.Apellidos}";
                SendKeys.Send("{Enter}");
            }
        }       
        #endregion

        #region Events
        private async void frmOrden_Shown(object sender, EventArgs e)
        {
            await FormShown();
        }
        private void BuscarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormBuscaClienteClose();
        }
        private void btnAddMasterEquipo_Click(object sender, EventArgs e)
        {
            FormMasterEquipo();
        }
        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            FormBuscaCliente();
        }
        private void txtClienteEquipo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtSerial.Focus();
            }
        }

        #endregion


    }
}
