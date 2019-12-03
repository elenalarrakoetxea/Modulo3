using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using ProyectoFinalModulo3.Data;
using ProyectoFinalModulo3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalModulo3.Services
{
    public class FilmsServices : IFilm
    {


        private readonly ApplicationDbContext _context;
        private readonly UserManager<AppUser> _userManager;

        public FilmsServices(ApplicationDbContext context, UserManager<AppUser> userManager)
        {
            _context = context;
            _userManager = userManager;

        }

        public async Task AddFilm(Film film)
        {
            _context.Add(film);
            await _context.SaveChangesAsync();
        }

        public async Task DeleteFilm(Film film)
        {
            _context.Remove(film);
            await _context.SaveChangesAsync();
        }

        public bool FilmExists(int id)
        {
            return _context.Film.Any(e => e.Id == id);
        }

        public async Task<List<Film>> GeneroFilms(int? id, string name)
        {
            AppUser user = await _userManager.FindByEmailAsync(name);
            if (await _userManager.IsInRoleAsync(user, "adulto"))
            {

                if (id == 1)
                {
                    return await _context.Film.Where(x => x.Genre == "Fantasía y Ciencia Ficción").ToListAsync();
                }
                if (id == 2)
                {
                    return await _context.Film.Where(x => x.Genre == "Acción y Aventura").ToListAsync();
                }
                if (id == 3)
                {
                    return await _context.Film.Where(x => x.Genre == "Dramático y Romántico").ToListAsync();
                }
                else
                {

                    return RedirectToAction("Index", "Films");
                }
            }
            else
            {
                if (id == 1)
                {
                    return await _context.Film.Where(x => x.Genre == "Fantasía y Ciencia Ficción").Where(x => x.RecommendedAge < 12).ToListAsync();
                }
                if (id == 2)
                {
                    return await _context.Film.Where(x => x.Genre == "Acción y Aventura").Where(x => x.RecommendedAge < 12).ToListAsync();
                }
                if (id == 3)
                {
                    return await _context.Film.Where(x => x.Genre == "Dramático y Romántico").Where(x => x.RecommendedAge < 12).ToListAsync();
                }
                else
                {

                    return RedirectToAction("Index", "Films");
                }
            }
        }

        private List<Film> RedirectToAction(string v1, string v2)
        {
            throw new NotImplementedException();
        }

        public async Task<Film> GetFilm(int? id)
        {
            return await _context.Film.FindAsync(id);
        }

        public async Task<FilmGenreVM> GetFilms(string name)
        {

            AppUser user = await _userManager.FindByEmailAsync(name);
            List<string> generosPelicula = new List<string>();
            generosPelicula = await _context.Film.Select(x => x.Genre).Distinct().ToListAsync();
            if (await _userManager.IsInRoleAsync(user, "adulto"))
            {
                FilmGenreVM vistaIndex = new FilmGenreVM()
                {
                    Peliculas = await _context.Film.ToListAsync(),
                    Generos = generosPelicula
                };

                return vistaIndex;
            }
            else
            {
                FilmGenreVM vistaIndex = new FilmGenreVM()
                {
                    Peliculas = await _context.Film.Where(x => x.RecommendedAge < 12).ToListAsync(),
                    Generos = generosPelicula
                };
                return vistaIndex;
            }



        }

        public List<Film> SearchFilm(string name)
        {
            return _context.Film.Where(x => x.Title.ToLower().Contains(name.ToLower())).ToList();

        }

        public async Task UpdateFilm(Film film)
        {
            _context.Update(film);
            await _context.SaveChangesAsync();
        }

    }
}

