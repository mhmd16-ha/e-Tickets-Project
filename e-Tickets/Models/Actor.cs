using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_Tickets.Models
{
    public class Actor
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="ProfilePicture")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "FullName")]
        public string FullName { get; set; }
        [Display(Name = "Biografy")]
        public string Bio { get; set; }
        public List<Actor_Movies> Actors_Movies { get; set; }
    }
}
