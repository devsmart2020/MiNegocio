using MiNegocio.Models.Models;
using MiNegocio.Services.Services;
using MiNegocio.Services.Services_interfaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;
using MiNegocio.ViewModels.Properties;
using MiNegocio.Services.Data;

namespace MiNegocio.ViewModels.ViewModels
{
    public class TipoEquipoViewModel : BaseViewModel.BaseViewModel
    {
        #region Members Variables
        private readonly ITipoEquipoService<Tbtipoequipo> _service;
        #endregion

        #region Constructor
        public TipoEquipoViewModel()
        {
            _service = new TipoEquipoService();
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
        private async Task Post()
        {
            IsBusy = true;
            Tbtipoequipo _tipoequipo = new Tbtipoequipo()
            {
               IdTipoEquipo = IdTipoEquipo,
               TipoEquipo = Nombre.Trim()                
            };
            try
            {
                IsSaved = await _service.Post(_tipoequipo, IsNewItem);
                if (IsSaved)
                {
                    if (IsNewItem)
                    {
                        Msj = Resources.MsjSaveOk;
                    }
                    else
                    {
                        Msj = Resources.MsjUpdateOk;
                    }
                }
                else
                {
                    Msj = RestService<Tbtipoequipo>.ErrorRestService;
                }
            }
            catch (Exception ex)
            {
                Msj = ex.Message;
            }
            finally
            {
                IsEnabled = true;
                IsBusy = false;
            }
        }
        #endregion

        #region Properties
        private int idTipoEquipo;

        public int IdTipoEquipo
        {
            get => idTipoEquipo;
            set => SetProperty(ref idTipoEquipo, value);
        }
        private string nombre;

        public string Nombre
        {
            get => nombre;
            set => SetProperty(ref nombre, value);
        }
        private Tbtipoequipo tipoEquipo;

        public Tbtipoequipo TipoEquipo
        {
            get => tipoEquipo;
            set
            {
                if (SetProperty(ref tipoEquipo, value))
                {
                    IdTipoEquipo = tipoEquipo.IdTipoEquipo;
                    Nombre = tipoEquipo.TipoEquipo;
                    IsEnabled = false;
                }
            }
        }
        private IEnumerable<Tbtipoequipo> list;

        public IEnumerable<Tbtipoequipo> List
        {
            get => list;
            set => SetProperty(ref list, value);
        }
        private bool isSaved;

        public bool IsSaved
        {
            get => isSaved;
            set => SetProperty(ref isSaved, value);
        }
        #endregion

        #region Commands
        public async Task GetsCmd()
        {
            await Gets();
        }
        public async Task PostCmd()
        {
            await Post();
        }
        #endregion
    }
}
