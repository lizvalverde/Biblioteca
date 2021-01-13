using Biblioteca.Models.Entity;
using Biblioteca.Models.ViewModels.Libro;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteca.Controllers
{
    public class LibroController : Controller
    {

        // GET: Libro
        // miaplicacion.com/Libro/Index
        // miaplicacion.com/Libro/

        //public ActionResult Index()
        //{
        //    return View();
        //}
        // miaplicacion.com/Libro/Aleatorio
        // miaplicacion.com/Libro/
        /// <summary>
        /// Obtenemos un libro aleatoriamente 
        /// </summary>
        /// <returns></returns>
        public ActionResult Aleatorio()
        {
            BibliotecaEntities db = new BibliotecaEntities();

            Libro libro = db.Libro.FirstOrDefault();

              List<TablaSinSentido> sinSentido = db.TablaSinSentido.ToList();

            Aleatorio ViewModel = new Aleatorio();


            ViewModel.libro = libro;
            ViewModel.listaSinSentido = sinSentido;

            // db.Dispose();

            return View(ViewModel);
        }

       
        public ActionResult Edit(int valor)
        {

            return Content("valor : " + valor);
        }

        public ActionResult Index(int? pageIndex,string sorty)
        {

            if (!pageIndex.HasValue)
            {
                pageIndex = 1;
            }
            if (String.IsNullOrWhiteSpace(sorty))
            {
                sorty = "Titulo";

               
            }
            return Content(String.Format("pageIndex={0}&sorty={1}", pageIndex, sorty));

        }
        //esto es un metodo estatico, para que pueda funcionar se añade esto: [Route("Libro/metodo/{idBibioteca}/{titulo}")] y en routeconfigesto :routes.MapMvcAttributeRoutes();

        [Route("Libro/metodo/{idBibioteca:range(1,9999)}/{titulo:maxlength(5):minlength(3)}")]
        public ActionResult metodo(int idBibioteca, string titulo)
        {
          
            return Content(String.Format("idBibioteca={0}&titulo={1}", idBibioteca, titulo));

        }


    }
}