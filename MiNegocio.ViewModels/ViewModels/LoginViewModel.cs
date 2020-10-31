using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Services;
using MiNegocio.ViewModels.Properties;
using System;
using System.Threading.Tasks;

namespace MiNegocio.ViewModels.ViewModels
{
    public class LoginViewModel : BaseViewModel.BaseViewModel
    {
        #region Members Variables
        private readonly LoginService _service;
        #endregion

        #region Constructor
        public LoginViewModel()
        {
            _service = new LoginService();
        }
        #endregion

        #region Private Methos
        private protected async Task Login()
        {
            IsBusy = true;
            IsEnabled = false;
            Tbusuario usuario = new Tbusuario()
            {
                User = User,
                Pass = Pass,
            };
            try
            {
                if (usuario != null)
                {
                    Usuario = await _service.Login(usuario);
                    if (Usuario != null)
                    {                        
                        UserLogued = Usuario;
                        IsLogued = true;
                        Msj = $"{Resources.MsjLoginSucess} {Usuario.Nombres} {Usuario.Apellidos}";
                    }
                    else
                    {
                        IsLogued = false;
                        Pass = string.Empty;
                        Msj = RestService<Tbusuario>.ErrorRestService;
                    }
                }
                else
                {
                    Msj = Resources.MsjErrorFields;
                }
            }
            catch (Exception ex)
            {
                IsLogued = false;
                Msj = ex.Message;
            }
            finally
            {
                IsVisible = false;
                IsBusy = false;
                IsEnabled = true;
            }
        }
        public void Clean()
        {
            User = string.Empty;
            Pass = string.Empty;
        }
        #endregion

        #region Properties
        private string user;
        public string User
        {
            get => user;
            set => SetProperty(ref user, value);
        }

        private string pass;
        public string Pass
        {
            get => pass;
            set => SetProperty(ref pass, value);
        }
        private string token;

        public string Token
        {
            get => token;
            set => SetProperty(ref token, value);
        }
        private Tbusuario usuario;

        public Tbusuario Usuario
        {
            get => usuario;
            set => SetProperty(ref usuario, value);
        }
        private bool isLogued;

        public bool IsLogued
        {
            get => isLogued;
            set => SetProperty(ref isLogued, value);
        }
        #endregion

        #region Commands
        public async Task LoginCmd()
        {
            await Login();
        }
        public static Tbusuario UserLogued { get; set; }
        #endregion
    }
}
