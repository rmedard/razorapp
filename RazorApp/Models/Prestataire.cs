using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace RazorApp.Models
{
    [Table("Prestataire")]
    public class Prestataire
    {
        [Key]
        public int Id { get; set; }
        
        [Required(ErrorMessage = "Enter first name")]
        public string FirstName { get; set; }
        
        [Required(ErrorMessage = "Enter last name")]
        public string LastName { get; set; }
        
        [Required(ErrorMessage = "Enter domaine")]
        public string Domaine { get; set; }
    }
}