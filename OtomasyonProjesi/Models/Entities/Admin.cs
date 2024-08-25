using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OtomasyonProjesi.Models.Entities
{
    public class Admin
    {
        // prop - Id
        [Key]
        public int AdminID { get; set; }

        // adı
        [Column(TypeName = "Varchar")]
        [StringLength(10, ErrorMessage = "En fazla 10 karakter giriniz.")]
        [Display(Name = "Kullanıcı Adı")]
        public string UserName { get; set; }

        // şifre
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        [Display(Name = "Şifre")]
        public string Password { get; set; }

        // yetki
        [Column(TypeName = "Char")]
        [StringLength(1)]
        public string Authorization { get; set; }
    }
}