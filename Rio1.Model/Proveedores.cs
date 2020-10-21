using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace Rio1.Model
{
    public class Proveedores
    {
        public int Id { get; set; }

        public Estado Estado { get; set; }

        [StringLength(100)]
        [Display(Name = "Nombre")]
        [Required(ErrorMessage = "El campo Nombre del proveedor es requerido")]
        public string NombreProveedor { get; set; }
       

        [Range(0,1000000000)]
        [Display(Name = "Teléfono")]
        [Required(ErrorMessage = "El campo Teléfono es requerido")]
        public string Telefono { get; set; }

        [Display(Name = "Dirección")]
        [Required(ErrorMessage = "El campo dirección es requerido")]
        public string Direccion { get; set; }

      


       
    }

   
}

