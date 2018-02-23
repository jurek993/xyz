using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrossFinance.Models
{
    [Table("Agreement")]
    public class Agreement
    {
        [Key]
        public int Id { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(3000)]
        public string Number { get; set; }
        [ForeignKey("Person")]
        public int PersonId { get; set; }
        public  Person Person { get; set; }
        [ForeignKey("FinancialState")]
        public int FinancialStateId { get; set; }
        public FinancialState FinancialState { get; set; }
    }
}