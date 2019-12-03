using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ProyectoAgenda.Models;

namespace ProyectoAgenda.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Contactos(string nombre)
        {
            List<Contacto> contactos = new List<Contacto>
            {
                    new Contacto { Nombre = "Elena", Apellido = "Larrakoetxea", Telefono = "627452795",Tipo= "Familia",Imagen = "~/imagenes/Contacto.png" },
                    new Contacto { Nombre = "Ana", Apellido = "Cubillo", Telefono = "627452796",Tipo= "Familia", Imagen = "~/imagenes/Contacto.png" },
                    new Contacto { Nombre = "Andrea", Apellido = "Rodriguez", Telefono = "627452797",Tipo= "Bilbao", Imagen = "~/imagenes/Contacto.png" },
                    new Contacto { Nombre = "Alejandra", Apellido = "Custardoy", Telefono = "627452798",Tipo= "Residencia", Imagen = "~/imagenes/Contacto.png" },
                    new Contacto { Nombre = "Vanessa", Apellido = "Pulz", Telefono = "627452799",Tipo= "Residencia", Imagen = "~/imagenes/Contacto.png" },
                    new Contacto { Nombre = "Leire", Apellido = "Dominguez", Telefono = "627452790",Tipo= "Bilbao", Imagen = "~/imagenes/Contacto.png" }
            };
            
            if (nombre != null)
            {
                contactos = contactos.Where(x => x.Nombre.ToLower().Contains(nombre.ToLower())).OrderBy(contacto => contacto.Apellido).ToList();
            }
          


            AgendaContactoViewModel agendaContacto = new AgendaContactoViewModel
            {
                Agenda = new Agenda { FechaCreacion = DateTime.Today, Propietario = "Elena" },
                Contactos = contactos
                
            };
            
            return View(agendaContacto);
        }
        //public IActionResult Residencia()
        //{
        //    List<Contacto> contactos = new List<Contacto>
        //    {
        //            new Contacto { Nombre = "Elena", Apellido = "Larrakoetxea", Telefono = "627452795",Tipo= "Familia",Imagen = "~/imagenes/Contacto.png" },
        //            new Contacto { Nombre = "Ana", Apellido = "Cubillo", Telefono = "627452796",Tipo= "Familia", Imagen = "~/imagenes/Contacto.png" },
        //            new Contacto { Nombre = "Andrea", Apellido = "Rodriguez", Telefono = "627452797",Tipo= "Bilbao", Imagen = "~/imagenes/Contacto.png" },
        //            new Contacto { Nombre = "Alejandra", Apellido = "Custardoy", Telefono = "627452798",Tipo= "Residencia", Imagen = "~/imagenes/Contacto.png" },
        //            new Contacto { Nombre = "Vanessa", Apellido = "Pulz", Telefono = "627452799",Tipo= "Residencia", Imagen = "~/imagenes/Contacto.png" },
        //            new Contacto { Nombre = "Leire", Apellido = "Dominguez", Telefono = "627452790",Tipo= "Bilbao", Imagen = "~/imagenes/Contacto.png" }
        //    };
        //    List<Contacto> salamanca = new List<Contacto>();
        //    salamanca = contactos.Where(x => x.Tipo.Contains("R")).OrderBy(contacto => contacto.Apellido).ToList();

        //    AgendaContactoViewModel agendaContacto = new AgendaContactoViewModel
        //    {
        //        Agenda = new Agenda { FechaCreacion = DateTime.Today, Propietario = "Elena" },
        //        Contactos = salamanca

        //    };

        //    return View(agendaContacto);
        //}
        //public IActionResult Bilbao()
        //{
        //    List<Contacto> contactos = new List<Contacto>
        //    {
        //            new Contacto { Nombre = "Elena", Apellido = "Larrakoetxea", Telefono = "627452795",Tipo= "Familia",Imagen = "~/imagenes/Contacto.png" },
        //            new Contacto { Nombre = "Ana", Apellido = "Cubillo", Telefono = "627452796",Tipo= "Familia", Imagen = "~/imagenes/Contacto.png" },
        //            new Contacto { Nombre = "Andrea", Apellido = "Rodriguez", Telefono = "627452797",Tipo= "Bilbao", Imagen = "~/imagenes/Contacto.png" },
        //            new Contacto { Nombre = "Alejandra", Apellido = "Custardoy", Telefono = "627452798",Tipo= "Residencia", Imagen = "~/imagenes/Contacto.png" },
        //            new Contacto { Nombre = "Vanessa", Apellido = "Pulz", Telefono = "627452799",Tipo= "Residencia", Imagen = "~/imagenes/Contacto.png" },
        //            new Contacto { Nombre = "Leire", Apellido = "Dominguez", Telefono = "627452790",Tipo= "Bilbao", Imagen = "~/imagenes/Contacto.png" }
        //    };

        //    List<Contacto> bilbao = new List<Contacto>();
        //    bilbao = contactos.Where(x => x.Tipo.Contains("B")).OrderBy(contacto => contacto.Apellido).ToList();

        //    AgendaContactoViewModel agendaContacto = new AgendaContactoViewModel
        //    {
        //        Agenda = new Agenda { FechaCreacion = DateTime.Today, Propietario = "Elena" },
        //        Contactos = bilbao

        //    };

        //    return View(agendaContacto);
        //}
        //public IActionResult Familia()
        //{
        //    List<Contacto> contactos = new List<Contacto>
        //    {
        //            new Contacto { Nombre = "Elena", Apellido = "Larrakoetxea", Telefono = "627452795",Tipo= "Familia",Imagen = "~/imagenes/Contacto.png" },
        //            new Contacto { Nombre = "Ana", Apellido = "Cubillo", Telefono = "627452796",Tipo= "Familia", Imagen = "~/imagenes/Contacto.png" },
        //            new Contacto { Nombre = "Andrea", Apellido = "Rodriguez", Telefono = "627452797",Tipo= "Bilbao", Imagen = "~/imagenes/Contacto.png" },
        //            new Contacto { Nombre = "Alejandra", Apellido = "Custardoy", Telefono = "627452798",Tipo= "Residencia", Imagen = "~/imagenes/Contacto.png" },
        //            new Contacto { Nombre = "Vanessa", Apellido = "Pulz", Telefono = "627452799",Tipo= "Residencia", Imagen = "~/imagenes/Contacto.png" },
        //            new Contacto { Nombre = "Leire", Apellido = "Dominguez", Telefono = "627452790",Tipo= "Bilbao", Imagen = "~/imagenes/Contacto.png" }
        //    };
        //    List<Contacto> familia = new List<Contacto>();
        //    familia = contactos.Where(x => x.Tipo.Contains("F")).OrderBy(contacto => contacto.Apellido).ToList();

        //    AgendaContactoViewModel agendaContacto = new AgendaContactoViewModel
        //    {
        //        Agenda = new Agenda { FechaCreacion = DateTime.Today, Propietario = "Elena" },
        //        Contactos = familia

        //    };

        //    return View(agendaContacto);
        //}


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
