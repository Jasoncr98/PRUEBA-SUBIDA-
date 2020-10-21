using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rio1.Business
{
    public class GestorDeProductos
    {
        public void Agregar(Rio1.Model.Productos productos)
        {
            Rio1.DataAcces.OperacionesEnProductos operaciones;
            operaciones = new Rio1.DataAcces.OperacionesEnProductos();
            operaciones.Agregar(productos);

        }
        public List<Rio1.Model.Productos> ListarProductos()
        {
            Rio1.DataAcces.OperacionesEnProductos operaciones;
            operaciones = new Rio1.DataAcces.OperacionesEnProductos();
            return operaciones.ListarProductos();
        }
        public Rio1.Model.Productos ObtenerProductoPorId(int Id)
        {
            Rio1.DataAcces.OperacionesEnProductos operaciones;
            operaciones = new Rio1.DataAcces.OperacionesEnProductos();
            return operaciones.ObtenerProductoPorId(Id);
        }
        public void Editar(Model.Productos productos)
        {
            Rio1.DataAcces.OperacionesEnProductos operacionesEnProductos;
            operacionesEnProductos = new DataAcces.OperacionesEnProductos();
            productos.Monto = productos.Monto;
            productos.NombreProducto = productos.NombreProducto;
            operacionesEnProductos.Editar(productos);
        }

        public void Buscar(Model.Productos productos)
        {
            Rio1.DataAcces.OperacionesEnProductos operacionesEnProductos;
            operacionesEnProductos = new DataAcces.OperacionesEnProductos();
            productos.IdProveedor = productos.Id;
            productos.Monto = productos.Monto;
            productos.NombreProducto = productos.NombreProducto;
            operacionesEnProductos.Buscar(productos);


        }

    }
}
