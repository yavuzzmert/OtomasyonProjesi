using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace OtomasyonProjesi.Models.Entities
{
    public class Sale
    {
        // prop - Id
        [Key]
        public int SaleID { get; set; }

        // adeti
        public int SaleQuantity { get; set; }

        // fiyat
        public decimal SalePrice { get; set; }

        // toplam tutar
        [Display(Name = "Toplam Tutar")]
        public decimal SaleTotalAmount { get; set; }

        // tarihi
        public DateTime SaleDate { get; set; }


       // foreign key
       public int ProductID { get; set; }
       public virtual Product Product { get; set; }


        // foreign key
        public int CustomerID { get; set; }
        public virtual Customer Customer { get; set; }


        // foreign key
        public int StaffID { get; set; }
        public virtual Staff Staff { get; set; }
    }
}