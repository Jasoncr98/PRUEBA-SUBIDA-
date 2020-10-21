using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rio1.DataAcces
{
    public class OperacionesEnProductos
    {
        public void Agregar(Rio1.Model.Productos productos)
        {
            var db = new Context();
            db.Productos.Add(productos);
            db.Entry(productos).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }
        public Rio1.Model.Productos ConsultarProductos(int Id)
        {
            var db = new Context();
            var resultado = db.Productos.Find(Id);
            return resultado;
        }


        public List<Rio1.Model.Productos> ListarProductos()
        {
            var db = new Context();
            var Producto = from c in db.Productos
                            select c;

            return Producto.ToList();

        }


       

        public Rio1.Model.Productos ObtenerProductoPorId(int Id)
        {
            var db = new Context();
            var resultado = db.Productos.Find(Id);
            return resultado;
        }

        public void Editar(Model.Productos productos)
        {
            var valorBd = ObtenerProductoPorId(productos.Id);
            var db = new Context();
            db.Entry(valorBd).State = System.Data.Entity.EntityState.Modified;
            valorBd.Monto = productos.Monto;
            valorBd.NombreProducto = productos.NombreProducto;
            db.SaveChanges();
        }


        public void Buscar(Model.Productos productos)
        {
            
            var valorBd = ObtenerProductoPorId(productos.Id);
            var Buscar = valorBd;
            var db = new Context();
            db.Entry(valorBd).State = System.Data.Entity.EntityState.Unchanged;
            valorBd.IdProveedor = productos.Id;
            valorBd.Monto = productos.Monto;
            valorBd.NombreProducto = productos.NombreProducto;
            db.SaveChanges();
        }
    }
}
