using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Services;
using MiNegocio.Services.Services_interfaces;
using MiNegocio.ViewModels.Properties;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.ViewModels.ViewModels
{
    public class LoginViewModel : BaseViewModel.BaseViewModel
    {
        #region Members Variables
        private readonly ILoginService<UsuarioDTO> _service;
        private readonly IUsuarioService<UsuarioDTO> _usuarioService;
        #endregion

        #region Constructor
        public LoginViewModel()
        {
            _service = new LoginService();
            _usuarioService = new UsuarioService();
        }
        #endregion

        #region Private Methos
        private protected async Task Login()
        {
            IsBusy = true;
            IsEnabled = false;
            UsuarioDTO usuario = new UsuarioDTO()
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
                        IsLogued = true;
                        UserLogued = Usuario;
                        RestService<UsuarioDTO>.Token = Usuario.Token;
                        Msj = $"{Resources.MsjLoginSucess} {Usuario.Nombres} {Usuario.Apellidos}";
                    }
                    else
                    {
                        IsLogued = false;
                        Pass = string.Empty;
                        Msj = RestService<UsuarioDTO>.ErrorRestService;
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
        private UsuarioDTO usuario;

        public UsuarioDTO Usuario
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
        public static UsuarioDTO UserLogued { get; set; }
        public static IEnumerable<UsuarioDTO> Tecnicos { get; set; }
        #endregion
    }
}
