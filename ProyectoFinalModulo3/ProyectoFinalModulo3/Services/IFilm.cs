using ProyectoFinalModulo3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalModulo3.Services
{
    public interface IFilm
    {
        Task<Film> GetFilm(int? id);
        Task<FilmGenreVM> GetFilms(string name);
        Task AddFilm(Film film);
        Task UpdateFilm(Film film);
        bool FilmExists(int id);
        Task DeleteFilm(Film film);
        List<Film> SearchFilm(string name);
        Task<List<Film>> GeneroFilms(int? id, string name);

    }
}
