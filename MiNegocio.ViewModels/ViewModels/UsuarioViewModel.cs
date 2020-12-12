using MiNegocio.Models.Models;
using MiNegocio.Services.Data;
using MiNegocio.Services.Services;
using MiNegocio.ViewModels.Helpers;
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
                    Msj = RestService<UsuarioDTO>.ErrorRestService;
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
            UsuarioDTO _usuario = new UsuarioDTO()
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
                    Msj = RestService<ClienteDTO>.ErrorRestService;
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
        private async Task GetTecnicos()
        {
            IsBusy = true;
            try
            {
                if (IsDbQuery)
                {
                    Tecnicos = await _service.GetTecnicos(IsDbQuery, LocalDataRepository.Path, Resources.JsonTecnicos);
                    if (Tecnicos == null)
                    {
                        Msj = RestService<UsuarioDTO>.ErrorRestService;
                    }
                    else
                    {
                        LocalDataRepository.RoutesPath();
                        LocalDataRepository.CreateJsonData(tecnicos, Resources.JsonTecnicos);
                    }
                }
                else
                {                   
                    Tecnicos = await _service.GetTecnicos(IsDbQuery, LocalDataRepository.Path, Resources.JsonTecnicos);
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
        private string nomCompleto;

        public string NomCompleto
        {
            get => nomCompleto;
            set => SetProperty(ref nomCompleto, value);
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

        private UsuarioDTO usuario;

        public UsuarioDTO Usuario
        {
            get => usuario;
            set
            {
                if (SetProperty(ref usuario, value))
                {
                    DocId = usuario.DocId;
                    Nombres = usuario.Nombres;
                    Apellidos = usuario.Apellidos;
                    Direccion = usuario.Direccion;
                    Telefono = usuario.Telefono;
                    Estado = usuario.Estado;
                    IdPerfil = usuario.IdPerfil;
                    User = usuario.User;
                    Pass = usuario.Pass;
                    IsEnabled = false;
                }
            }
        }
        private IEnumerable<UsuarioDTO> list;

        public IEnumerable<UsuarioDTO> List
        {
            get => list;
            set => SetProperty(ref list, value);  
        }
        private IEnumerable<UsuarioDTO> tecnicos;

        public IEnumerable<UsuarioDTO> Tecnicos
        {
            get => tecnicos;
            set => SetProperty(ref tecnicos, value);
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
        public async Task GetTecnicosCmd()
        {
            await GetTecnicos();
        }
        #endregion
    }
}
