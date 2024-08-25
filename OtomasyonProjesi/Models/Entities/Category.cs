using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OtomasyonProjesi.Models.Entities
{
    public class Category
    {
        [Key]
        public int CategoryID { get; set; }  //property - Id

        [Display(Name = "Kategori Adı")]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string CategoryName { get; set; }  // Adı

        public ICollection<Product> Products { get; set; } // içerisinde 1 den fazla ürün olabilir.

    }
}