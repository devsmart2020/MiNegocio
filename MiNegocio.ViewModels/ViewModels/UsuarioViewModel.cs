﻿using MiNegocio.Models.Models;
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
        private async Task Login()
        {
            IsBusy = true;
            IsEnabled = false;
            TbUsuario usuario = new TbUsuario()
            {
                User = User,
                Pass = Pass,
            };
            try
            {
                if (usuario != null)
                {
                    Usuario = await _service.Login(usuario);
                    if (!string.IsNullOrEmpty(Usuario.DocId))
                    {
                        IsLogued = true;                        
                        Msj = $"{Resources.MsjLoginSucess}{Usuario.Nombres + Usuario.Apellidos}";
                    }
                    else
                    {
                        IsLogued = false;
                        Msj = RestService<TbUsuario>.ErrorRestService;
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
        public async Task LoginCmd()
        {
            await Login();
        }
        #endregion
    }
}