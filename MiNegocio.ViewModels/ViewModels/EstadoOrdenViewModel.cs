using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Services;
using MiNegocio.Services.Services_interfaces;
using MiNegocio.ViewModels.Helpers;
using MiNegocio.ViewModels.Properties;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.ViewModels.ViewModels
{
    public class EstadoOrdenViewModel : BaseViewModel.BaseViewModel
    {
        #region Members Variables
        private readonly IEstadoOrdenService<EstadoOrdenDTO> _service;
        #endregion

        #region Constructor
        public EstadoOrdenViewModel()
        {
            _service = new EstadoOrdenService();
        }
        #endregion

        #region Private Methods
        private async Task Gets()
        {
            IsBusy = true;
            try
            {
                List = await _service.GetTs(IsDbQuery, LocalDataRepository.Path, Resources.JsonEstadoOrden);
                if (List == null)
                {
                    Msj = RestService<EstadoOrdenDTO>.ErrorRestService;
                }
                else
                {
                    LocalDataRepository.RoutesPath();
                    LocalDataRepository.CreateJsonData(list, Resources.JsonEstadoOrden);
                }
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
        private int idEstadoOrden;

        public int IdEstadoOrden
        {
            get => idEstadoOrden;
            set => SetProperty(ref idEstadoOrden, value);
        }
        private string nombre;

        public string Nombre
        {
            get => nombre;
            set => SetProperty(ref nombre, value);
        }
        private IEnumerable<EstadoOrdenDTO> list;

        public IEnumerable<EstadoOrdenDTO> List
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
