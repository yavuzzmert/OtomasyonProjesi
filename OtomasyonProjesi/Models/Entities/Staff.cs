using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OtomasyonProjesi.Models.Entities
{
    public class Staff
    {
        [Key]
        public int StaffID { get; set; }  // prop - Id


        [Display(Name = "Personel Adı")]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string StaffName { get; set; }  // Adı


        [Display(Name = "Personel Soyadı")]
        [Column(TypeName = "Varchar")]
        [StringLength(30)]
        public string StaffSurname { get; set; } // Soyadı

        [Display(Name = "Personel Fotoğraf")]
        [Column(TypeName = "Varchar")]
        [StringLength(250)]
        public string StaffImage { get; set; } // Image


        // foreign key
        public int DepartmentID { get; set; }
        public virtual Department Department { get; set; }

        
        // foreign key
        public ICollection<Sale> Sales { get; set; }
    }
}