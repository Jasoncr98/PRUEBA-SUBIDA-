using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rio1.Business
{
    public class GestorDeProveedores
    {
        public void Agregar(Rio1.Model.Proveedores proveedores)
        {
            Rio1.DataAcces.OperacionesEnProveedores operaciones;
            operaciones = new Rio1.DataAcces.OperacionesEnProveedores();
            proveedores.Estado = Rio1.Model.Estado.Activo;
            operaciones.Agregar(proveedores);

        }
        public List<Rio1.Model.Proveedores> ListarProveedores()
        {
            Rio1.DataAcces.OperacionesEnProveedores operaciones;
            operaciones = new Rio1.DataAcces.OperacionesEnProveedores();
            return operaciones.ListarProveedores();
        }
       
        public Rio1.Model.Proveedores ObtenerProveedoresPorId(int Id)
        {
            Rio1.DataAcces.OperacionesEnProveedores operaciones;
            operaciones = new Rio1.DataAcces.OperacionesEnProveedores();
            return operaciones.ObtenerProveedoresPorId(Id);
        }

      

        public void InactivarProveedor(Rio1.Model.Proveedores proveedores)
        {
            Rio1.DataAcces.OperacionesEnProveedores operaciones = new DataAcces.OperacionesEnProveedores();
           
            proveedores.Estado = Model.Estado.Inactivo;
            operaciones.InactivarProveedor(proveedores);


        }
        public void ActivarProveedor(Rio1.Model.Proveedores proveedores)
        {

            Rio1.DataAcces.OperacionesEnProveedores operaciones = new DataAcces.OperacionesEnProveedores();
            proveedores.Estado = Model.Estado.Activo;
            operaciones.ActivarProveedor(proveedores);
        }
        public void Editar(Model.Proveedores proveedores)
        {
            Rio1.DataAcces.OperacionesEnProveedores operacionesEnProveedores;
            operacionesEnProveedores = new DataAcces.OperacionesEnProveedores();
            proveedores.NombreProveedor =proveedores.NombreProveedor;
            proveedores.Telefono = proveedores.Telefono;
            proveedores.Direccion = proveedores.Direccion;
            operacionesEnProveedores.Editar(proveedores);
        }
    }
}
