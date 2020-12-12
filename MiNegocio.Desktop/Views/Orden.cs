using MiNegocio.Desktop.Masters;
using MiNegocio.Desktop.Properties;
using MiNegocio.ViewModels.ViewModels;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiNegocio.Desktop.Views
{
    public partial class frmOrden : Form
    {
        #region Members Variables
        private MsjOk _msjOk;
        private MsjFail _msjFail;
        private protected frmBuscarCliente _frmBuscaCliente;
        private protected frmMasterEquipo _masterEquipo;
        private protected frmBuscarOrden _frmBuscarOrden;
        private protected frmEquipoCliente _frmEquipoCliente;      
        private protected ClienteVIewModel _clienteVm;
        private protected MarcaViewModel _marcaVm;
        private protected TipoEquipoViewModel _tipoEquipoVm;
        private protected ModeloViewModel _modeloVm;
        private protected EquipoViewModel _equipoVm;
        private protected OrdenViewModel _ordenVm;
        private protected EstadoOrdenViewModel _estadoOrden;
        private protected UsuarioViewModel _usuarioVm;
        #endregion

        #region Constructor
        public frmOrden()
        {
            InitializeComponent();
            _clienteVm = new ClienteVIewModel();
            _marcaVm = new MarcaViewModel();
            _tipoEquipoVm = new TipoEquipoViewModel();
            _modeloVm = new ModeloViewModel();
            _equipoVm = new EquipoViewModel();
            _ordenVm = new OrdenViewModel();
            _estadoOrden = new EstadoOrdenViewModel();
            _usuarioVm = new UsuarioViewModel();
            BindingEquipo();
            BindingOrden();
        }
        #endregion

        #region Private Methods
        private async Task FormShown()
        {
            pbLoading.Visible = true;
            await GetClientes();
            await GetMarca();
            await GetTipoEquipo();
            await GetOrdenes();
            await GetModelo();
            await _usuarioVm.GetTecnicosCmd();
            CmbTecnico();
            await CmbEstadoOrden();
            pbLoading.Visible = false;
        }
        private void BindingEquipo()
        {
            pbLoadEquipo.DataBindings.Add(Resources.BindingVisible, _equipoVm, Resources.PropIsBusy, false, DataSourceUpdateMode.OnPropertyChanged);
            cmbMarca.DataBindings.Add(Resources.BindingDataSource, _marcaVm, Resources.PropList, false, DataSourceUpdateMode.OnPropertyChanged);
            cmbMarca.DataBindings.Add(Resources.BindingSelectedValue, _equipoVm, "IdMarca", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbTipoE.DataBindings.Add(Resources.BindingDataSource, _tipoEquipoVm, Resources.PropList, false, DataSourceUpdateMode.OnPropertyChanged);
            cmbTipoE.DataBindings.Add(Resources.BindingSelectedValue, _equipoVm, "IdTipoEquipo", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbModelo.DataBindings.Add(Resources.BindingDataSource, _modeloVm, "CmbModelo", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbModelo.DataBindings.Add(Resources.BindingSelectedValue, _equipoVm, "IdModelo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtClienteEquipo.DataBindings.Add(Resources.BindingText, _equipoVm, "IdCliente", false, DataSourceUpdateMode.OnPropertyChanged);
            txtSerial.DataBindings.Add(Resources.BindingText, _equipoVm, "Serie", false, DataSourceUpdateMode.OnPropertyChanged);
            txtImei1.DataBindings.Add(Resources.BindingText, _equipoVm, "Imei1", false, DataSourceUpdateMode.OnPropertyChanged);
            txtObsEquipo.DataBindings.Add(Resources.BindingText, _equipoVm, "Observacion", false, DataSourceUpdateMode.OnPropertyChanged);
            txtColor.DataBindings.Add(Resources.BindingText, _equipoVm, "Color", false, DataSourceUpdateMode.OnPropertyChanged);
            txtInfoTipo.DataBindings.Add(Resources.BindingText, _equipoVm, "TipoEquipo", false, DataSourceUpdateMode.OnPropertyChanged);
            txtInfoMarca.DataBindings.Add(Resources.BindingText, _equipoVm, "Marca", false, DataSourceUpdateMode.OnPropertyChanged);
            txtInfoModelo.DataBindings.Add(Resources.BindingText, _equipoVm, "Modelo", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void BindingOrden()
        {
            btnGuardarOrden.DataBindings.Add(Resources.BindingEnabled, _ordenVm, Resources.PropIsEnabled, false, DataSourceUpdateMode.OnPropertyChanged);
            pbLoadOrden.DataBindings.Add(Resources.BindingVisible, _ordenVm, Resources.PropIsBusy, false, DataSourceUpdateMode.OnPropertyChanged);
            cmbEstadoOrden.DataBindings.Add(Resources.BindingDataSource, _estadoOrden, Resources.PropList, false, DataSourceUpdateMode.OnPropertyChanged);
            cmbEstadoOrden.DataBindings.Add(Resources.BindingSelectedValue, _ordenVm, Resources.CmbValueEstadoOrden, false, DataSourceUpdateMode.OnPropertyChanged);
            txtClienteOrden.DataBindings.Add(Resources.BindingText, _ordenVm, "IdCliente", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDiagCliente.DataBindings.Add(Resources.BindingText, _ordenVm, "DiagCliente", false, DataSourceUpdateMode.OnPropertyChanged);
            txtObsOrden.DataBindings.Add(Resources.BindingText, _ordenVm, "DiagTecnico", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDatoBloqueo.DataBindings.Add(Resources.BindingText, _ordenVm, "DatoBloqueo", false, DataSourceUpdateMode.OnPropertyChanged);
            chkSDSi.DataBindings.Add(Resources.BindingChecked, _ordenVm, "MicroSD", false, DataSourceUpdateMode.OnPropertyChanged);
            chkSimSi.DataBindings.Add(Resources.BindingChecked, _ordenVm, "Sim", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbTecnico.DataBindings.Add(Resources.BindingDataSource, _usuarioVm, "Tecnicos", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbTecnico.DataBindings.Add(Resources.BindingSelectedValue, _ordenVm, "IdTecnico", false, DataSourceUpdateMode.OnPropertyChanged);
            txtBuscaOrden.DataBindings.Add(Resources.BindingText, _clienteVm, "DocId", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private bool ValidateOrden()
        {
            bool noError = true;
            if (string.IsNullOrEmpty(txtClienteOrden.Text))
            {
                errorOrden.SetError(txtClienteOrden, Resources.MsjValidateField);
                noError = false;
            }
            else if (string.IsNullOrEmpty(txtDiagCliente.Text))
            {
                errorOrden.SetError(txtDiagCliente, Resources.MsjValidateField);
                noError = false;
            }
            else if (cmbTecnico.SelectedValue == default)
            {
                errorOrden.SetError(cmbTecnico, Resources.MsjValidateField);
                noError = false;
            }
            else
            {
                errorOrden.Clear();
                noError = true;
            }
            return noError;
        }
        private async Task GetClientes()
        {
            await _clienteVm.GetClientesCmd();
        }
        private async Task GetEquiposCliente()
        {
            _clienteVm.DocId = txtClienteOrden.Text.Trim();
            await _clienteVm.GetEquiposxClienteCmd();
            if (_clienteVm.EquiposxCliente.Any())
            {
                using (_frmEquipoCliente = new frmEquipoCliente(_clienteVm.EquiposxCliente))
                {
                    _frmEquipoCliente.FormClosing += _frmEquipoCliente_FormClosing;
                    txtDiagCliente.Focus();
                    _frmEquipoCliente.ShowDialog();
                }
            }
        }
        private void FormEquipoClienteClosed()
        {
            if (_frmEquipoCliente.EquipoSeleccionado != null)
            {
                _equipoVm.Equipo = _frmEquipoCliente.EquipoSeleccionado;
            }
        }        
        private async Task GetOrdenes()
        {
            await _ordenVm.GetsCmd();
        }
        private async Task GetMarca()
        {
            await _marcaVm.GetsCmd();
            if (_marcaVm.List != null)
            {
                cmbMarca.ValueMember = Resources.CmbValueMarca;
                cmbMarca.DisplayMember = Resources.CmbDisplayMarca;
            }
            else
            {
                cmbMarca.Text = Resources.MsjNoDatos;
            }
        }
        private async Task GetTipoEquipo()
        {
            await _tipoEquipoVm.GetsCmd();
            if (_tipoEquipoVm.List != null)
            {
                cmbTipoE.ValueMember = Resources.CmbValueTipoEquipo;
                cmbTipoE.DisplayMember = Resources.CmbDisplayTIpoEquipo;
            }
            else
            {
                cmbTipoE.Text = Resources.MsjNoDatos;
            }
        }
        private async Task GetModelo()
        {
            await _modeloVm.GetsCmd();
            if (_modeloVm.List != null)
            {
                cmbModelo.ValueMember = Resources.CmbValueModelo;
                cmbModelo.DisplayMember = Resources.CmbDisplayModelo;
            }
            else
            {
                cmbModelo.Text = Resources.MsjNoDatos;
            }
        }      
        private async Task CmbModelo()
        {            
            if (cmbTipoE.SelectedItems != null && cmbMarca.SelectedItems != null )
            {
                _modeloVm.IdTipoEquipo = Convert.ToInt32(cmbTipoE.SelectedValue);
                _modeloVm.IdMarca = Convert.ToInt32(cmbMarca.SelectedValue);
                _modeloVm.GetCmbModeloCmd();
            }
            await Task.Delay(1);
        }
        private void CmbTecnico()
        {            
            cmbTecnico.ValueMember = Resources.CmbValueCliente;
            cmbTecnico.DisplayMember = "NomCompleto";
        }
        private async Task CmbEstadoOrden()
        {
            await _estadoOrden.GetsCmd();
            cmbEstadoOrden.ValueMember = Resources.CmbValueEstadoOrden;
            cmbEstadoOrden.DisplayMember = Resources.CmbDisplayEstadoOrden;
        }
        private async Task PostEquipo()
        {
            if (cmbModelo.SelectedValue != default && !string.IsNullOrEmpty(txtClienteEquipo.Text))
            {
                _equipoVm.IsNewItem = true;
                await _equipoVm.PostCmd();
                if (_equipoVm.IsSaved)
                {              
                    using (_msjOk = new MsjOk(_equipoVm.Msj))
                    {
                        _msjOk.ShowDialog();
                    }
                }
                else
                {
                    using (_msjFail = new MsjFail(_equipoVm.Msj))
                    {
                        _msjFail.ShowDialog();
                    }
                }
            }
            else
            {
                using (_msjFail = new MsjFail(Resources.MsjValidateField))
                {
                    _msjFail.ShowDialog();
                }
            }
        }
        private async Task PostOrden()
        {
            if (ValidateOrden())
            {
                _ordenVm.IdEquipo = _equipoVm.IdModelo;
                await _ordenVm.PostCmd();
                if (_ordenVm.IsSaved)
                {
                    using (_msjOk = new MsjOk(_ordenVm.Msj))
                    {
                        _msjOk.ShowDialog();
                    }
                }
                else
                {
                    using (_msjFail = new MsjFail(_ordenVm.Msj))
                    {
                        _msjFail.ShowDialog();
                    }
                }
            }
        }
        private void FormMasterEquipo()
        {
            using (_masterEquipo = new frmMasterEquipo())
            {
                txtClienteOrden.Focus();
                _masterEquipo.ShowDialog();
            }
        }     
        private void FormBuscaCliente(string textBox)
        {
            using (_frmBuscaCliente = new frmBuscarCliente(_clienteVm.List,textBox))
            {
                _frmBuscaCliente.FormClosing += BuscarCliente_FormClosing;
                txtClienteEquipo.Focus();
                _frmBuscaCliente.ShowDialog();
            }
        }
        private async Task FormBuscaClienteClose()
        {
            if (_frmBuscaCliente.ClienteSeleccionado != null)
            {
                txtClienteEquipo.Text = _frmBuscaCliente.ClienteSeleccionado.DocId;
                _ordenVm.IdCliente = txtClienteEquipo.Text;
                lblNomClienteEquipo.Text = $"{_frmBuscaCliente.ClienteSeleccionado.Nombres} {_frmBuscaCliente.ClienteSeleccionado.Apellidos}";
                lblNomClienteOrden.Text = lblNomClienteEquipo.Text;                
                _clienteVm.DocId = txtClienteEquipo.Text;
                txtBuscaOrden.Text = txtClienteEquipo.Text;
                lblNomClienteBo.Text = lblNomClienteEquipo.Text;
                await GetEquiposCliente();      
                //SendKeys.Send("{Enter}");
            }
        }              
        private async Task GetOrdenxCliente()
        {
            if (!string.IsNullOrEmpty(txtBuscaOrden.Text))
            {
                _ordenVm.IdCliente = txtBuscaOrden.Text.Trim();
                await _ordenVm.GetOrdenClienteCmd();
                if (_ordenVm.OrdenxCliente.Any())
                {
                    using (_frmBuscarOrden = new frmBuscarOrden(_ordenVm.OrdenxCliente))
                    {
                        _frmBuscarOrden.FormClosing += _frmBuscarOrden_FormClosing;
                        _frmBuscarOrden.ShowDialog();
                    }
                }           
            }
        }
        private void FormBuscaOrdenClosed()
        {
            if (_frmBuscarOrden.OrdenSeleccionada != null)
            {
                _ordenVm.Orden = _frmBuscarOrden.OrdenSeleccionada;
                _ordenVm.IdOrden = _frmBuscarOrden.OrdenSeleccionada.IdOrden;

            }
        }
        private void _frmBuscarOrden_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormBuscaOrdenClosed();
               
        }
        #endregion

        #region Events
        private async void frmOrden_Shown(object sender, EventArgs e)
        {
            await FormShown();
        }
        private async void BuscarCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            await FormBuscaClienteClose();
        }
        private void _frmEquipoCliente_FormClosing(object sender, FormClosingEventArgs e)
        {
            FormEquipoClienteClosed();
        }
        private void btnAddMasterEquipo_Click(object sender, EventArgs e)
        {
            FormMasterEquipo();
        }
        private void btnBuscaCliente_Click(object sender, EventArgs e)
        {
            FormBuscaCliente(string.Empty);
        }
        private void txtClienteEquipo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FormBuscaCliente(txtClienteEquipo.Text);
                txtSerial.Focus();
            }
        }
      
        private async void btnGuardaEquipo_Click(object sender, EventArgs e)
        {
            await PostEquipo();
        }
        private void txtClienteOrden_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space)
            {                 
                 FormBuscaCliente(txtClienteOrden.Text);
            }
        }
        private async void btnGuardarOrden_Click(object sender, EventArgs e)
        {
            _ordenVm.FechaEntra = DateTime.Now;
            _ordenVm.IsNewItem = true;
            await PostOrden();
        }
        private async void btnActualizaOrden_Click(object sender, EventArgs e)
        {
            _ordenVm.IsNewItem = false;
            await PostOrden();
        }
        private void btnAddTecnico_Click(object sender, EventArgs e)
        {
            using (frmMasterUsuario usuario = new frmMasterUsuario())
            {
                usuario.ShowDialog();
            }
        }
        private async void btnBuscaOrden_Click(object sender, EventArgs e)
        {
            await GetOrdenxCliente();
        }
        private async void cmbModelo_DropDownOpened(object sender, EventArgs e)
        {
            await CmbModelo();
        }

        #endregion
      
    }
}
