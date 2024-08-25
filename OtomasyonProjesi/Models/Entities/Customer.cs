using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;
using System.Drawing;

namespace OtomasyonProjesi.Models.Entities
{
    public class Customer
    {
        // prop - Id
        [Key]
        public int CustomerID { get; set; }

        // müşteri adı
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter giriniz.")]
        [Display(Name = "Müşteri Adı")]
        public string CustomerName { get; set; }

        // müşteri soyadı
        [Display(Name = "Müşteri Soyadı")]
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter girebilirsiniz.")]
        [Required(ErrorMessage = "Bu alan boş geçilemez.")]
        public string CustomerSurname { get; set; }

        // müşteri şehri
        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "En fazla 20 karakter giriniz.")]
        [Display(Name = "Şehir")]
        public string CustomerCity { get; set; }

        // maili
        [Display(Name = "Mail")]
        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter giriniz.")]
        public string CustomerMail { get; set; }

        // şifresi
        [Display(Name = "Şifre")]
        [Column(TypeName = "Varchar")]
        [StringLength(20, ErrorMessage = "En fazla 20 karakter giriniz.")]
        public string CustomerPassword { get; set; }

        // işi
        [Display(Name = "Meslek")]
        [Column(TypeName = "Varchar")]
        [StringLength(50, ErrorMessage = "En fazla 50 karakter giriniz.")]
        public string CustomerJob { get; set; }

        // telefon
        [Display(Name = "Telefon")]
        [Column(TypeName = "Varchar")]
        [StringLength(20)]
        public string CustomerPhone { get; set; }

        // aktif?
        public bool CustomerState { get; set; }

        // foreign
        public  ICollection<Sale> Sales { get; set; }
    }
}