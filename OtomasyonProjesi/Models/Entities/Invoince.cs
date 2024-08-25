using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OtomasyonProjesi.Models.Entities
{
    public class Invoince
    {
        //prop -Id
        [Key]
        public int InvoinceID { get; set; }

        // seri no
        [Display(Name = "Fatura Seri no")]
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string InvoinceSerialNo { get; set; }

        // sıra no
        [Display(Name = "Fatura Ssıra no")]
        [Column(TypeName = "Varchar")]
        [StringLength(6)]
        public string InvoinceSequenceNo { get; set; }

        // vergi ofisi
        [Display(Name = "Vergi Dairesi")]
        [Column(TypeName = "Varchar")]
        [StringLength(60)]
        public string InvoinceTaxOffice { get; set; }

        // fatura tarih 
        public DateTime InvoinceDate { get; set; }

        // fatura saati
        [Column(TypeName = "char")]
        [StringLength(5)]
        public string InvoiceTime { get; set; }

        // teslim eden
        [Display(Name = "Teslim Eden")]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string InvoinceDeliveredBy { get; set; }

        // teslim alan
        [Display(Name = "Teslim Alan")]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string InvoinceReceiver { get; set; }

        public decimal Total { get; set; }

        // foreign
        public ICollection<InvoinceItem> InvoinceItems { get; set; }

    }
}