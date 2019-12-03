using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ProyectoFinalModulo3.Models
{
    public class UserFilm
    {
        public int Id { get; set; }

        public DateTime DateRental { get; set; }
        public DateTime ReturnDate { get; set; }

        public int AppUserId { get; set; }
        public AppUser User { get; set; }

        public int FilmId { get; set; }
        public Film film { get; set; }
    }
}
