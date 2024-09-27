using eTickets.Data.Base;
using System.ComponentModel.DataAnnotations;

namespace eTickets.Models
{
    public class Producer:IEntityBase
    {
        [Key]
        public int Id { get; set; }
        [Display(Name ="Profile Picture")]
        [Required(ErrorMessage ="The Profile Picture is required")]
        public string ProfilePictureURL { get; set; }
		[Display(Name = "Full Name")]
        [StringLength(50,MinimumLength = 50,ErrorMessage ="Full Name must be between 3 and 50 chars")]
        [Required(ErrorMessage = "The Full Name is required")]
        public string FullName { get; set; }
		[Display(Name = "Biography")]
        [Required(ErrorMessage = "The Biography is required")]
        public string Bio { get; set; }


        //Relationship

        public List<Movie> Movies { get; set; }
    }
}