using MiNegocio.ViewModels.Helpers;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiNegocio.Desktop.Views
{
    public partial class frmSplash : Form
    {
        #region Members Variables
        
        #endregion

        #region Constructor
        public frmSplash()
        {
            InitializeComponent();
        }
        #endregion

        #region Private Methods
        private void Login()
        {
            frmLogin frmLogin = new frmLogin();
            this.Hide();
            frmLogin.ShowDialog();
        }
        private async Task LoadData()
        {
            await LocalDataRepository.LoadData();
            Login();
        }
        #endregion

        #region Events
        private async void frmSplash_Shown(object sender, System.EventArgs e)
        {
            await LoadData();
        }
        #endregion

    }
}
