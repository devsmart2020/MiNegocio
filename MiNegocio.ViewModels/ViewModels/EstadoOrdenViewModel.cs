using MiNegocio.Models.Models;
using MiNegocio.Services.Services;
using MiNegocio.Services.Services_interfaces;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace MiNegocio.ViewModels.ViewModels
{
    public class EstadoOrdenViewModel : BaseViewModel.BaseViewModel
    {
        #region Members Variables
        private readonly IEstadoOrdenService<Tbestadoorden> _service;
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
        private IEnumerable<Tbestadoorden> list;

        public IEnumerable<Tbestadoorden> List
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
