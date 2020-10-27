using MiNegocio.Desktop.Masters;
using MiNegocio.Desktop.Properties;
using MiNegocio.ViewModels.ViewModels;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MiNegocio.Desktop.Views
{
    public partial class frmLogin : Form
    {
        #region Members Variables
        private protected UsuarioViewModel _usuarioVm;
        #endregion

        #region Constructor
        public frmLogin()
        {
            InitializeComponent();
            _usuarioVm = new UsuarioViewModel();
            Binding();
        }
        #endregion

        #region Private Methods
        private protected void Binding()
        {
            txtUser.DataBindings.Add(Resources.BindingText, _usuarioVm, Resources.PropUser, 
                true, DataSourceUpdateMode.OnPropertyChanged);
            txtUser.DataBindings.Add(Resources.BindingEnabled, _usuarioVm, Resources.PropIsEnabled,
               true, DataSourceUpdateMode.OnPropertyChanged);
            txtPass.DataBindings.Add(Resources.BindingText, _usuarioVm, Resources.PropPass,
                true, DataSourceUpdateMode.OnPropertyChanged);
            txtPass.DataBindings.Add(Resources.BindingEnabled, _usuarioVm, Resources.PropIsEnabled,
                true, DataSourceUpdateMode.OnPropertyChanged);
            pbLoad.DataBindings.Add(Resources.BindingVisible, _usuarioVm, Resources.PropIsBusy,
                true, DataSourceUpdateMode.OnPropertyChanged);
            pbSuccess.DataBindings.Add(Resources.BindingVisible, _usuarioVm, Resources.PropIsVisible,
                true, DataSourceUpdateMode.OnPropertyChanged);
            btnLogin.DataBindings.Add(Resources.BindingEnabled, _usuarioVm, Resources.PropIsEnabled,
               true, DataSourceUpdateMode.OnPropertyChanged);
        }        
        private protected async Task Login()
        {
            await _usuarioVm.LoginCmd();
            if (_usuarioVm.IsLogued)
            {
                using (frmMain main = new frmMain())
                {
                    this.Hide();
                    _usuarioVm.Clean();
                    main.Show();
                }
            }
            else if (_usuarioVm.IsLogued == false)
            {
                using (MsjFail _msjFail = new MsjFail(_usuarioVm.Msj))
                {
                    _msjFail.ShowDialog();
                }
            }
        }
        #endregion

        #region Events

        #endregion

        private async void btnLogin_Click(object sender, System.EventArgs e)
        {
            await Login();
        }
       
    }
}
