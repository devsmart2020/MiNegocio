using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Services;
using MiNegocio.ViewModels.Properties;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MiNegocio.ViewModels.ViewModels
{
    public class UsuarioViewModel : BaseViewModel.BaseViewModel
    {
        #region Members Variables
        private readonly UsuarioService _service;
        #endregion

        #region Constructor
        public UsuarioViewModel()
        {
            _service = new UsuarioService();            

        }
        #endregion

        #region Private Methods       
        private async Task Gets()
        {
            IsBusy = true;
            try
            {
                List = await _service.GetTs();
                if (List == null)
                    Msj = RestService<Tbusuario>.ErrorRestService;
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
            Tbusuario _usuario = new Tbusuario()
            {
                DocId = DocId.Trim(),
                Nombres = Nombres,
                Apellidos = Apellidos,
                Direccion = Direccion,
                Telefono = Telefono,
                User = User.Trim(),
                Pass = Pass.Trim(),
                IdPerfil = IdPerfil,
                Fecha = Fecha.Date,
                Estado = Estado
            };
            try
            {
                IsSaved = await _service.Post(_usuario, IsNewItem);
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
        public void Clear()
        {
            DocId = string.Empty;
            Nombres = string.Empty;
            Apellidos = string.Empty;
            Direccion = string.Empty;
            Telefono = string.Empty;
            User = string.Empty;
            Pass = string.Empty;
            IdPerfil = default;            
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
        private int idPerfil;

        public int IdPerfil
        {
            get => idPerfil;
            set => SetProperty(ref idPerfil, value);
        }

        private string user;
        public string User
        {
            get => user;
            set => SetProperty(ref user, value);
        }

        private string pass;
        public string Pass
        {
            get => pass;
            set => SetProperty(ref pass, value);
        }

        private Tbusuario usuario;

        public Tbusuario Usuario
        {
            get => usuario;
            set => SetProperty(ref usuario, value);
        }
        private IEnumerable<Tbusuario> list;

        public IEnumerable<Tbusuario> List
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
