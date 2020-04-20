using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
namespace MertKaymaz_HW2.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(50, MinimumLength = 3, ErrorMessage = "Başlık Alanı 2 ile 50 karakter arasında olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        
        [Display(Name = "Kitap Adı")]
        public string Title { get; set; } // nvarchar(512), not nullable
        [Display(Name = "Sayfa Sayısı")]
        public int? PageCount { get; set; }
        [Display(Name = "Yazar(lar)")]
        [StringLength(50, MinimumLength = 3, ErrorMessage = "Yazar alanı 2 ile 50 karakter arasında olmalıdır")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public string Authors { get; set; }
        [Display(Name = "Açıklama")]
        public string Description { get; set; }
        [Display(Name = "Fiyat")]
        
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public Decimal Price { get; set; }
        [Display(Name = "Yayın Yılı")]

        
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int PressYear { get; set; }
        [Display(Name = "Stok Bilgisi")]
        [Required(ErrorMessage = "Bu alan zorunludur.")]
        public int StockCount { get; set; }

        [Display(Name = "Kategori")]
        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        [Display(Name = "Kategori")]
        
        
        public Category Category { get; set; }
        [Display(Name = "Eklenme Tarihi")]
        public DateTime CreatedDate { get; set; }
        [Display(Name = "Yorumlar")]
        public virtual List<Comment> Comments { get; set; }
        public Book()
        {
            CreatedDate = DateTime.Now;
            //  double result = 4.0 / 2.0; //2.0000000000000000000000001 1.9999999999999999999999998
        }
    }
}
