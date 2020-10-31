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
        private protected LoginViewModel _service;
        #endregion

        #region Constructor
        public frmLogin()
        {
            InitializeComponent();
            _service = new LoginViewModel();
            Binding();
        }
        #endregion

        #region Private Methods
        private protected void Binding()
        {
            txtUser.DataBindings.Add(Resources.BindingText, _service, Resources.PropUser,true, DataSourceUpdateMode.OnPropertyChanged);
            txtUser.DataBindings.Add(Resources.BindingEnabled, _service, Resources.PropIsEnabled,true, DataSourceUpdateMode.OnPropertyChanged);
            txtPass.DataBindings.Add(Resources.BindingText, _service, Resources.PropPass,true, DataSourceUpdateMode.OnPropertyChanged);
            txtPass.DataBindings.Add(Resources.BindingEnabled, _service, Resources.PropIsEnabled,true, DataSourceUpdateMode.OnPropertyChanged);
            pbLoad.DataBindings.Add(Resources.BindingVisible, _service, Resources.PropIsBusy,true, DataSourceUpdateMode.OnPropertyChanged);
            btnLogin.DataBindings.Add(Resources.BindingEnabled, _service, Resources.PropIsEnabled,true, DataSourceUpdateMode.OnPropertyChanged);
        }
        private protected bool ValidateFields()
        {
            bool noError = false;
            if (string.IsNullOrEmpty(txtUser.Text))
            {
                errorLogin.SetError(txtUser, Resources.MsjValidateField);
                noError = false;
            }
            else if (string.IsNullOrEmpty(txtPass.Text))
            {
                errorLogin.SetError(txtUser, Resources.MsjValidateField);
                noError = false;
            }
            else
            {
                noError = true;
                errorLogin.Clear();
            }
            return noError;
        }
        private protected async Task Login()
        {
            if (ValidateFields())
            {
                await _service.LoginCmd();
                if (_service.IsLogued)
                {
                    using (MsjOk _msjOk = new MsjOk(_service.Msj))
                    {
                        _msjOk.ShowDialog();
                    }
                    this.Hide();
                    frmMain main = new frmMain();
                    main.Show();
                    _service.Clean();
                }
                else if (_service.IsLogued == false)
                {
                    using (MsjFail _msjFail = new MsjFail(_service.Msj))
                    {
                        _msjFail.ShowDialog();
                    }
                }
            }            
        }
        #endregion

        #region Events
        private async void btnLogin_Click(object sender, System.EventArgs e)
        {
            await Login();
        }
        private void btnClose_Click(object sender, System.EventArgs e)
        {
            Application.Exit();
        }        private async void txtPass_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                await Login();
            }
        }
        #endregion


    }
}
