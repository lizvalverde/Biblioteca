using Biblioteca.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Biblioteca.Controllers
{
    public class CategoriaController : Controller
    {
        // GET: Categoria
        //pagina principal
        public ActionResult Index()
        {
            BibliotecaEntities db = new BibliotecaEntities();

            List<Categoria> listacategoria = db.Categoria.ToList();
            db.Dispose();

            return View(listacategoria);
        }
    }
}