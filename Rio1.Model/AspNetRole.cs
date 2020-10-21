using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rio1.Model
{
    public  class AspNetRole
    {
        [Required]
        [Display(Name = " Identificador")]
        public string Id { get; set; }

        [Required]
        [Display(Name = " Nombre del rol")]
        public string Name { get; set; }
    }
}
