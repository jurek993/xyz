using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrossFinance.Models
{
    [Table("Address")]
    public class Address
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "MAIN_STREET_NAME")]
        [StringLength(300)]
        public string StreetName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "MAIN_STREET_NUMBER")]
        [StringLength(300)]
        public string StreetNumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "MAIN_STREET_FLAT_NUMBER")]
        [StringLength(300)]
        public string FlatNumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "MAIN_POST_CODE")]
        [StringLength(300)]
        public string PostCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "MAIN_POST_OFFICE_CITY")]
        [StringLength(300)]
        public string PostOfficeCity { get; set; }
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "CORRESPONDENCE_STREET_NAME")]
        [StringLength(300)]
        public string CorrespondenceStreetName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "CORRESPONDENCE_STREET_NUMBER")]
        [StringLength(300)]
        public string CorrespondenceStreetnumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "CORRESPONDENCE_STREET_FLAT_NUMBER")]
        [StringLength(300)]
        public string CorrespondenceFlatNumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "CORRESPONDENCE_POST_CODE")]
        [StringLength(300)]
        public string CorrespondencePostCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [Display(Name = "CORRESPONDENCE_POST_OFFICE_CITY")]
        [StringLength(300)]
        public string CorrespondencePostOfficeCity { get; set; }
    }
}