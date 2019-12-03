using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalModulo3.Data;
using ProyectoFinalModulo3.Models;
using ProyectoFinalModulo3.Services;

namespace ProyectoFinalModulo3.Controllers
{
    public class FilmsController : Controller
    {
        private IFilm _filmService;
        private UserManager<AppUser> _UserManager;

        public FilmsController(IFilm filmService, UserManager<AppUser> UserManager)
        {
            _filmService = filmService;
            _UserManager = UserManager;
        }


      

        // GET: Films
        public async Task<IActionResult> Index()
        {
            //List<Film> getFilms = new List<Film>( await _filmService.GetFilms(User.Identity.Name));
            return View(await _filmService.GetFilms(User.Identity.Name));
        }

        public IActionResult SearchFilm(string nombre)
        {
            List<Film> filmSearch = new List<Film>(_filmService.SearchFilm(nombre));
            return View(filmSearch);
        }
        public  async Task<IActionResult> GeneroFilms(int? id)
        {
            if (id == null)
            {
                return RedirectToAction("Index", "Films");
            }
            else
            {
                List<Film> films = new List<Film>(await _filmService.GeneroFilms(id,User.Identity.Name));
                return View(films);
            }
        }

        // GET: Films/Details/5
        public async Task<IActionResult> Details(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _filmService.GetFilm(id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // GET: Films/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: Films/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Id,Title,Synopsis,Genre,Image,Video,Rented")] Film film)
        {
            if (ModelState.IsValid)
            {
                await _filmService.AddFilm(film);
                return RedirectToAction(nameof(Index));
            }
            return View(film);
        }

        // GET: Films/Edit/5
        public async Task<IActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _filmService.GetFilm(id);  
            if (film == null)
            {
                return NotFound();
            }
            return View(film);
        }

        // POST: Films/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, [Bind("Id,Title,Synopsis,Genre,Image,Video,Rented")] Film film)
        {
            if (id != film.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {

                    await _filmService.UpdateFilm(film);
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!_filmService.FilmExists(film.Id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(film);
        }

        // GET: Films/Delete/5
        public async Task<IActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var film = await _filmService.GetFilm(id);
            if (film == null)
            {
                return NotFound();
            }

            return View(film);
        }

        // POST: Films/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(int id)
        {
            var film = await _filmService.GetFilm(id);

            await _filmService.DeleteFilm(film);
            return RedirectToAction(nameof(Index));
        }

       
    }
}
