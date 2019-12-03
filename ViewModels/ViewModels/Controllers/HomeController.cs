using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using ViewModels.Models;

namespace ViewModels.Controllers
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
        public IActionResult Animales()
        {
            Animal a1 = new Animal
            {
                Nombre = "perro",
                NombreCientífico = "Canis Canis",
                Imagen = ""
            };
            Animal a2 = new Animal
            {
                Nombre = "Caballo",
                NombreCientífico = "Caballus Maximus",
                Imagen = ""
            };
            Animal a3 = new Animal
            {
                Nombre = "gato",
                NombreCientífico = "Felix Felix",
                Imagen = ""
            };
            List<Animal> animales = new List<Animal>()
            {
                a1,a2,a3
            };
            Familia f1 = new Familia
            {
                Nombre = "Mamífero"
            };
            FamiliaAnimalViewModel fa1 = new FamiliaAnimalViewModel
            {
                Familia = f1,
                Animales = animales
            };

            return View(fa1);
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
