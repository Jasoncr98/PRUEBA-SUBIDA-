using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Rio1.UI.Controllers
{
    public class ProductosController : Controller
    {
        // GET: Productos
        public ActionResult Index()
        {
         
            Rio1.Business.GestorDeProductos elGestor = new Business.GestorDeProductos();
            var lista = elGestor.ListarProductos();
            if (this.Request.IsAuthenticated)
            {
                return View(lista);
            }
            else {
                return RedirectToAction("Index", "Home");
            }
        }

        // GET: Productos
        public ActionResult ListaHistorial( string cadena)
        {
            Rio1.Business.GestorDeProductos elGestor = new Business.GestorDeProductos();
            var lista = elGestor.ListarProductos();
            if (this.Request.IsAuthenticated)
            {
                return View(lista);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }

        // GET: Productos/Details/5
        public ActionResult Detallar(int id)
        {
            Rio1.Business.GestorDeProductos gestorDeProductos = new Business.GestorDeProductos();
            Rio1.Model.Productos productos = new Model.Productos();

            productos = gestorDeProductos.ObtenerProductoPorId(id);

            return View(productos);
            
        }


        // GET: Productos/Buscar/5
        public ActionResult Buscar(int id)
        {
            Rio1.Business.GestorDeProductos gestorDeProductos = new Business.GestorDeProductos();
            Rio1.Model.Productos productos;
            productos = gestorDeProductos.ObtenerProductoPorId(id);
            return View(productos);
        }

        // POST: Productos/Buscar/5
        [HttpPost]
        public ActionResult Buscar(Rio1.Model.Productos productos)
        {
            try
            {
                Rio1.Business.GestorDeProductos gestorDeProductos = new Business.GestorDeProductos();
                gestorDeProductos.Buscar(productos);
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        

        // GET: Productos/Edit/5
        public ActionResult EditarProducto(int id)
        {
            Rio1.Business.GestorDeProductos elGestor = new Business.GestorDeProductos();
            Rio1.Model.Productos productos;
            productos = elGestor.ObtenerProductoPorId(id);
            if (this.Request.IsAuthenticated)
            {
                return View(productos);
            }
            else
            {
                return RedirectToAction("Index", "Home");
            }
        }
        // POST: Productos/Edit/5
        [HttpPost]
        public ActionResult EditarProducto(Rio1.Model.Productos productos)
        {
            try
            {
                Rio1.Business.GestorDeProductos gestorDeProductos = new Business.GestorDeProductos();
                gestorDeProductos.Editar(productos);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
