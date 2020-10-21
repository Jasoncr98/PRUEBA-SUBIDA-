using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rio1.UI.Controllers
{
    public class AspNetUsersController : Controller
    {
     [Authorize (Roles ="Admin")]
        // GET: AspNetUsers
        public ActionResult Index()
        {
            Rio1.Business.GestorDeAspNetUsers gestorDeAspNetUsers = new Business.GestorDeAspNetUsers();
            var Listar = gestorDeAspNetUsers.ListarAspNetUser();
            if (this.Request.IsAuthenticated)
            {
                if (User.IsInRole("Admin"))
                { 
                     return View(Listar);
                }
                else {
                    return View("VistaAdvertencia");
                }
                
            }
                return View("VistaAdvertencia");
            
        }
        public ActionResult VistaGeneral()
        {
            if (this.Request.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return View("VistaAdvertencia");
            }
        }
        // GET: AspNetUsers/Details/5
        public ActionResult Detallar(string  id)
        {
            Rio1.Model.AspNetUsers aspNetUsers;
            Rio1.Business.GestorDeAspNetUsers gestorDeAspNetUsers = new Business.GestorDeAspNetUsers();
            aspNetUsers = gestorDeAspNetUsers.ObtenerAspNetUsersPorId(id);
            if (this.Request.IsAuthenticated)
            { 
             return View(aspNetUsers);
            }
           
                return View("VistaAdvertencia");
            
        }

       
        // GET: AspNetUsers/Edit/5
        public ActionResult Edit(int id)
        {
            if(this.Request.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return View("VistaAdvertencia");
            }
        }

        // POST: AspNetUsers/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: AspNetUsers/Eliminar/5
        public ActionResult Eliminar(string id)
        {

            Rio1.Business.GestorDeAspNetUsers gestorDeAspNetUsers = new Business.GestorDeAspNetUsers();
            Rio1.Model.AspNetUsers aspNetUsers;
            if (this.Request.IsAuthenticated)
            { 
                return View();
            }
            else
            {
                return View("VistaAdvertencia");
            }
        }

        // POST: AspNetUsers/Eliminar/5
        [HttpPost]
        public ActionResult Eliminar(Rio1.Model.AspNetUsers aspNetUsers, string id)
        {
            try
            {

                Rio1.Business.GestorDeAspNetUsers gestorDeAspNetUsers = new Business.GestorDeAspNetUsers();
                aspNetUsers = gestorDeAspNetUsers.ObtenerAspNetUsersPorId(id);

                gestorDeAspNetUsers.Eliminar(aspNetUsers);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
