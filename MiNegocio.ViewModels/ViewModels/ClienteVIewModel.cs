using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Services;
using MiNegocio.Services.Services_interfaces;
using MiNegocio.ViewModels.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiNegocio.ViewModels.ViewModels
{
    public class ClienteVIewModel : BaseViewModel.BaseViewModel
    {
        #region Members Variables
        private readonly IClienteService<Tbcliente> _service;
        #endregion 

        #region Constructor
        public ClienteVIewModel()
        {
            _service = new ClienteService();
        }
        #endregion

        #region Private Methods       
        private void GetById()
        {
            try
            {
                Cliente = List.Where(x => x.DocId.Equals(DocId) || x.Nombres.Equals(Nombres))
                    .FirstOrDefault();
                if (Cliente != null)                
                    IsEnabled = false;                
                else               
                    IsEnabled = true;
                
            }
            catch (Exception ex)
            {
                Msj = ex.Message;
            }
        }
        private async Task GetClientes()
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
                IsVisible = false;
            }
        }
        private async Task Post()
        {
            IsBusy = true;
            Tbcliente _cliente = new Tbcliente()
            {
                DocId = DocId.Trim(),
                Nombres = Nombres,
                Apellidos = Apellidos,
                Direccion = Direccion,
                Telefono = Telefono,
                TelAlternativo = TelAlternativo,
                Email = Email,
                Fecha = Fecha.Date,
                Estado = 1
            };
            try
            {
                IsSaved = await _service.Post(_cliente, IsNewItem);
                if (IsSaved)
                {
                    Clear();
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
                    Msj = RestService<Tbcliente>.ErrorRestService;
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
        private async Task GetEquiposxCliente()
        {
            IsBusy = true;
            Tbcliente _cliente = new Tbcliente()
            {
                DocId = DocId
            };
            try
            {
                var query = await _service.RptEquiposxCliente(_cliente);
                foreach (var item in query)
                {
                   var equipos = item.Tbequipo.ToList();
                   EquiposxCliente = equipos;
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
        private void Clear()
        {
            DocId = string.Empty;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            TelAlternativo = string.Empty;
            Email = string.Empty;
            Fecha = DateTime.Today;
            Estado = default;
        }
        #endregion

        #region Properties
        private string docId;

        public string DocId
        {
            get => docId;
            set => SetProperty(ref docId, value);
        }
        private string nombres;

        public string Nombres
        {
            get => nombres;
            set => SetProperty(ref nombres, value);
        }
        private string apellidos;

        public string Apellidos
        {
            get => apellidos;
            set => SetProperty(ref apellidos, value);
        }
        private string direccion;

        public string Direccion
        {
            get => direccion;
            set => SetProperty(ref direccion, value);
        }
        private string telefono;

        public string Telefono
        {
            get => telefono;
            set => SetProperty(ref telefono, value);
        }
        private string telAlternativo;

        public string TelAlternativo
        {
            get => telAlternativo;
            set => SetProperty(ref telAlternativo, value);
        }
        private string email;

        public string Email
        {
            get => email;
            set => SetProperty(ref email, value);
        }
        private sbyte estado;

        public sbyte Estado
        {
            get => estado;
            set => SetProperty(ref estado, value);
        }
        private DateTime fecha;

        public DateTime Fecha
        {
            get => fecha;
            set => SetProperty(ref fecha, value);
        }
        private Tbcliente cliente;

        public Tbcliente Cliente
        {
            get => cliente;
            set
            {
                if (SetProperty(ref cliente, value))
                {
                    DocId = cliente.DocId.Trim();
                    Nombres = cliente.Nombres;
                    Apellidos = cliente.Apellidos;
                    Direccion = cliente.Direccion;
                    Telefono = cliente.Telefono;
                    TelAlternativo = cliente.TelAlternativo;
                    Email = cliente.Email;
                    Estado = cliente.Estado;
                    Fecha = cliente.Fecha;
                    IsEnabled = false;
                }
            }
        }
        private IEnumerable<Tbcliente> list;

        public IEnumerable<Tbcliente> List
        {
            get => list;
            set => SetProperty(ref list, value);
        }
        private IEnumerable<Tbequipo> equiposxCliente;

        public IEnumerable<Tbequipo> EquiposxCliente
        {
            get => equiposxCliente;
            set => SetProperty(ref equiposxCliente, value);
        }

        private bool isSaved;

        public bool IsSaved
        {
            get => isSaved;
            set => SetProperty(ref isSaved, value);
        }

        #endregion

        #region Commands        
        public void GetByIdCmd()
        {
            GetById();
        }
        public async Task GetClientesCmd()
        {
            await GetClientes();
        }
        public async Task PostCmd()
        {
            await Post();
        }
        public async Task GetEquiposxClienteCmd()
        {
            await GetEquiposxCliente();
        }
        #endregion
    }
}
