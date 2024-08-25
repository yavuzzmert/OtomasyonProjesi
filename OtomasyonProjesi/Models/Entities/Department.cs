using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace OtomasyonProjesi.Models.Entities
{
    public class Department
    {
        // prop - Id
        [Key]
        public int DepartmentID { get; set; }

        // Departman Adı
        [Display(Name = "Departman Adı")]
        [Column(TypeName = "Varchar")]
        [StringLength(30, ErrorMessage = "En fazla 30 karakter giriniz.")]
        public string DepartmentName { get; set; }

        // Departmandaki personel durumu
        public bool DepartmentState { get; set; }

        //foreign
        public ICollection<Staff> Staffs { get; set; }
    }
}