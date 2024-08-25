using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OtomasyonProjesi.Models.Entities
{
    public class InvoinceItem
    {
        // prop - Id 
        [Key]
        public int InvoinceItemID { get; set; }

        // fatura açıklaması
        [Display(Name = "Açıklama")]
        [Column(TypeName = "Varchar")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter giriniz.")]       
        public string InvoinceDescription { get; set; }

        // ürün adeti
        public int InvoinceQuantity { get; set; }

        // birim fiyat
        [Display(Name = "Birim Fiyat")]
        public decimal InvoinceUnitPrice { get; set; }

        // toplam tutar
        public decimal InvoinceTotalAmount { get; set; }

        //foreign
        public int InvoinceID { get; set; }
        public virtual Invoince Invoince { get; set; }
    }
}