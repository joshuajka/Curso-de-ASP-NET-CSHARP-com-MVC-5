using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using TreinamentoAspNetMvcUdemy.Models;

namespace TreinamentoAspNetMvcUdemy.Controllers
{
    public class UsuarioController : Controller
    {
        
        public ActionResult Usuario()
        {
            var usuario = new Usuario();

            return View(usuario);
        }

        [HttpPost]
        public ActionResult Usuario(Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                return View("Resultado", usuario);
            }
            return View(usuario);
        }

        public ActionResult Resultado(Usuario usuario)
        {
            return View(usuario);
        }

        public ActionResult LoginUnico(string login)
        {
            var bdExemplos = new Collection<string>
            {
                "Joshua",
                "Kiko" ,
                "Abbate"
            };
            return Json(bdExemplos.All(x => x.ToLower() != login.ToLower()), JsonRequestBehavior.AllowGet);
        }


    }
}