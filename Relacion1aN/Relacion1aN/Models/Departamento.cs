using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Relacion1aN.Models
{
    public class Departamento
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "*") ]
        [MaxLength(20)]
        public string Nombre { get; set; }
        [MinLength(3)][MaxLength(3)]
        [DisplayFormat(DataFormatString = "{0:U}")]
        public string Codigo { get; set; }
     

        public List<Empleado> empleados
        {
            get; set;
        }
    }
}
