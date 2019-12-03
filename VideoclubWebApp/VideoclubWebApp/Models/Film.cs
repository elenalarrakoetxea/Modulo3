using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VideoclubWebApp.Models
{
    public class Film
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public string Genre { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public bool Rented { get; set; }
        public List<UserFilm> UserFilms { get; set; }

    }
}
