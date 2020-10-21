using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rio1.UI.Controllers
{
    public class ProveedoresController : Controller
    {
     
        // GET: Proveedores
        public ActionResult Index()
        {

            if (this.Request.IsAuthenticated)
            {
                Rio1.Business.GestorDeProveedores elGestor = new Business.GestorDeProveedores();
                var lista = elGestor.ListarProveedores();
                return View(lista);
            }
            else {
                return RedirectToAction("Index", "Home");
            }
        }
        public ActionResult VistaGeneral()
        {
            if (this.Request.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        public ActionResult Visualizar()
        {
            Rio1.Business.GestorDeProveedores elGestor = new Business.GestorDeProveedores();
            var lista = elGestor.ListarProveedores();
            if (this.Request.IsAuthenticated)
            {
                return View(lista);
            }
            else
            {
                return RedirectToAction("Index", "Home");

            }
        }

        // GET: Proveedores/Details/5
        public ActionResult Details(int id)
        {
            Rio1.Business.GestorDeProveedores gestorDeProveedores = new Business.GestorDeProveedores();
            Rio1.Model.Proveedores proveedores = new Model.Proveedores();

            proveedores = gestorDeProveedores.ObtenerProveedoresPorId(id);
            if (this.Request.IsAuthenticated)
            {
                return View(proveedores);
            }
            else
            {
                return RedirectToAction("Index", "Home");

            }
        }
        // GET: Proveedores/Create
        public ActionResult Create()
        {
            if (this.Request.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        // POST: Proveedores/Create
        [HttpPost]
        public ActionResult Create(Rio1.Model.Proveedores proveedores)
        {
            try
            {
                Rio1.Business.GestorDeProveedores elGestor = new Business.GestorDeProveedores();
                elGestor.Agregar(proveedores);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

      
        // GET: Proveedores/Edit/5
        public ActionResult Editar(int id)
        {
            Rio1.Business.GestorDeProveedores elGestor = new Business.GestorDeProveedores();
            Rio1.Model.Proveedores proveedores;
            proveedores = elGestor.ObtenerProveedoresPorId(id);
            if (this.Request.IsAuthenticated)
            {
                return View(proveedores);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
            
        }

        // POST: Proveedores/Edit/5
        [HttpPost]
        public ActionResult Editar(int id, Rio1.Model.Proveedores proveedores)
        {
            try
            {
                Rio1.Business.GestorDeProveedores gestorproveedores = new Business.GestorDeProveedores();
                gestorproveedores.Editar(proveedores);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        

        // GET: Proveedores/Inactivar/
        public ActionResult Inactivar(int Id)
        {


            Rio1.Business.GestorDeProveedores elGestor = new Business.GestorDeProveedores();
            Rio1.Model.Proveedores proveedores;
            proveedores = elGestor.ObtenerProveedoresPorId(Id);

            if (this.Request.IsAuthenticated)
            {
                return View(proveedores);
            }
            else
            {
                return RedirectToAction("Index", "Home");

            }
        }
    
        // POST:Proveedores/Inactivar/
        [HttpPost]
        public ActionResult Inactivar(Rio1.Model.Proveedores proveedores)
        {
            try
            {

                Rio1.Business.GestorDeProveedores elGestor = new Business.GestorDeProveedores();
                elGestor.InactivarProveedor(proveedores);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }


        // GET: Proveedores/Activar/
        public ActionResult Activar(int Id)
        {
            Rio1.Business.GestorDeProveedores elGestor = new Business.GestorDeProveedores();
            Rio1.Model.Proveedores proveedores;
            proveedores = elGestor.ObtenerProveedoresPorId(Id);

            if (this.Request.IsAuthenticated)
            {
                return View(proveedores);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }

        }

        // POST:Proveedores/Activar/
        [HttpPost]
        public ActionResult Activar(Rio1.Model.Proveedores proveedores)
        {
            try
            {

                Rio1.Business.GestorDeProveedores elGestor = new Rio1.Business.GestorDeProveedores();
                elGestor.ActivarProveedor(proveedores);
                return RedirectToAction("Index");

            }
            catch
            {
                return View();
            }
        }

        // GET: Proveedores/Crear
        public ActionResult Crear()
        {
            if (this.Request.IsAuthenticated)
            {
                return View();
            }
            else
            {

                return RedirectToAction("Index", "Home");
            }
        }

        // POST: Proveedores/Crear
        [HttpPost]
        public ActionResult Crear(Rio1.Model.Productos productos, int id)
        {
            try
            {
                Rio1.Business.GestorDeProductos elGestor = new Business.GestorDeProductos();
                productos.IdProveedor = id;
                elGestor.Agregar(productos);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
      


    }
}
