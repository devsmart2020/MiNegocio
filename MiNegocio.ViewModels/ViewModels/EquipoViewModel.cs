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
    public class EquipoViewModel : BaseViewModel.BaseViewModel
    {
        #region Members Variables
        private protected readonly IEquipoService<EquipoDTO> _service;
        #endregion

        #region Constructor
        public EquipoViewModel()
        {
            _service = new EquipoService();
        }
        #endregion

        #region Private Methods
        private async Task Gets()
        {
            IsBusy = true;
            try
            {
                List = await _service.GetTs(IsDbQuery, LocalDataRepository.Path, Resources.JsonEquipos);
                if (List == null)
                {
                    Msj = RestService<EquipoDTO>.ErrorRestService;
                }
                else
                {
                    LocalDataRepository.RoutesPath();
                    LocalDataRepository.CreateJsonData(list, Resources.JsonEquipos);
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
            EquipoDTO _equipo = new EquipoDTO()
            {
               Fecha = DateTime.Now,
               IdCliente = IdCliente.Trim(),
               IdModelo = IdModelo,
               Serie = Serie,
               Imei1 = Imei1,
               Imei2 = Imei2,
               Color = Color,
               Observacion = Observacion
            };
            try
            {
                IsSaved = await _service.Post(_equipo, IsNewItem);
                if (IsSaved)
                {
                    IsDbQuery = true;
                    await Gets();
                    if (IsNewItem)
                    {
                        Msj = Resources.MsjSaveOk;
                    }
                    else
                    {
                        Msj = Resources.MsjUpdateOk;
                    }
                    Clear();
                }
                else
                {
                    Msj = RestService<EquipoDTO>.ErrorRestService;
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
        private void Clear()
        {
            IdCliente = string.Empty;
            IdModelo = default;
            Serie = string.Empty;
            Imei1 = string.Empty;
            Imei2 = string.Empty;
            Color = string.Empty;
            Observacion = string.Empty;
        }
        #endregion

        #region Properties
        private int idEquipo;

        public int IdEquipo
        {
            get => idEquipo;
            set => SetProperty(ref idEquipo, value);
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get => fecha;
            set => SetProperty(ref fecha, value);
        }
        private string idCliente;

        public string IdCliente
        {
            get => idCliente;
            set => SetProperty(ref idCliente, value);
        }
        private int idTipoEquipo;

        public int IdTipoEquipo
        {
            get => idTipoEquipo;
            set => SetProperty(ref idTipoEquipo, value);
        }

        private string tipoEquipo;

        public string TipoEquipo
        {
            get => tipoEquipo;
            set => SetProperty(ref tipoEquipo, value);
        }

        private int idMarca;

        public int IdMarca
        {
            get => idMarca;
            set => SetProperty(ref idMarca, value);
        }

        private string marca;

        public string Marca
        {
            get => marca;
            set => SetProperty(ref marca, value);
        }

        private int idModelo;

        public int IdModelo
        {
            get => idModelo;
            set => SetProperty(ref idModelo, value);
        }
        private string modelo;

        public string Modelo
        {
            get => modelo;
            set => SetProperty(ref modelo, value);
        }

        private string serie;

        public string Serie
        {
            get => serie;
            set => SetProperty(ref serie, value);
        }
        private string imei1;

        public string Imei1
        {
            get => imei1;
            set => SetProperty(ref imei1, value);
        }
        private string imei2;

        public string Imei2
        {
            get => imei2;
            set => SetProperty(ref imei2, value);
        }
        private string color;

        public string Color
        {
            get => color;
            set => SetProperty(ref color, value);
        }
        private string observacion;

        public string Observacion
        {
            get => observacion;
            set => SetProperty(ref observacion, value);
        }
        private EquipoDTO equipo;

        public EquipoDTO Equipo
        {
            get => equipo;
            set { if (SetProperty(ref equipo, value))
                {
                    IdEquipo = equipo.IdEquipo;
                    Fecha = equipo.Fecha;
                    IdCliente = equipo.IdCliente;
                    IdTipoEquipo = equipo.IdTipoEquipo;
                    TipoEquipo = equipo.TipoEquipo;
                    IdMarca = equipo.IdMarca;
                    Marca = equipo.Marca;
                    IdModelo = equipo.IdModelo;
                    Modelo = equipo.Modelo;
                    Serie = equipo.Serie;
                    Imei1 = equipo.Imei1;
                    Imei2 = equipo.Imei2;
                    Color = equipo.Color;
                    Observacion = equipo.Observacion;
                } 
            }
        }
        private IEnumerable<EquipoDTO> list;

        public IEnumerable<EquipoDTO> List
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
        public async Task PostCmd()
        {
            await Post();
        }
        public async Task GetsCmd() => await Gets();
            
        #endregion
    }
}
