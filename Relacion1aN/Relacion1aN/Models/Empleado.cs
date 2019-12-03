using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace Relacion1aN.Models
{
    public class Empleado
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        [MaxLength(15)]
        public string Nombre { get; set; }

        [Required(ErrorMessage = "*")]
        [MaxLength(40)]
        public string Apellido { get; set; }
        [Required(ErrorMessage = "*")]
        [PhoneAttribute()]
        public int Telefono { get; set; }
        [Required(ErrorMessage = "*")]
        [EmailAddressAttribute()]
        public String Email { get; set; }

        public int DepartamentoId { get; set; }
        public Departamento Departamento { get; set; }
    }
}
