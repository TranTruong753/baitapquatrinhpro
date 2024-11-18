using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace DomainLayer.Models.ViewModel
{
    public class BookVM
    {
        public Book Book { get; set; }
        [ValidateNever]
        public IEnumerable<SelectListItem> GenreList { get; set; }
    }
}
