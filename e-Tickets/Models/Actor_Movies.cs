using System.ComponentModel.DataAnnotations.Schema;

namespace e_Tickets.Models
{
    public class Actor_Movies
    {
        public int ActorId { get; set; }
        [ForeignKey("ActorId")]
        public Actor Actor { get; set; }
        public int MovieId { get; set; }
        [ForeignKey("MovieId")]
        public Movie Movie { get; set; }


    }
}
