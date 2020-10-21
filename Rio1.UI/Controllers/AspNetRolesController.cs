using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.EntityFramework;
using Rio1.UI.Models;

namespace Rio1.UI.Controllers
{
    public class AspNetRolesController : Controller
    {
      [Authorize(Roles ="Admin")]
        // GET: AspNetRoles
        public ActionResult Index()
        {
            Rio1.Business.GestorDeAspNetRoles gestorDeAspNetRoles = new Business.GestorDeAspNetRoles();
            var Listar = gestorDeAspNetRoles.ListarAspNetRoles();
           
            if (this.Request.IsAuthenticated)
            {
                if (User.IsInRole("Admin"))
                {
                    return View(Listar);
                }
                else
                {
                    return RedirectToAction("VistaAdvertencia");
                }
            }
             else
             {
                    return RedirectToAction("Index");
             }
           
            

        }

        // GET: AspNetRoles/Detalles/5
        public ActionResult Detalles(string id)
        {
            Rio1.Model.AspNetRole aspNetRole;
            Rio1.Business.GestorDeAspNetRoles gestorDeAspNetRoles = new Business.GestorDeAspNetRoles();
            aspNetRole = gestorDeAspNetRoles.ObtenerAspNetRolesPorId(id);
            if (this.Request.IsAuthenticated)
            {
                return View(aspNetRole);
            }
            else {
                return RedirectToAction("Index");
            }
        }

      
        // GET: AspNetRoles/Eliminar/5
        public ActionResult Eliminar(int id)
        {
            Rio1.Business.GestorDeAspNetRoles gestordeAspNetRoles = new Business.GestorDeAspNetRoles();
            Rio1.Model.AspNetRole aspNetRole;


            return View();
        }

        // POST: AspNetRoles/Eliminar/5
        [HttpPost]
        public ActionResult Eliminar(string id, Model.AspNetRole aspNetRole)
        {
            try
            {
                Rio1.Business.GestorDeAspNetRoles gestor = new Business.GestorDeAspNetRoles();

                aspNetRole = gestor.ObtenerAspNetRolesPorId(id);
                gestor.Eliminar(aspNetRole);
                return RedirectToAction("Index");
            }
            catch
            {
                return View("Index");
            }
        }
    }
}
