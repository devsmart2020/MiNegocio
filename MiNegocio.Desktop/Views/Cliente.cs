using MiNegocio.Desktop.Helpers;
using MiNegocio.Desktop.Masters;
using MiNegocio.Desktop.Properties;
using MiNegocio.Models.Models;
using MiNegocio.ViewModels.ViewModels;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace MiNegocio.Desktop.Views
{
    public partial class frmCliente : Form
    {
        #region Members Variables
        private MsjOk _msjOk;
        private MsjFail _msjFail;
        private protected ClienteVIewModel _clienteVm;
        #endregion

        #region Constructor
        public frmCliente()
        {
            InitializeComponent();
            _clienteVm = new ClienteVIewModel();
            Binding();
        }
        #endregion

        #region Private Methods
        private void Binding()
        {
            dgvCliente.DataBindings.Add(Resources.BindingDataSource, _clienteVm, Resources.PropList, false, DataSourceUpdateMode.OnPropertyChanged);
            pbLoad.DataBindings.Add(Resources.BindingVisible, _clienteVm, Resources.PropIsBusy, false, DataSourceUpdateMode.OnPropertyChanged);
            pbLoading.DataBindings.Add(Resources.BindingVisible, _clienteVm, Resources.PropIsVisible, false, DataSourceUpdateMode.OnPropertyChanged);
            btnGuardar.DataBindings.Add(Resources.BindingEnabled, _clienteVm, Resources.PropIsEnabled, false, DataSourceUpdateMode.OnPropertyChanged);
            txtDocId.DataBindings.Add(Resources.BindingEnabled, _clienteVm, Resources.PropIsEnabled, false, DataSourceUpdateMode.OnPropertyChanged);
            txtDocId.DataBindings.Add(Resources.BindingText, _clienteVm, "DocId", false, DataSourceUpdateMode.OnPropertyChanged);
            txtNombre.DataBindings.Add(Resources.BindingText, _clienteVm, "Nombres", false, DataSourceUpdateMode.OnPropertyChanged);
            txtApellido.DataBindings.Add(Resources.BindingText, _clienteVm, "Apellidos", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefono.DataBindings.Add(Resources.BindingText, _clienteVm, "Telefono", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTelAlterno.DataBindings.Add(Resources.BindingText, _clienteVm, "TelAlternativo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtEmail.DataBindings.Add(Resources.BindingText, _clienteVm, "Email", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDireccion.DataBindings.Add(Resources.BindingText, _clienteVm, "Direccion", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private bool FieldsValidation()
        {
            bool noError = true;
            if (string.IsNullOrEmpty(txtDocId.Text))
            {
                errorCliente.SetError(txtDocId, Resources.MsjValidateField);
                noError = false;
            }
            else if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorCliente.SetError(txtNombre, Resources.MsjValidateField);
                noError = false;
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errorCliente.SetError(txtApellido, Resources.MsjValidateField);
                noError = false;
            }
            else
            {
                errorCliente.Clear();
            }
            return noError;
        }
        private async Task GetClientes()
        {
            await _clienteVm.GetClientesCmd();
            if (_clienteVm.List != null)
            {
                dgvCliente.Columns[5].Visible = false;
                dgvCliente.Columns[8].Visible = false;
                dgvCliente.Columns[9].Visible = false;
                dgvCliente.SearchController.SearchHighlightColor = Color.SeaGreen;
                dgvCliente.Columns[0].ShowFilterRowOptions = false;
                dgvCliente.Columns[1].ShowFilterRowOptions = false;
                dgvCliente.Columns[2].ShowFilterRowOptions = false;
                dgvCliente.Columns[3].ShowFilterRowOptions = false;
                dgvCliente.Columns[4].ShowFilterRowOptions = false;
                dgvCliente.Columns[5].ShowFilterRowOptions = false;
                dgvCliente.Columns[6].ShowFilterRowOptions = false;
                dgvCliente.Columns[7].ShowFilterRowOptions = false;
                dgvCliente.Columns[8].ShowFilterRowOptions = false;
                dgvCliente.Columns[9].ShowFilterRowOptions = false;
            }
            //Search
            dgvCliente.SearchController.AllowFiltering = true;
            dgvCliente.FilterRowPosition = RowPosition.Bottom;

        }
        private void Search(TextBox textBox)
        {
            string search = textBox.Text;
            if (string.IsNullOrEmpty(search))
            {
                dgvCliente.SearchController.ClearSearch();
            }
            dgvCliente.SearchController.Search(search);
            dgvCliente.SearchController.FindNext(search);
            dgvCliente.View.RefreshFilter();
        }
        private void SelectedCliente()
        {
            var cliente = dgvCliente.SelectedItem;
            _clienteVm.Cliente = (Tbcliente)cliente;
        }
        private async Task Post()
        {
            _clienteVm.Fecha = Convert.ToDateTime(dpFcha.Value);
            if (FieldsValidation())
            {
                await _clienteVm.PostCmd();
                if (_clienteVm.IsSaved)
                {
                    using (_msjOk = new MsjOk(_clienteVm.Msj))
                    {
                        await GetClientes();
                        _msjOk.ShowDialog();
                    }
                }
                else
                {
                    using (_msjFail = new MsjFail(_clienteVm.Msj))
                    {
                        _msjFail.ShowDialog();
                    }
                }
            }
            txtBuscar.ResetText();
        }
        #endregion

        #region Events
        private async void frmCliente_Shown(object sender, System.EventArgs e)
        {
            await GetClientes();
        }
        private void txtDocId_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataHelper.Textbox_KeyPress(e);
        }
        private void txtDocId_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                _clienteVm.GetByIdCmd();
            }
        }
        private void txtTelefono_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataHelper.Textbox_KeyPress(e);
        }
        private void txtTelAlterno_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataHelper.Textbox_KeyPress(e);
        }
        private void txtDocId_TextChanged(object sender, EventArgs e)
        {
            Search(txtDocId);
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            Search(txtNombre);
        }
        private void txtBuscar_TextChanged(object sender, System.EventArgs e)
        {
            Search(txtBuscar);
        }
        private void dgvCliente_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            SelectedCliente();
        }
        private async void btnGuardar_Click(object sender, EventArgs e)
        {
            _clienteVm.IsNewItem = true;
            await Post();
        }
        private async void btnActualizar_Click(object sender, EventArgs e)
        {
            _clienteVm.IsNewItem = false;
            await Post();
        }
        #endregion


    }
}
