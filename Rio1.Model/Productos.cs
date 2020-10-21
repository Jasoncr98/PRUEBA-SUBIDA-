using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rio1.Model
{
    public class Productos
    {
        public int Id { get; set; }

        [Display(Name = "ID Proveedor")]
        public int IdProveedor { get; set; }

        [Display(Name = "Nombre del producto")]
        [Required(ErrorMessage = "El campo Nombre del producto es requerido")]
        public string NombreProducto { get; set; }

        [Display(Name = "Monto")]
        [Required(ErrorMessage = "El campo Monto es requerido")]
        public Decimal Monto { get; set; }

        

    }
}
