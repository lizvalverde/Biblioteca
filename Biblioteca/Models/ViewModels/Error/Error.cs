using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Biblioteca.Models.ViewModels.Error
{
    public class Error
    {
       
        public url direccion { get;set;}   
        public Exception excepcion { get; set; }
    }
    public struct url
    {
        public string controlador;
        public string accion;

    }
}