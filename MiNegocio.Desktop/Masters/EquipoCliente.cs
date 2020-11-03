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
        #endregion

        #region Events

        #endregion



    }
}
