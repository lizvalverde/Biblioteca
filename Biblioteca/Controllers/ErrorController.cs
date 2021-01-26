using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Biblioteca.Models.ViewModels.Error;

namespace Biblioteca.Controllers
{
    public  class ErrorController : Controller
    {
        // GET: Error
        [HttpPost]
        public ActionResult Index(Error error  )
        {
            //"~/Views/Wherever/SomeDir/MyView.aspx"
            return View("~/Views/Error/Index.cshtml", error);
        }
    }
}