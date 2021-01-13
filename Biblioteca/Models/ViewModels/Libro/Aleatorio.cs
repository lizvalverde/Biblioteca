using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Biblioteca.Models.Entity;

namespace Biblioteca.Models.ViewModels.Libro
{
    public class Aleatorio
    {
        public Biblioteca.Models.Entity.Libro libro { get; set; }
        public List<TablaSinSentido> listaSinSentido { get; set; }

        
    }
}