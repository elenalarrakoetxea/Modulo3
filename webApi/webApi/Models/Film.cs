using System;
using System.Collections.Generic;

namespace webApi.Models
{
    public partial class Film
    {
        public Film()
        {
            UserFilm = new HashSet<UserFilm>();
        }

        public int Id { get; set; }
        public string Title { get; set; }
        public string Synopsis { get; set; }
        public string Genre { get; set; }
        public string Image { get; set; }
        public string Video { get; set; }
        public bool Rented { get; set; }
        public DateTime InsertDate { get; set; }
        public bool Premiere { get; set; }

        public virtual ICollection<UserFilm> UserFilm { get; set; }
    }
}
