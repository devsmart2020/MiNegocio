using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Services;
using MiNegocio.ViewModels.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiNegocio.ViewModels.ViewModels
{
    public class UsuarioViewModel : BaseViewModel.BaseViewModel
    {
        #region Members Variables
        private readonly UsuarioService _service;
        #endregion

        #region Constructor
        public UsuarioViewModel()
        {
            _service = new UsuarioService();            

        }
        #endregion

        #region Private Methods       
        private async Task GetUsuarios()
        {
            IsBusy = true;
            try
            {
                IsBusy = true;
                Usuarios = await _service.GetTs();
                if (Usuarios.Count() == 0)
                    Msj = RestService<TbUsuario>.ErrorRestService;
            }
            catch (Exception ex)
            {
                Msj = ex.Message;
            }
            finally
            {
                IsBusy = false;
            }
        }      
        public void Clean()
        {
            User = string.Empty;
            //Pass = string.Empty;           
        }
        #endregion

        #region Properties
        private string docId;
        public string DocId
        {
            get => docId;
            set => SetProperty(ref docId, value);
        }

        private string user;
        public string User
        {
            get => user;
            set => SetProperty(ref user, value);
        }

        private string pass;
        public string Pass
        {
            get => Encrypt(pass);
            set => SetProperty(ref pass, value);
        }

        private TbUsuario usuario;

        public TbUsuario Usuario
        {
            get => usuario;
            set => SetProperty(ref usuario, value);
        }
        private IEnumerable<TbUsuario> usuarios;

        public IEnumerable<TbUsuario> Usuarios
        {
            get => usuarios;
            set => SetProperty(ref usuarios, value);
        }
        private bool isLogued;

        public bool IsLogued
        {
            get => isLogued;
            set => SetProperty(ref isLogued, value);
        }
       
        #endregion

        #region Commands
        public async Task GetUsuariosCmd()
        {
            await GetUsuarios();
        }
      
        #endregion
    }
}
