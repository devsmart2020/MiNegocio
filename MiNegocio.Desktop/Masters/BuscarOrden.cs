using MiNegocio.Models.Models;
using MiNegocio.ViewModels.ViewModels;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiNegocio.Desktop.Masters
{
    public partial class frmBuscarOrden : Form
    {
        #region Members Variables
        private protected ClienteVIewModel _clienteVm;
        private IEnumerable<OrdenDTO> Ordenes { get; set; }
        #endregion

        #region Constructor
        public frmBuscarOrden(IEnumerable<OrdenDTO> ordenes)
        {
            InitializeComponent();
            _clienteVm = new ClienteVIewModel();
            Ordenes = ordenes;
            Binding();
        }
        #endregion

        #region Private Methods
        private void Binding()
        {
            dgvOrden.DataSource = Ordenes;
            if (Ordenes != null)
            {
                //dgvOrden.Columns[2].Visible = false;
                //dgvOrden.Columns[3].Visible = false;
                //dgvOrden.Columns[4].Visible = false;
                //dgvOrden.Columns[5].Visible = false;
                //dgvOrden.Columns[9].Visible = false;
                //dgvOrden.Columns[10].Visible = false;
                //dgvOrden.Columns[11].Visible = false;
                //dgvOrden.Columns[16].Visible = false;
                //dgvOrden.Columns[17].Visible = false;
                //dgvOrden.Columns[18].Visible = false;
                //dgvOrden.Columns[0].ShowFilterRowOptions = false;
                //dgvOrden.Columns[1].ShowFilterRowOptions = false;
                //dgvOrden.Columns[6].ShowFilterRowOptions = false;
                //dgvOrden.Columns[7].ShowFilterRowOptions = false;
                //dgvOrden.Columns[8].ShowFilterRowOptions = false;
                //dgvOrden.Columns[12].ShowFilterRowOptions = false;
                //dgvOrden.Columns[13].ShowFilterRowOptions = false;
                //dgvOrden.Columns[14].ShowFilterRowOptions = false;
                //dgvOrden.Columns[15].ShowFilterRowOptions = false;                
            }
            //Search
            dgvOrden.SearchController.AllowFiltering = true;
            dgvOrden.FilterRowPosition = RowPosition.Bottom;
        }
        private void Buscar()
        {
            string search = txtSearch.Text;
            if (string.IsNullOrEmpty(search))
            {
                dgvOrden.SearchController.ClearSearch();
            }
            dgvOrden.SearchController.Search(search);
            dgvOrden.SearchController.FindNext(search);
            dgvOrden.View.RefreshFilter();
        }
        private void SelectedOrden()
        {
            var orden = dgvOrden.SelectedItem;
            OrdenSeleccionada = (OrdenDTO)orden;
            if (OrdenSeleccionada == null)
            {
                Close();
            }
            Close();
        }
        #endregion

        #region Events
        private void txtSearch_TextChanged(object sender, System.EventArgs e)
        {
            Buscar();
        }
        #endregion
        public OrdenDTO OrdenSeleccionada { get; set; }

        private void dgvOrden_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            SelectedOrden();
        }
    }
}
