using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Proyecto1._0.Models;

namespace Proyecto1._0.Controllers
{
    public class UsuarioController : Controller
    {
        // GET: Usuario


        private Colegio_DBEntities entidad = new Colegio_DBEntities();

        public ActionResult Index()
        {
            return View();
        }


        public ActionResult Validar()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Validar(string user, string password)
        {
           ///* usuario us*/ = bd.FirstOrDefault(d => d.username == user & d.contrasenna == password);

            //if(us != null){

            //    return RedirectToAction("Index", "Home");

            //}
            //else
            //{

            //    return RedirectToAction("No Hallado", "Usuario");
            //}
            return View();
        }



    }
}