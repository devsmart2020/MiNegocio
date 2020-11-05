using MiNegocio.Models.Models;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MiNegocio.Desktop.Masters
{
    public partial class frmEquipoCliente : Form
    {
        #region Members Variables
        private IEnumerable<Tbequipo> Equipos { get; set; }
        #endregion

        #region Constructor
        public frmEquipoCliente(IEnumerable<Tbequipo> equipos)
        {
            InitializeComponent();
            Equipos = equipos;
            Binding();
        }
        #endregion

        #region Private Methods
        private void Binding()
        {
            dgvEquipos.DataSource = Equipos;
            if (Equipos != null)
            {
                dgvEquipos.Columns[0].Visible = false;
                dgvEquipos.Columns[5].Visible = false;
                dgvEquipos.Columns[9].Visible = false;
            }
        }
        private void SelectedEquipo()
        {
            var equipo = dgvEquipos.SelectedItem;
            EquipoSeleccionado = (Tbequipo)equipo;            
            if (EquipoSeleccionado == null)
            {
                Close();
            }
            Close();
        }

        #endregion

        #region Events
        private void dgvEquipos_CellDoubleClick(object sender, Syncfusion.WinForms.DataGrid.Events.CellClickEventArgs e)
        {
            SelectedEquipo();
        }
        #endregion

        public Tbequipo EquipoSeleccionado { get; set; }

    }
}
