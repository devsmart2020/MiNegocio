using MiNegocio.ViewModels.Properties;
using MiNegocio.ViewModels.ViewModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Threading.Tasks;

namespace MiNegocio.ViewModels.Helpers
{
    public static class LocalDataRepository
    {
        #region Members Variables
        private static readonly ClienteVIewModel _clienteVm = new ClienteVIewModel();
        private static readonly EquipoViewModel _equipoVm = new EquipoViewModel();
        private static readonly EstadoOrdenViewModel _estadoOrdenVm = new EstadoOrdenViewModel();
        private static readonly MarcaViewModel _marcaVm = new MarcaViewModel();
        private static readonly ModeloViewModel _modeloVm = new ModeloViewModel();
        private static readonly OrdenViewModel _ordenVm = new OrdenViewModel();
        private static readonly TipoEquipoViewModel _tipoEquipoVm = new TipoEquipoViewModel();
        private static readonly UsuarioViewModel _usuarioVm = new UsuarioViewModel();
        private static int NumIntentos { get; set; } = 2;
        private static int NumArchivos { get; set; }
        private static int NumArchivosExisten { get; set; } = 8;
        #endregion

        #region Private Methods        
        internal static void RoutesPath()
        {
            //Creamos los directorios que necesitamos
            Val = ConfigurationManager.AppSettings[Resources.ConfigLocalPath];
            Path = Environment.ExpandEnvironmentVariables(Val);
            NumArchivos = Directory.GetFiles(Path).Length;
            
            try
            {
                if (Directory.Exists(Path) && NumArchivos < NumArchivosExisten)
                {
                    return;
                }
                else
                {
                    try
                    {
                        DirectoryInfo jsons = Directory.CreateDirectory(Path);
                    }
                    catch (Exception ex)
                    {
                        Msj = ex.Message;
                    }
                }
            }
            catch (Exception ex)
            {
                Msj = ex.Message;
            }
        }

        internal static void CreateJsonData(IEnumerable<dynamic> list, string fileName)
        {
            try
            {
                int count = 0;
                while (NumArchivos < NumArchivosExisten && count < NumArchivosExisten)
                {
                    using (StreamWriter file = File.CreateText($"{Path}{fileName}"))
                    {
                        JsonSerializer serializer = new JsonSerializer();
                        serializer.Serialize(file, list);
                    }
                    count++;
                }
                //var read = File.ReadAllText($"{Path}{Resources.JsonClientes}"); //Se lee la data del json
                //IEnumerable<dynamic> localList = JsonConvert.DeserializeObject<IEnumerable<dynamic>>(read);
            }
            catch (Exception ex)
            {
                Msj = ex.Message;
            }
        }
        
        public static async Task LoadData()
        {
            int count = 0;            
            while (_clienteVm.List == null)
            {
                _clienteVm.IsDbQuery = true;
                await _clienteVm.GetClientesCmd();
                count++;
                if (count == NumIntentos && _clienteVm.List == null)
                {
                    Console.WriteLine("No se cargó Cliente");
                    break;
                }
            }
            while (_equipoVm.List == null)
            {
                _equipoVm.IsDbQuery = true;
                await _equipoVm.GetsCmd();
                count++;
                if (count == NumIntentos && _equipoVm.List == null)
                {
                    Console.WriteLine("No se cargó Equipo");
                    break;
                }

            }
            while (_estadoOrdenVm.List == null)
            {
                _estadoOrdenVm.IsDbQuery = true;
                await _estadoOrdenVm.GetsCmd();
                count++;
                if (count == NumIntentos && _estadoOrdenVm.List == null)
                {
                    Console.WriteLine("No se cargó EstadoOrden");
                    break;
                }

            }
            while (_marcaVm.List == null)
            {
                _marcaVm.IsDbQuery = true;
                await _marcaVm.GetsCmd();
                count++;
                if (count == NumIntentos && _marcaVm.List == null)
                {
                    Console.WriteLine("No se cargó Marca");
                    break;
                }

            }
            while (_modeloVm.List == null)
            {
                _modeloVm.IsDbQuery = true;
                await _modeloVm.GetsCmd();
                count++;
                if (count == NumIntentos && _modeloVm.List == null)
                {
                    Console.WriteLine("No se cargó Modelo");
                    break;
                }

            }
            while (_tipoEquipoVm.List == null)
            {
                _tipoEquipoVm.IsDbQuery = true;
                await _tipoEquipoVm.GetsCmd();
                count++;
                if (count == NumIntentos && _tipoEquipoVm.List == null)
                {
                    Console.WriteLine("No se cargó TipoEquipo");
                    break;
                }
            }
            while(_usuarioVm.Tecnicos == null)
            {
                _usuarioVm.IsDbQuery = true;
                await _usuarioVm.GetTecnicosCmd();
                count++;
                if (count == NumIntentos && _usuarioVm.Tecnicos == null)
                {
                    Console.WriteLine("No se cargó Técnicos");
                    break;
                }                   
            }
            while (_ordenVm.List == null)
            {
                _ordenVm.IsDbQuery = true;
                await _ordenVm.GetsCmd();
                count++;
                if (count == NumIntentos && _ordenVm.List == null)
                {
                    Console.WriteLine("No se cargó Ordenes");
                    break;
                }
            }
        }
        #endregion      

        #region Public Properties      
        public static string Val { get; set; }
        public static string Path { get; set; }
        public static string Msj { get; set; }
        

        #endregion

    }
}
