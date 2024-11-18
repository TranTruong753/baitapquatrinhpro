using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace DomainLayer.Models
{
    public class Genre
    {
        [Key]
        public int Id { get; set; }
        [Required(ErrorMessage ="Vui lòng nhập tên thể loại")]
        [DisplayName("Tên thể loại")]
        public string Name { get; set; }
        public bool IsActive { get; set; } = true;
    }
}
