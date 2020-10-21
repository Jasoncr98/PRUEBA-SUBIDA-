using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rio1.DataAcces
{
    public class OperacionesEnRoles
    {

        public Rio1.Model.AspNetRole ConsultarAspNetRoles(string Id)
        {
            var db = new Context();
            var resultado = db.AspNetRoles.Find(Id);
            return resultado;
        }


        public List<Rio1.Model.AspNetRole> ListarAspNetRoles()
        {
            var db = new Context();
            var users = from c in db.AspNetRoles
                        select c;

            return users.ToList();

        }




        public Rio1.Model.AspNetRole ObtenerAspNetRolesPorId(string Id)
        {
            var db = new Context();
            var resultado = db.AspNetRoles.Find(Id);
            return resultado;
        }
        public void Eliminar(Model.AspNetRole aspNetRoles)
        {
            var valorBd = ObtenerAspNetRolesPorId(aspNetRoles.Id);
            var db = new Context();
            valorBd.Id = aspNetRoles.Id;
            valorBd.Name = aspNetRoles.Name;
            db.Entry(valorBd).State = System.Data.Entity.EntityState.Deleted;
            db.SaveChanges();


        }
    }
}
