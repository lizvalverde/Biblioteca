using Biblioteca.Models.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biblioteca.Models.ViewModels.Error;

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
                return new ErrorController().Index(new Error { excepcion = e, direccion = new url { controlador = "Categoria", accion = "Index" } });

            }

        }
        public ActionResult Detalle(int id)
        {

            try
            {
                BibliotecaEntities db = new BibliotecaEntities();

                Categoria cat = db.Categoria.FirstOrDefault(x => x.CategoriaId.Equals(id));
                db.Dispose();
                return View(cat);

            }
            catch (Exception e)
            {
                return new ErrorController().Index(new Error { excepcion = e, direccion = new url { controlador = "Categoria", accion = "Index" } });

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
                return new ErrorController().Index(new Error { excepcion = e, direccion = new url { controlador = "Categoria", accion = "Index" } });

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
                return new ErrorController().Index(new Error { excepcion = e, direccion = new url { controlador = "Categoria", accion = "Index" } });

            }
        }
        [HttpPost]
        public ActionResult Crear(Categoria categ)
        {
            try
            {
                BibliotecaEntities db = new BibliotecaEntities();
                db.Categoria.Add(categ);
                db.SaveChanges();
                db.Dispose();

                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                return new ErrorController().Index(new Error { excepcion = e, direccion = new url { controlador = "Categoria", accion = "Index" } });

            }
        }
        // este por defecto tiene GET 
        public ActionResult Crear()
        {

            try
            {

                Categoria cat = new Categoria();
               
                return View(cat);

            }
            catch (Exception e)
            {
                return new ErrorController().Index(new Error { excepcion = e, direccion = new url { controlador = "Categoria", accion = "Index" } });

            }

        }
        [HttpGet]
        public ActionResult Eliminar(int id)
        {

            try
            {
                BibliotecaEntities db = new BibliotecaEntities();

                Categoria cat = db.Categoria.FirstOrDefault(x => x.CategoriaId.Equals(id));
                db.Dispose();
                return View(cat);

            }
            catch (Exception e)
            {
                return new ErrorController().Index(new Error { excepcion = e, direccion = new url { controlador = "Categoria", accion = "Index" } });

            }

        }
        [HttpPost]
        public ActionResult EliminarOK(int CategoriaId)
        {

            try
            {
                BibliotecaEntities db = new BibliotecaEntities();

                Categoria cat = db.Categoria.FirstOrDefault(x => x.CategoriaId.Equals(CategoriaId));
                db.Categoria.Remove(cat);
                db.SaveChanges();
                db.Dispose();
                return RedirectToAction("Index");

            }
            catch (Exception e)
            {
                return new ErrorController().Index(new Error { excepcion = e, direccion = new url { controlador = "Categoria", accion = "Index" } });
                    //(new Error { excepcion = e, direccion = new url { controlador = "Categoria", accion = "Index" } });
            }

        }




    }

}