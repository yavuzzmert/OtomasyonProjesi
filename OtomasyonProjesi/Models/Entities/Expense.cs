using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OtomasyonProjesi.Models.Entities
{
    public class Expense
    {
        [Key]
        public int ExpenseID { get; set; } // prop - Id

        [Column(TypeName = "Varchar")]
        [StringLength(100, ErrorMessage = "En fazla 100 karakter giriniz.")]
        public string ExpenseDescription { get; set; } // açıklaması

       
        public DateTime ExpenseDate { get; set; } // tarih

       
        public decimal ExpenseAmount { get; set; }  // tutarı
    }
}