﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiNegocio.ViewModels.Properties {
    using System;
    
    
    /// <summary>
    ///   Clase de recurso fuertemente tipado, para buscar cadenas traducidas, etc.
    /// </summary>
    // StronglyTypedResourceBuilder generó automáticamente esta clase
    // a través de una herramienta como ResGen o Visual Studio.
    // Para agregar o quitar un miembro, edite el archivo .ResX y, a continuación, vuelva a ejecutar ResGen
    // con la opción /str o recompile su proyecto de VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "16.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Devuelve la instancia de ResourceManager almacenada en caché utilizada por esta clase.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MiNegocio.ViewModels.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Reemplaza la propiedad CurrentUICulture del subproceso actual para todas las
        ///   búsquedas de recursos mediante esta clase de recurso fuertemente tipado.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a localpath.
        /// </summary>
        internal static string ConfigLocalPath {
            get {
                return ResourceManager.GetString("ConfigLocalPath", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a clientes.json.
        /// </summary>
        internal static string JsonClientes {
            get {
                return ResourceManager.GetString("JsonClientes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a equipos.json.
        /// </summary>
        internal static string JsonEquipos {
            get {
                return ResourceManager.GetString("JsonEquipos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a estadoorden.json.
        /// </summary>
        internal static string JsonEstadoOrden {
            get {
                return ResourceManager.GetString("JsonEstadoOrden", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a marcas.json.
        /// </summary>
        internal static string JsonMarcas {
            get {
                return ResourceManager.GetString("JsonMarcas", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a modelos.json.
        /// </summary>
        internal static string JsonModelos {
            get {
                return ResourceManager.GetString("JsonModelos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a ordenes.json.
        /// </summary>
        internal static string JsonOrdenes {
            get {
                return ResourceManager.GetString("JsonOrdenes", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a tecnicos.json.
        /// </summary>
        internal static string JsonTecnicos {
            get {
                return ResourceManager.GetString("JsonTecnicos", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a tipoequipo.json.
        /// </summary>
        internal static string JsonTipoEquipo {
            get {
                return ResourceManager.GetString("JsonTipoEquipo", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Faltan datos por diligenciar, por favor verifique que tenga todos los datos diligenciados en el formulario..
        /// </summary>
        internal static string MsjErrorFields {
            get {
                return ResourceManager.GetString("MsjErrorFields", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Credenciales correctas, bienvenido/a.
        /// </summary>
        internal static string MsjLoginSucess {
            get {
                return ResourceManager.GetString("MsjLoginSucess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Datos registrados con éxito..
        /// </summary>
        internal static string MsjSaveOk {
            get {
                return ResourceManager.GetString("MsjSaveOk", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Busca una cadena traducida similar a Datos actualizados con éxito..
        /// </summary>
        internal static string MsjUpdateOk {
            get {
                return ResourceManager.GetString("MsjUpdateOk", resourceCulture);
            }
        }
    }
}
