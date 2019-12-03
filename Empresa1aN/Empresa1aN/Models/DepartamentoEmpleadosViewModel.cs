using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Empresa1aN.Models
{
    public class DepartamentoEmpleadosViewModel
    {
        public List<Departamento> Departamentos { get; set; }
        public List<Empleado> Empleados { get; set; }
        public int Id { get; set; }
    }
}
