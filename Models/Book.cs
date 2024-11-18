using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace DomainLayer.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Code is required")]
        public string Code { get; set; }

        [Required(ErrorMessage = "Title is required")]
        public string Title { get; set; }

        public bool? Available { get; set; }

        public string Publisher { get; set; }

        public string Author { get; set; }

        [Required(ErrorMessage = "Genre ID is required")]
        public int GenreId { get; set; }
        [ForeignKey("GenreId")]
        [ValidateNever]
        public Genre Genre { get; set; }

        public DateTime? InfDate { get; set; }
    }
}
