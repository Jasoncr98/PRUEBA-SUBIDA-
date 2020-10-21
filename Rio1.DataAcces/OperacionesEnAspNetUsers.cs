using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rio1.DataAcces
{
    public class OperacionesEnAspNetUsers
    {

        public Rio1.Model.AspNetUsers ConsultarAspNetUsers(int Id)
        {
            var db = new Context();
            var resultado = db.AspNetUsers.Find(Id);
            return resultado;
        }


        public List<Rio1.Model.AspNetUsers> ListarAspNetUsers()
        {
            var db = new Context();
            var users = from c in db.AspNetUsers
                            select c;

            return users.ToList();

        }




        public Rio1.Model.AspNetUsers ObtenerAspNetUsersPorId(string Id)
        {
            var db = new Context();
            var resultado = db.AspNetUsers.Find(Id);
            return resultado;
        }


        public void Eiminar(Model.AspNetUsers aspNetUsers)
        {
            var valorBd = ObtenerAspNetUsersPorId(aspNetUsers.Id);
            var db = new Context();
            db.Entry(valorBd).State = System.Data.Entity.EntityState.Deleted;
            valorBd.Id = aspNetUsers.Id;
            valorBd.Email = aspNetUsers.Email;
            valorBd.EmailConfirmed = aspNetUsers.EmailConfirmed;
            valorBd.AccessFailedCount = aspNetUsers.AccessFailedCount;
            valorBd.LockoutEnabled = aspNetUsers.LockoutEnabled;
            valorBd.LockoutEndDateUtc = aspNetUsers.LockoutEndDateUtc;
            valorBd.PasswordHash = aspNetUsers.PasswordHash;
            valorBd.PhoneNumber = aspNetUsers.PhoneNumber;
            valorBd.PhoneNumberConfirmed = aspNetUsers.PhoneNumberConfirmed;
            valorBd.SecurityStamp = aspNetUsers.SecurityStamp;
            valorBd.TwoFactorEnabled = aspNetUsers.TwoFactorEnabled;
            valorBd.UserName = aspNetUsers.UserName;
            db.SaveChanges();
        }
    }
}
