using e_Tickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_Tickets.Models
{
    public class Actor :IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="ProfilePicture")]
        [Required(ErrorMessage = "Profile Picture is Required")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "FullName")]
        [Required(ErrorMessage = "Full Name is Required")]
        public string FullName { get; set; }
        [Display(Name = "Biografy")]
        [Required(ErrorMessage = "Biografy is Required")]
        public string Bio { get; set; }
        public List<Actor_Movies> Actors_Movies { get; set; }
    }
}
