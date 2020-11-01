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
    public class ModeloViewModel : BaseViewModel.BaseViewModel
    {
        #region Members Variables
        private readonly IModeloService<Tbmodelo> _service;
        #endregion

        #region Constructor
        public ModeloViewModel()
        {
            _service = new ModeloService();
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
            Tbmodelo _tipoequipo = new Tbmodelo()
            {
                IdModelo = IdModelo,
                Modelo = Nombre,
                Marca = IdMarca,
                TipoEquipo = IdTipoEquipo               
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
                    Msj = RestService<Tbmodelo>.ErrorRestService;
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
        private int idModelo;

        public int IdModelo
        {
            get => idModelo;
            set => SetProperty(ref idModelo, value);
        }
        private string nombre;

        public string Nombre
        {
            get => nombre;
            set => SetProperty(ref nombre, value);
        }
        private int idMarca;

        public int IdMarca
        {
            get => idMarca;
            set => SetProperty(ref idMarca, value);
        }
        private int idTipoEquipo;

        public int IdTipoEquipo
        {
            get => idTipoEquipo;
            set => SetProperty(ref idTipoEquipo, value);
        }
        private Tbmodelo modelo;

        public Tbmodelo Modelo
        {
            get => modelo;
            set
            {
                if (SetProperty(ref modelo, value))
                {
                    IdModelo = modelo.IdModelo;
                    Nombre = modelo.Modelo;
                    IdMarca = modelo.Marca;
                    IdTipoEquipo = modelo.TipoEquipo;
                    IsEnabled = false;
                }
            }
        }
        private IEnumerable<Tbmodelo> list;

        public IEnumerable<Tbmodelo> List
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
