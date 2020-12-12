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
    public class MarcaViewModel : BaseViewModel.BaseViewModel
    {
        #region Members Variables
        private readonly IMarcaService<MarcaDTO> _service;
        #endregion

        #region Constructor
        public MarcaViewModel()
        {
            _service = new MarcaService();
        }
        #endregion

        #region Private Methods
        private async Task Gets()
        {
            IsBusy = true;
            try
            {
                List = await _service.GetTs(IsDbQuery, LocalDataRepository.Path, Resources.JsonMarcas);
                if (List == null)
                {
                    Msj = RestService<MarcaDTO>.ErrorRestService;
                }
                else
                {
                    LocalDataRepository.RoutesPath();
                    LocalDataRepository.CreateJsonData(list, Resources.JsonMarcas);
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
        private async Task Post()
        {
            IsBusy = true;
            MarcaDTO _marca = new MarcaDTO()
            {
                IdMarca = IdMarca,
                Marca = Nombre.Trim()
            };
            try
            {
                IsSaved = await _service.Post(_marca, IsNewItem);
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
                    Msj = RestService<MarcaDTO>.ErrorRestService;
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
        private int idMarca;

        public int IdMarca
        {
            get => idMarca;
            set => SetProperty(ref idMarca, value);
        }
        private string nombre;

        public string Nombre
        {
            get => nombre;
            set => SetProperty(ref nombre, value);
        }
        private MarcaDTO marca;

        public MarcaDTO Marca
        {
            get => marca;
            set
            {
                if (SetProperty(ref marca, value))
                {
                    IdMarca = marca.IdMarca;
                    Nombre = marca.Marca;
                    IsEnabled = false;
                }
            }
        }
        private IEnumerable<MarcaDTO> list;

        public IEnumerable<MarcaDTO> List
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
