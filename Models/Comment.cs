using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MertKaymaz_HW2.Models
{
    public class Comment
    {
        
        public int Id { get; set; }
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Başlık Alanı 2 ile 50 karakter arasında olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Başlık")]
        public string Title { get; set; }
        [Display(Name = "Detay")]
        public string Detail { get; set; }
        [Display(Name = "Puan")]
        
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int Rating { get; set; }
        [Display(Name = "Oluşturulma Tarihi")]
        public DateTime CreatedDate { get; set; }
        
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        [Display(Name = "Kitap")]
        public int BookId { get; set; }
        [Display(Name = "Kitap")]
        public Book Book { get; set; }
        public Comment()
        {
            CreatedDate = DateTime.Now;
        }
    }
  
}
