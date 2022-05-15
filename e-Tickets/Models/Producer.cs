using e_Tickets.Data.Base;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace e_Tickets.Models
{
    public class Producer :IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "ProfilePicture")]
        public string ProfilePictureUrl { get; set; }
        [Display(Name = "Full Name")]
        public string FullName { get; set; }
        [Display(Name = "Biografy")]
        public string Bio { get; set; }
        public List<Movie> Movies { get; set; }
    }
}
