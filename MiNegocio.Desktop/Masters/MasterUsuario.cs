using MiNegocio.Desktop.Helpers;
using MiNegocio.Desktop.Properties;
using MiNegocio.Models.Models;
using MiNegocio.ViewModels.ViewModels;
using Syncfusion.WinForms.DataGrid.Enums;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiNegocio.Desktop.Masters
{
    public partial class frmMasterUsuario : Form
    {
        #region Members Variables
        private MsjOk _msjOk;
        private MsjFail _msjFail;
        private protected UsuarioViewModel _usuarioVm;
        private protected PerfilViewModel _perfilVm;
        #endregion

        #region Constructor
        public frmMasterUsuario()
        {
            InitializeComponent();
            _usuarioVm = new UsuarioViewModel();
            _perfilVm = new PerfilViewModel();
            Binding();
        }
        #endregion

        #region Private Methods
        private void Binding()
        {
            pbLoad.DataBindings.Add(Resources.BindingVisible, _usuarioVm, Resources.PropIsBusy, false, DataSourceUpdateMode.OnPropertyChanged);
            dgvUsuario.DataBindings.Add(Resources.BindingDataSource, _usuarioVm, Resources.PropList, false, DataSourceUpdateMode.OnPropertyChanged);
            cmbPerfil.DataBindings.Add(Resources.BindingDataSource, _perfilVm, Resources.PropList, false, DataSourceUpdateMode.OnPropertyChanged);
            cmbPerfil.DataBindings.Add(Resources.BindingSelectedValue, _usuarioVm, Resources.CmbValuePerfil, false, DataSourceUpdateMode.OnPropertyChanged);
            txtDocId.DataBindings.Add(Resources.BindingEnabled, _usuarioVm, Resources.PropIsEnabled, false, DataSourceUpdateMode.OnPropertyChanged);
            btnGuardar.DataBindings.Add(Resources.BindingEnabled, _usuarioVm, Resources.PropIsEnabled, false, DataSourceUpdateMode.OnPropertyChanged);
            txtDocId.DataBindings.Add(Resources.BindingText, _usuarioVm, "DocId", false, DataSourceUpdateMode.OnPropertyChanged);
            txtNombre.DataBindings.Add(Resources.BindingText, _usuarioVm, "Nombres", false, DataSourceUpdateMode.OnPropertyChanged);
            txtApellido.DataBindings.Add(Resources.BindingText, _usuarioVm, "Apellidos", false, DataSourceUpdateMode.OnPropertyChanged);
            txtTelefono.DataBindings.Add(Resources.BindingText, _usuarioVm, "Telefono", false, DataSourceUpdateMode.OnPropertyChanged);
            txtDireccion.DataBindings.Add(Resources.BindingText, _usuarioVm, "Direccion", false, DataSourceUpdateMode.OnPropertyChanged);
            txtUsuario.DataBindings.Add(Resources.BindingText, _usuarioVm, Resources.PropUser, false, DataSourceUpdateMode.OnPropertyChanged);
            txtPass.DataBindings.Add(Resources.BindingText, _usuarioVm, Resources.PropPass, false, DataSourceUpdateMode.OnPropertyChanged);
            rbActivo.DataBindings.Add(Resources.BindingChecked, _usuarioVm, "Estado", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private bool ValidateUser()
        {
            bool noError = true;
            if (string.IsNullOrEmpty(txtDocId.Text))
            {
                errorUsuario.SetError(txtDocId, Resources.MsjValidateField);
                noError = false;
            }
            else if (string.IsNullOrEmpty(txtNombre.Text))
            {
                errorUsuario.SetError(txtNombre, Resources.MsjValidateField);
                noError = false;
            }
            else if (string.IsNullOrEmpty(txtApellido.Text))
            {
                errorUsuario.SetError(txtApellido, Resources.MsjValidateField);
                noError = false;
            }
            else if (string.IsNullOrEmpty(txtDireccion.Text))
            {
                errorUsuario.SetError(txtDireccion, Resources.MsjValidateField);
                noError = false;
            }
            else if (string.IsNullOrEmpty(txtTelefono.Text))
            {
                errorUsuario.SetError(txtTelefono, Resources.MsjValidateField);
                noError = false;
            }
            else if (string.IsNullOrEmpty(txtUsuario.Text))
            {
                errorUsuario.SetError(txtUsuario, Resources.MsjValidateField);
                noError = false;
            }
            else if (string.IsNullOrEmpty(txtPass.Text))
            {
                errorUsuario.SetError(txtPass, Resources.MsjValidateField);
                noError = false;
            }
            else if (cmbPerfil.SelectedValue == default)
            {
                errorUsuario.SetError(cmbPerfil, Resources.MsjValidateField);
                noError = false;
            }
            else
            {
                errorUsuario.Clear();
            }
            return noError;
        }
        private async Task FormShown()
        {
            await GetUsers();
            await GetPerfil();
        }
        private async Task GetUsers()
        {
            await _usuarioVm.GetsCmd();
            if (_usuarioVm.List == null)
            {
                using (_msjFail = new MsjFail(_usuarioVm.Msj))
                {
                    _msjFail.ShowDialog();
                }
            }
            else
            {
                dgvUsuario.SearchController.SearchHighlightColor = Color.SeaGreen;
                dgvUsuario.Columns[7].Visible = false;
                dgvUsuario.Columns[9].Visible = false;
                dgvUsuario.Columns[10].Visible = false;
                dgvUsuario.Columns[11].Visible = false;
                dgvUsuario.Columns[0].ShowFilterRowOptions = false;
                dgvUsuario.Columns[1].ShowFilterRowOptions = false;
                dgvUsuario.Columns[2].ShowFilterRowOptions = false;
                dgvUsuario.Columns[3].ShowFilterRowOptions = false;
                dgvUsuario.Columns[4].ShowFilterRowOptions = false;
                dgvUsuario.Columns[5].ShowFilterRowOptions = false;
                dgvUsuario.Columns[6].ShowFilterRowOptions = false;
                dgvUsuario.Columns[7].ShowFilterRowOptions = false;
                dgvUsuario.Columns[8].ShowFilterRowOptions = false;
            }
            //Search
            dgvUsuario.SearchController.AllowFiltering = true;
            dgvUsuario.FilterRowPosition = RowPosition.Bottom;
        }
        private async Task GetPerfil()
        {
            await _perfilVm.GetsCmd();
            cmbPerfil.ValueMember = Resources.CmbValuePerfil;
            cmbPerfil.DisplayMember = Resources.CmbDisplayPerfil;
        }
        private void SearchUser(TextBox textBox)
        {
            if (dgvUsuario.RowCount > 0)
            {
                string search = textBox.Text;
                if (string.IsNullOrEmpty(search))
                {
                    dgvUsuario.SearchController.ClearSearch();
                }
                dgvUsuario.SearchController.Search(search);
                dgvUsuario.SearchController.FindNext(search);
                dgvUsuario.View.RefreshFilter();
            }           
        }
        private void Selected()
        {
            var usuario = dgvUsuario.SelectedItem;
            _usuarioVm.Usuario = (UsuarioDTO)usuario;
        }
        private async Task Post()
        {
            if (ValidateUser())
            {
                _usuarioVm.Fecha = Convert.ToDateTime(dpFcha.Value);
                await _usuarioVm.PostCmd();
                if (_usuarioVm.IsSaved)
                {
                    await GetUsers();
                    using (_msjOk = new MsjOk(_usuarioVm.Msj))
                    {
                        _msjOk.ShowDialog();
                    }
                }
                else
                {
                    using (_msjFail = new MsjFail(_usuarioVm.Msj))
                    {
                        _msjFail.ShowDialog();
                    }
                }
            }
        }

        #endregion

        #region Events
        private async void MasterUsuario_Shown(object sender, System.EventArgs e)
        {
            await FormShown();
        }
        private async void btnGuardar_Click(object sender, System.EventArgs e)
        {
            _usuarioVm.IsNewItem = true;
            await Post();
        }
        private async void btnActualizar_Click(object sender, System.EventArgs e)
        {
            _usuarioVm.IsNewItem = false;
            await Post();
        }
        private void txtDocId_KeyPress(object sender, KeyPressEventArgs e)
        {
            DataHelper.Textbox_KeyPress(e);
        }
        private void txtDocId_TextChanged(object sender, EventArgs e)
        {
            SearchUser(txtDocId);
        }
        private void txtNombre_TextChanged(object sender, EventArgs e)
        {
            SearchUser(txtNombre);
        }
        private void dgvUsuario_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            Selected();
        }
        #endregion


    }
}
