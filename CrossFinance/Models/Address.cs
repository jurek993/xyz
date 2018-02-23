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
        [StringLength(300)]
        public string StreetName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string StreetNumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string FlatNumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string PostCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string PostOfficeCity { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string CorrespondenceStreetName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string CorrespondenceStreetnumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string CorrespondenceFlatNumber { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string CorrespondencePostCode { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string CorrespondencePostOfficeCity { get; set; }
    }
}