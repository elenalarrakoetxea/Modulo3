using System;
using System.Collections.Generic;

namespace webApi.Models
{
    public partial class UserFilm
    {
        public int Id { get; set; }
        public DateTime DateRental { get; set; }
        public DateTime ReturnDate { get; set; }
        public int AppUserId { get; set; }
        public string UserId { get; set; }
        public int FilmId { get; set; }

        public virtual Film Film { get; set; }
        public virtual AspNetUsers User { get; set; }
    }
}
