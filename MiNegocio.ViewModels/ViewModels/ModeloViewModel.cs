﻿using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Services;
using MiNegocio.Services.Services_interfaces;
using MiNegocio.ViewModels.Helpers;
using MiNegocio.ViewModels.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiNegocio.ViewModels.ViewModels
{
    public class ModeloViewModel : BaseViewModel.BaseViewModel
    {
        #region Members Variables
        private readonly IModeloService<ModeloDTO> _service;
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
                List = await _service.GetTs(IsDbQuery, LocalDataRepository.Path, Resources.JsonModelos);
                if (List == null)
                {
                    Msj = RestService<ModeloDTO>.ErrorRestService;
                }
                else
                {
                    LocalDataRepository.RoutesPath();
                    LocalDataRepository.CreateJsonData(list, Resources.JsonModelos);
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
        private void GetCmbModelo()
        {
            CmbModelo = List.Where(x => x.TipoEquipo == IdTipoEquipo && x.Marca == IdMarca)
                .ToList();
        }
        private async Task Post()
        {
            IsBusy = true;
            ModeloDTO _modelo = new ModeloDTO()
            {
                IdModelo = IdModelo,
                Modelo = Nombre,
                Marca = IdMarca,
                TipoEquipo = IdTipoEquipo
            };
            try
            {
                IsSaved = await _service.Post(_modelo, IsNewItem);
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
                    Msj = RestService<ModeloDTO>.ErrorRestService;
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
        private ModeloDTO modelo;

        public ModeloDTO Modelo
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
        private IEnumerable<ModeloDTO> list;

        public IEnumerable<ModeloDTO> List
        {
            get => list;
            set => SetProperty(ref list, value);
        }
        private IEnumerable<ModeloDTO> cmbModelo;

        public IEnumerable<ModeloDTO> CmbModelo
        {
            get => cmbModelo;
            set => SetProperty(ref cmbModelo, value);
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
        public void GetCmbModeloCmd()
        {
            GetCmbModelo();
        }
        public async Task PostCmd()
        {
            await Post();
        }
        #endregion
    }
}
