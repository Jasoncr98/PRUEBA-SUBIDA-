using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rio1.Model
{
    public  class AspNetUsers
    {
        [Display(Name = "Identificador")]
        public string Id { get; set; }

        [Required]
        [Display(Name = "Correo Electrónico")]
        [EmailAddress]
        public string Email { get; set;  }

        public Boolean EmailConfirmed { get; set;  }

        [Required]
        [DataType(DataType.Password)]
        public string PasswordHash { get; set; }

        public string SecurityStamp { get; set;  }

        public string PhoneNumber { get; set; }

        [Required]
        public Boolean PhoneNumberConfirmed { get; set; }


        [Required]
        public Boolean TwoFactorEnabled { get; set; }

        public DateTime? LockoutEndDateUtc { get; set; }

        [Required]
        public Boolean LockoutEnabled { get; set; }

        [Required]
        public int AccessFailedCount { get; set; }

        [Required]
        [Display(Name = "Nombre de usuario")]
        public string UserName { get; set; }



    }
}
