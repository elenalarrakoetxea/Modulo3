using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace VideoclubWebApp.Models
{
    public class User
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "*")]
        public string Name { get; set; }
        [Required(ErrorMessage = "*")]
        public string LastName { get; set; }
        [Required(ErrorMessage = "Registration Date is required")]
        [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{dd/mmm/yyyy}")]
        public DateTime FechaNacimiento { get; set; }
        [Required(ErrorMessage = "*")]
        [EmailAddress]
        public string Email { get; set; }
        public string ProfilePicture { get; set; }
        public List<UserFilm> UserFilms { get; set; }
    }
}
