using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Empresa1aN.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "*")]
        [MaxLength(20)]
        [Display(Name = "Account Code")]
        public string Nombre { get; set; }

        [StringLength(3)]       
        public string Codigo { get; set; }


        public List<Empleado> empleados
        {
            get; set;
        }

    }
}
