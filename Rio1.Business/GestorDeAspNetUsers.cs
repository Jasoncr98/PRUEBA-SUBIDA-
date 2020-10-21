using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rio1.Business
{
    public class GestorDeAspNetUsers
    {

        public List<Rio1.Model.AspNetUsers> ListarAspNetUser()
        {
            Rio1.DataAcces.OperacionesEnAspNetUsers operaciones;
            operaciones = new Rio1.DataAcces.OperacionesEnAspNetUsers();
            return operaciones.ListarAspNetUsers();
        }

        public Rio1.Model.AspNetUsers ObtenerAspNetUsersPorId(string Id)
        {
            Rio1.DataAcces.OperacionesEnAspNetUsers operaciones;
            operaciones = new Rio1.DataAcces.OperacionesEnAspNetUsers();
            return operaciones.ObtenerAspNetUsersPorId(Id);
        }

        public void Eliminar(Model.AspNetUsers aspNetUsers)
        {
            Rio1.DataAcces.OperacionesEnAspNetUsers operacionesEnAspNetUsers;


            operacionesEnAspNetUsers = new DataAcces.OperacionesEnAspNetUsers();
            aspNetUsers.Id = aspNetUsers.Id;
            aspNetUsers.Email = aspNetUsers.Email;
            aspNetUsers.EmailConfirmed = aspNetUsers.EmailConfirmed;
            aspNetUsers.AccessFailedCount = aspNetUsers.AccessFailedCount;
            aspNetUsers.LockoutEnabled = aspNetUsers.LockoutEnabled;
            aspNetUsers.LockoutEndDateUtc = aspNetUsers.LockoutEndDateUtc;
            aspNetUsers.PasswordHash = aspNetUsers.PasswordHash;
            aspNetUsers.PhoneNumber = aspNetUsers.PhoneNumber;
            aspNetUsers.PhoneNumberConfirmed = aspNetUsers.PhoneNumberConfirmed;
            aspNetUsers.SecurityStamp = aspNetUsers.SecurityStamp;
            aspNetUsers.TwoFactorEnabled = aspNetUsers.TwoFactorEnabled;
            aspNetUsers.UserName = aspNetUsers.UserName;
            operacionesEnAspNetUsers.Eiminar(aspNetUsers);
        }
    }
}
