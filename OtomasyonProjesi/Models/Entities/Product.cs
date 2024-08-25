using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OtomasyonProjesi.Models.Entities
{
    public class Product
    {
        [Key]
        public int ProductID { get; set; }  //property - Id

        [Display(Name = "Ürün Adı")]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ProductName { get; set; }   // Ad


        [Display(Name = "Ürün Markası")]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string ProductBrand { get; set; }     // Marka


        [Display(Name = "Ürün Stok Sayısı")]
        public int ProductStock { get; set; }   // Stok

        
        public bool ProductState { get; set; }  // Ürün Durumu

        [Display(Name = "Ürün Görsel")]
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string ProductImage { get; set; }    // Ürün Image


        [Display(Name = "Alış Fiyat")]
        public decimal ProductPriceTake { get; set; }  // Alış fiyatı


        [Display(Name = "Satış Fiyat")]
        public decimal ProductPriceSale { get; set; }   // Satış fiyatı


        // Foreign key
        public int CategoryID { get; set; }

        public virtual Category Category { get; set; }  //ilgili alanda tek kategori olabilir

        // foreign key
        public ICollection<Sale> Sales { get; set; }
    }
}