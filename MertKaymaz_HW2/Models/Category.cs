using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace MertKaymaz_HW2.Models
{
    public class Category
    {
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "İsim Alanı 2 ile 50 karakter arasında olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "İsim")]
        public string Name { get; set; } // nvarchar(100) 2GB

        public virtual List<Book> Books { get; set; }
    }
}
