using MiNegocio.Models.Models;
using MiNegocio.Services.Services;
using MiNegocio.Services.Services_interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.ViewModels.ViewModels
{
    public class PerfilViewModel : BaseViewModel.BaseViewModel
    {
        #region Members Variables
        private readonly IPerfilService<PerfilDTO> _service;
        #endregion

        #region Constructor
        public PerfilViewModel()
        {
            _service = new PerfilService();
        }
        #endregion

        #region Private Methods
        private async Task Gets()
        {
            IsBusy = true;
            try
            {
                List = await _service.GetTs();
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
        #endregion

        #region Properties
        private int idPerfil;

        public int IdPerfil
        {
            get => idPerfil;
            set => SetProperty(ref idPerfil, value);
        }
        private string nombre;

        public string Nombre
        {
            get => nombre;
            set => SetProperty(ref nombre, value);
        }
        private PerfilDTO perfil;

        public PerfilDTO Perfil
        {
            get => perfil;
            set => SetProperty(ref perfil, value);
        }
        private IEnumerable<PerfilDTO> list;

        public IEnumerable<PerfilDTO> List
        {
            get => list;
            set => SetProperty(ref list, value);
        }

        #endregion

        #region Commands
        public async Task GetsCmd()
        {
            await Gets();
        }
        #endregion
    }
}
