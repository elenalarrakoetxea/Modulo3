using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoAgenda.Models
{
    public class AgendaContactoViewModel
    {
        public Agenda Agenda { get; set; }
        public List<Contacto> Contactos { get; set; }
    }
}
