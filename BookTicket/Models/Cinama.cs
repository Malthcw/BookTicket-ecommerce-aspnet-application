using System.ComponentModel.DataAnnotations;

namespace BookTicket.Models
{
    public class Cinama
    {
        [Key]
        public int Id { get; set; }

        [Display(Name="Cinama Logo")]
        public string Logo { get; set;}

        [Display(Name = "Name")]
        public string Name { get; set; }

        [Display(Name = "Description")]
        public string Description { get; set; }

        //relationships
        public List<Movie> Movies { get; set; }

    }
}
