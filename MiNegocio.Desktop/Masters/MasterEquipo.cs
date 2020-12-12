using MiNegocio.Desktop.Properties;
using MiNegocio.Models.Models;
using MiNegocio.ViewModels.ViewModels;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiNegocio.Desktop.Masters
{
    public partial class frmMasterEquipo : Form
    {
        #region Members Variables
        private MsjOk _msjOk;
        private MsjFail _msjFail;
        private protected TipoEquipoViewModel _tipoEquipoVm;
        private protected MarcaViewModel _marcaVm;
        private protected ModeloViewModel _modeloVm;
        #endregion

        #region Constructor
        public frmMasterEquipo()
        {
            InitializeComponent();
            _tipoEquipoVm = new TipoEquipoViewModel();
            _marcaVm = new MarcaViewModel();
            _modeloVm = new ModeloViewModel();
            BindingTE();
            BindingMarca();
            BindingModelo();
        }
        #endregion

        #region Private Methods
        private void BindingTE()
        {
            dgvTipoEquipo.DataBindings.Add(Resources.BindingDataSource, _tipoEquipoVm, Resources.PropList, false, DataSourceUpdateMode.OnPropertyChanged);
            pbLoadTE.DataBindings.Add(Resources.BindingVisible, _tipoEquipoVm, Resources.PropIsBusy, false, DataSourceUpdateMode.OnPropertyChanged);
            btnGuardaTE.DataBindings.Add(Resources.BindingEnabled, _tipoEquipoVm, Resources.PropIsEnabled, false, DataSourceUpdateMode.OnPropertyChanged);
            txtNomTipoEquipo.DataBindings.Add(Resources.BindingText, _tipoEquipoVm, "Nombre", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbTE.DataBindings.Add(Resources.BindingDataSource, _tipoEquipoVm, Resources.PropList, false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void BindingMarca()
        {
            dgvMarca.DataBindings.Add(Resources.BindingDataSource, _marcaVm, Resources.PropList, false, DataSourceUpdateMode.OnPropertyChanged);
            pbLoadMarca.DataBindings.Add(Resources.BindingVisible, _marcaVm, Resources.PropIsBusy, false, DataSourceUpdateMode.OnPropertyChanged);
            btnGuardaMarca.DataBindings.Add(Resources.BindingEnabled, _marcaVm, Resources.PropIsEnabled, false, DataSourceUpdateMode.OnPropertyChanged);
            txtNomMarca.DataBindings.Add(Resources.BindingText, _marcaVm, "Nombre", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbMarca.DataBindings.Add(Resources.BindingDataSource, _marcaVm, Resources.PropList, false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private void BindingModelo()
        {
            dgvModelo.DataBindings.Add(Resources.BindingDataSource, _modeloVm, Resources.PropList, false, DataSourceUpdateMode.OnPropertyChanged);
            pbLoadModel.DataBindings.Add(Resources.BindingVisible, _modeloVm, Resources.PropIsBusy, false, DataSourceUpdateMode.OnPropertyChanged);
            btnGuardaModelo.DataBindings.Add(Resources.BindingEnabled, _modeloVm, Resources.PropIsEnabled, false, DataSourceUpdateMode.OnPropertyChanged);
            txtNomModelo.DataBindings.Add(Resources.BindingText, _modeloVm, "Nombre", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbMarca.DataBindings.Add(Resources.BindingSelectedValue, _modeloVm, "IdMarca", false, DataSourceUpdateMode.OnPropertyChanged);
            cmbTE.DataBindings.Add(Resources.BindingSelectedValue, _modeloVm, "IdTipoEquipo", false, DataSourceUpdateMode.OnPropertyChanged);
        }
        private async Task FormShown()
        {
            pbLoading.Visible = true;
            await GetTipoEquipos();
            await GetMarcas();
            await GetModelos();
            ComboTE();
            ComboMarca();
            pbLoading.Visible = false;
        }

        private async Task GetTipoEquipos()
        {
            await _tipoEquipoVm.GetsCmd();
            if (_tipoEquipoVm.List != null)
            {
                dgvTipoEquipo.Columns[0].Visible = false;
                dgvTipoEquipo.SearchController.SearchHighlightColor = Color.SeaGreen;
                dgvTipoEquipo.Columns[0].ShowFilterRowOptions = false;
                dgvTipoEquipo.Columns[1].ShowFilterRowOptions = false;
            }
            //Search
            dgvTipoEquipo.SearchController.AllowFiltering = true;
            dgvTipoEquipo.FilterRowPosition = RowPosition.Bottom;
        }
        private void ComboTE()
        {
            cmbTE.DisplayMember = "TipoEquipo";
            cmbTE.ValueMember = "IdTipoEquipo";
        }
        private void SearchTE(TextBox textBox)
        {
            string search = textBox.Text;
            if (string.IsNullOrEmpty(search))
            {
                dgvTipoEquipo.SearchController.ClearSearch();
            }
            dgvTipoEquipo.SearchController.Search(search);
            dgvTipoEquipo.SearchController.FindNext(search);
            dgvTipoEquipo.View.RefreshFilter();
        }
        private void SelectedTE()
        {
            var tipoEquipo = dgvTipoEquipo.SelectedItem;
            _tipoEquipoVm.TipoEquipo = (TipoEquipoDTO)tipoEquipo;
        }
        private async Task PostTE()
        {
            if (!string.IsNullOrEmpty(txtNomTipoEquipo.Text))
            {
                await _tipoEquipoVm.PostCmd();
                if (_tipoEquipoVm.IsSaved)
                {
                    using (_msjOk = new MsjOk(_tipoEquipoVm.Msj))
                    {
                        await GetTipoEquipos();
                        _msjOk.ShowDialog();
                    }
                }
                else
                {
                    using (_msjFail = new MsjFail(_tipoEquipoVm.Msj))
                    {
                        _msjFail.ShowDialog();
                    }
                }
            }
            txtNomTipoEquipo.ResetText();
        }
        private async Task GetMarcas()
        {
            await _marcaVm.GetsCmd();
            if (_marcaVm.List != null)
            {
                dgvMarca.Columns[0].Visible = false;
                dgvMarca.SearchController.SearchHighlightColor = Color.SeaGreen;
                dgvMarca.Columns[0].ShowFilterRowOptions = false;
                dgvMarca.Columns[1].ShowFilterRowOptions = false;
            }
            //Search
            dgvMarca.SearchController.AllowFiltering = true;
            dgvMarca.FilterRowPosition = RowPosition.Bottom;
        }
        private void ComboMarca()
        {
            cmbMarca.DisplayMember = "Marca";
            cmbMarca.ValueMember = "IdMarca";
        }
        private void SearchMarca(TextBox textBox)
        {
            string search = textBox.Text;
            if (string.IsNullOrEmpty(search))
            {
                dgvTipoEquipo.SearchController.ClearSearch();
            }
            dgvMarca.SearchController.Search(search);
            dgvMarca.SearchController.FindNext(search);
            dgvMarca.View.RefreshFilter();
        }
        private void SelectedMarca()
        {
            var marca = dgvMarca.SelectedItem;
            _marcaVm.Marca = (MarcaDTO)marca;
        }
        private async Task PostMarca()
        {
            if (!string.IsNullOrEmpty(txtNomMarca.Text))
            {
                await _marcaVm.PostCmd();
                if (_marcaVm.IsSaved)
                {
                    using (_msjOk = new MsjOk(_marcaVm.Msj))
                    {
                        await GetMarcas();
                        _msjOk.ShowDialog();
                    }
                }
                else
                {
                    using (_msjFail = new MsjFail(_marcaVm.Msj))
                    {
                        _msjFail.ShowDialog();
                    }
                }
            }
            txtNomMarca.ResetText();
        }

        private async Task GetModelos()
        {
            await _modeloVm.GetsCmd();
            if (_modeloVm.List != null)
            {
                dgvModelo.Columns[0].Visible = false;
                dgvModelo.Columns[2].Visible = false;
                dgvModelo.Columns[3].Visible = false;
                dgvModelo.SearchController.SearchHighlightColor = Color.SeaGreen;
                dgvModelo.Columns[0].ShowFilterRowOptions = false;
                dgvModelo.Columns[1].ShowFilterRowOptions = false;
            }
            //Search
            dgvModelo.SearchController.AllowFiltering = true;
            dgvModelo.FilterRowPosition = RowPosition.Bottom;
        }
        private void SearchModelo(TextBox textBox)
        {
            string search = textBox.Text;
            if (string.IsNullOrEmpty(search))
            {
                dgvModelo.SearchController.ClearSearch();
            }
            dgvModelo.SearchController.Search(search);
            dgvModelo.SearchController.FindNext(search);
            dgvModelo.View.RefreshFilter();
        }
        private void SelectedModelo()
        {
            var modelo = dgvModelo.SelectedItem;
            _modeloVm.Modelo = (ModeloDTO)modelo;
        }
        private async Task PostModelo()
        {
            if (!string.IsNullOrEmpty(txtNomModelo.Text))
            {
                await _modeloVm.PostCmd();
                if (_modeloVm.IsSaved)
                {
                    using (_msjOk = new MsjOk(_modeloVm.Msj))
                    {
                        await GetModelos();
                        _msjOk.ShowDialog();
                    }
                }
                else
                {
                    using (_msjFail = new MsjFail(_modeloVm.Msj))
                    {
                        _msjFail.ShowDialog();
                    }
                }
            }
            txtNomModelo.ResetText();
        }
        #endregion

        #region Events
        private async void frmMasterEquipo_Shown(object sender, System.EventArgs e)
        {
            await FormShown();          
        }
        private void txtNomTipoEquipo_TextChanged(object sender, System.EventArgs e)
        {
            SearchTE(txtNomTipoEquipo);
        }
        private void txtNomMarca_TextChanged(object sender, System.EventArgs e)
        {
            SearchMarca(txtNomMarca);
        }
        private void dgvTipoEquipo_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            SelectedTE();
        }        
        private async void btnGuardaTE_Click(object sender, System.EventArgs e)
        {
            _tipoEquipoVm.IsNewItem = true;
            await PostTE();
        }
        private async void btnUpdateTE_Click(object sender, System.EventArgs e)
        {
            _tipoEquipoVm.IsNewItem = false;
            await PostTE();
        }
        private void dgvMarca_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            SelectedMarca();
        }
        private async void btnGuardaMarca_Click(object sender, System.EventArgs e)
        {
            _marcaVm.IsNewItem = true;
            await PostMarca();
        }
        private async void btnUpdateMarca_Click(object sender, System.EventArgs e)
        {
            _marcaVm.IsNewItem = false;
            await PostMarca();
        }
        private void txtNomModelo_TextChanged(object sender, System.EventArgs e)
        {
            SearchModelo(txtNomModelo);
        }
        private void dgvModelo_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            SelectedModelo();
        }
        private async void btnGuardaModelo_Click(object sender, System.EventArgs e)
        {
            _modeloVm.IsNewItem = true;
            await PostModelo();
        }
        private async void btnUpdateModelo_Click(object sender, System.EventArgs e)
        {
            _modeloVm.IsNewItem = false;
            await PostModelo();
        }
        #endregion


    }
}
