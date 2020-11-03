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
    public class OrdenViewModel : BaseViewModel.BaseViewModel
    {
        #region Members Variables
        private readonly IOrdenService<Tborden> _service;
        #endregion

        #region Constructor
        public OrdenViewModel()
        {
            _service = new OrdenService();
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
            Tborden _orden = new Tborden()
            {
                FechaEntra = FechaEntra,
                FechaRevision = FechaRevisa,
                FechaSale = FechaSale,
                IdCliente = IdCliente,
                IdEquipo = IdEquipo,
                IdEstadoOrden = IdEstadoOrden,
                MicroSd = MicroSD,
                Sim = Sim,
                DatosBloqueo = DatoBloqueo,
                DiagnosticoCliente = DiagCliente,
                DiagnosticoTecnico = DiagTecnico,
                Ubicacion = Ubicacion,
                IdUsuario = LoginViewModel.UserLogued.DocId
            };
            try
            {

                IsSaved = await _service.Post(_orden, IsNewItem);
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
                    Clear();
                }
                else
                {
                    Msj = RestService<Tbequipo>.ErrorRestService;
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
            IdEquipo = default;
            IdEstadoOrden = default;
            MicroSD = default;
            Sim = default;
            DatoBloqueo = string.Empty;
            DiagCliente = string.Empty;
            DiagTecnico = string.Empty;
            Ubicacion = string.Empty;
            IdUsuario = string.Empty;
        }
        #endregion

        #region Properties
        private int idOrden;

        public int IdOrden
        {
            get => idOrden;
            set => SetProperty(ref idOrden, value);
        }
        private DateTime fechaEntra = DateTime.Now;

        public DateTime FechaEntra
        {
            get => fechaEntra;
            set => SetProperty(ref fechaEntra, value);
        }
        private DateTime fechaRevisa;

        public DateTime FechaRevisa
        {
            get => fechaRevisa;
            set => SetProperty(ref fechaRevisa, value);
        }
        private DateTime fechaSale;

        public DateTime FechaSale
        {
            get => fechaSale;
            set => SetProperty(ref fechaSale, value);
        }
        private string idCliente;

        public string IdCliente
        {
            get => idCliente;
            set => SetProperty(ref idCliente, value);
        }
        private int idEquipo;

        public int IdEquipo
        {
            get => idEquipo;
            set => SetProperty(ref idEquipo, value);
        }
        private int idEstadoOrden;

        public int IdEstadoOrden
        {
            get => idEstadoOrden;
            set => SetProperty(ref idEstadoOrden, value);
        }
        private sbyte microSD;

        public sbyte MicroSD
        {
            get => microSD;
            set => SetProperty(ref microSD, value);
        }
        private sbyte sim;

        public sbyte Sim
        {
            get => sim;
            set => SetProperty(ref sim, value);
        }
        private string datoBloqueo;

        public string DatoBloqueo
        {
            get => datoBloqueo;
            set => SetProperty(ref datoBloqueo, value);
        }
        private string diagCliente;

        public string DiagCliente
        {
            get => diagCliente;
            set => SetProperty(ref diagCliente, value);
        }
        private string diagTecnico;

        public string DiagTecnico
        {
            get => diagTecnico;
            set => SetProperty(ref diagTecnico, value);
        }
        private string ubicacion;

        public string Ubicacion
        {
            get => ubicacion;
            set => SetProperty(ref ubicacion, value);
        }
        private string idUsuario;

        public string IdUsuario
        {
            get => idUsuario;
            set => SetProperty(ref idUsuario, value);
        }
        private string idTecnico;

        public string IdTecnico
        {
            get => idTecnico;
            set => SetProperty(ref idTecnico, value);
        }
        private Tborden orden;

        public Tborden Orden
        {
            get => orden;
            set => SetProperty(ref orden, value);
        }
        private IEnumerable<Tborden> list;

        public IEnumerable<Tborden> List
        {
            get { return list; }
            set { list = value; }
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
