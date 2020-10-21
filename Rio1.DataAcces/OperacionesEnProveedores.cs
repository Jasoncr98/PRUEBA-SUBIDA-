using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rio1.DataAcces
{
    public class OperacionesEnProveedores
    {


        public void Agregar(Rio1.Model.Proveedores proveedores)
        {
            var db = new Context();
            db.Proveedores.Add(proveedores);
            db.Entry(proveedores).State = System.Data.Entity.EntityState.Added;
            db.SaveChanges();
        }
        public Rio1.Model.Proveedores ConsultarProveedores(int Id)
        {
            var db = new Context();
            var resultado = db.Proveedores.Find(Id);
            return resultado;
        }


        public List<Rio1.Model.Proveedores> ListarProveedores()
        {
            var db = new Context();
            var Proverdor = from c in db.Proveedores
                                 select c;

            return Proverdor.ToList();

        }

      


        public Rio1.Model.Proveedores ObtenerProveedoresPorId(int Id)
        {
            var db = new Context();
            var resultado = db.Proveedores.Find(Id);
            return resultado;
        }

        
        public void InactivarProveedor(Rio1.Model.Proveedores proveedores)
        {
            var valorBd = ConsultarProveedores(proveedores.Id);
            var db = new Context();
            valorBd.Estado = proveedores.Estado;
            db.Entry(valorBd).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void ActivarProveedor(Rio1.Model.Proveedores proveedores)
        {
            var valorBd = ConsultarProveedores(proveedores.Id);
            var db = new Context();
            valorBd.Estado = proveedores.Estado;
            db.Entry(valorBd).State = System.Data.Entity.EntityState.Modified;
            db.SaveChanges();
        }
        public void Editar(Model.Proveedores proveedores)
        {
            var valorBd = ObtenerProveedoresPorId(proveedores.Id);
            var db = new Context();
            db.Entry(valorBd).State = System.Data.Entity.EntityState.Modified;
            valorBd.Direccion = proveedores.Direccion;
            valorBd.Telefono = proveedores.Telefono;
            valorBd.NombreProveedor = proveedores.NombreProveedor;
            db.SaveChanges();
        }

    }
}
