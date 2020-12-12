using MiNegocio.Models.Models;
using Syncfusion.WinForms.DataGrid.Enums;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace MiNegocio.Desktop.Masters
{
    public partial class frmBuscarCliente : Form
    {
        #region Members Variables
        private IEnumerable<ClienteDTO> Clientes { get; set; }
        private string DocId { get; set; }
        #endregion

        #region Constructor
        public frmBuscarCliente(IEnumerable<ClienteDTO> clientes, string docId)
        {
            InitializeComponent();
            Clientes = clientes;
            DocId = docId;
        }
        #endregion

        #region Private Methods
        private void GetClientes()
        {
            if (Clientes != null)
            {
                dgvCliente.DataSource = Clientes;
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
        private void Buscar()
        {
            if (!string.IsNullOrEmpty(DocId))
            {
                txtBusca.Text = DocId;
            }     
            string search = txtBusca.Text;
            if (string.IsNullOrEmpty(search))
            {
                dgvCliente.SearchController.ClearSearch();
            }
            dgvCliente.SearchController.Search(search);
            dgvCliente.SearchController.FindNext(search);
            dgvCliente.View.RefreshFilter();
        }
        #endregion

        #region Events
        private void frmBuscarCliente_Shown(object sender, System.EventArgs e)
        {
            GetClientes();
            SendKeys.Send("{A}");
            
        }
        private void txtBusca_TextChanged(object sender, System.EventArgs e)
        {
            Buscar();
        }
        private void dgvCliente_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            var cliente = dgvCliente.SelectedItem;
            ClienteSeleccionado = (ClienteDTO)cliente;
            if (ClienteSeleccionado == null)
            {
                Close();
            }
            Close();
        }
        #endregion
        public ClienteDTO ClienteSeleccionado { get; set; }

      
    }
}
