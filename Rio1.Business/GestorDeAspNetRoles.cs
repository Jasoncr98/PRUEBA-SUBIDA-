using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rio1.Business
{
    public  class GestorDeAspNetRoles
    {
        public List<Rio1.Model.AspNetRole> ListarAspNetRoles()
        {
            Rio1.DataAcces.OperacionesEnRoles operaciones;
            operaciones = new Rio1.DataAcces.OperacionesEnRoles();
            return operaciones.ListarAspNetRoles();
        }

        public Rio1.Model.AspNetRole ObtenerAspNetRolesPorId(string Id)
        {
            Rio1.DataAcces.OperacionesEnRoles operaciones;
            operaciones = new Rio1.DataAcces.OperacionesEnRoles();
            return operaciones.ObtenerAspNetRolesPorId(Id);
        }


        public void Eliminar(Model.AspNetRole aspNetRoles)
        {
            Rio1.DataAcces.OperacionesEnRoles operacionesEnRoles;

            operacionesEnRoles = new DataAcces.OperacionesEnRoles();
            aspNetRoles.Id = aspNetRoles.Id;
            aspNetRoles.Name = aspNetRoles.Name;
            operacionesEnRoles.Eliminar(aspNetRoles);



        }
    }
}
