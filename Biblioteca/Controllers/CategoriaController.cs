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
        // este por defecto tiene GET 
        public ActionResult Editar( int id) {

            try
            {
                BibliotecaEntities db = new BibliotecaEntities();

                Categoria cat = db.Categoria.FirstOrDefault(x => x.CategoriaId.Equals(id));
                db.Dispose();
                return View(cat);

            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
            
        }
        [HttpPost]
        public ActionResult Editarv1(int id, string valor, string valorinterno)
        {
            try
            {
                BibliotecaEntities db = new BibliotecaEntities();

                Categoria cat = db.Categoria.FirstOrDefault(x => x.CategoriaId.Equals(id));
                cat.Valor = valor;
                cat.ValorInterno = valorinterno;
                db.SaveChanges();
                db.Dispose();

                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
        }
        [HttpPost]
        public ActionResult Editar(Categoria categ)
        {
            try
            {
                BibliotecaEntities db = new BibliotecaEntities();

                Categoria cat = db.Categoria.FirstOrDefault(x => x.CategoriaId.Equals(categ.CategoriaId));
                cat.Valor = categ.Valor;
                cat.ValorInterno = categ.ValorInterno;
                db.SaveChanges();
                db.Dispose();

                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                return Content(e.Message);
            }
        }


    }
}