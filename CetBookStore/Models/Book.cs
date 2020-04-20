using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace CetBookStore.Models
{
    public class Book
    {
        public int Id { get; set; }

        [StringLength(512, MinimumLength =3)]
        [Required]
        [Display(Name ="Kitap Adı")]
        public string Title { get; set; } // nvarchar(512), not nullable
        [Display(Name = "Sayfa Sayısı")]
        public int? PageCount { get; set; }
        [Display(Name = "Yazar(lar)")]
        public string Authors { get; set; }
        [Display(Name = "Açıklama")]
        public string Description  { get; set; }
        [Display(Name = "Fiyat")]
        public Decimal Price { get; set; }
        [Display(Name = "Yayın Yılı")]

        public int PressYear { get; set; }
        [Display(Name = "Stok Bilgisi")]
        public int StockCount { get; set; }

        
        public int CategoryId { get; set; }
        //[ForeignKey("CategoryId")]
        [Display(Name = "Kategori")]
        public  Category Category { get; set; }
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
