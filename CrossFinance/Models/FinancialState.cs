using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CrossFinance.Models
{
    [Table("FinancialState")]
    public class FinancialState
    {
        [Key]
        public int Id { get; set; }
        [DecimalPrecision(10, 2)]
        [Display(Name = "Kapital")]
        public decimal OutstandingLiabilites { get; set; }
        [Display(Name = "odsetki")]
        [DecimalPrecision(10, 2)]
        public decimal Interests { get; set; }
        [Display(Name = "odsetki Karne")]
        [DecimalPrecision(10, 2)]
        public decimal PenaltyInterests { get; set; }
        [Display(Name = "opłaty")]
        [DecimalPrecision(10, 2)]
        public decimal Fees { get; set; }
        [Display(Name = "koszty sadowe")]
        [DecimalPrecision(10, 2)]
        public decimal CourtFees { get; set; }
        [Display(Name = "koszty zastepstwa sadowego")]
        [DecimalPrecision(10, 2)]
        public decimal RepresentationCourtFees { get; set; }
        [Display(Name = "koszty egzekucji")]
        [DecimalPrecision(10, 2)]
        public decimal VindicationCosts { get; set; }
        [Display(Name = "koszty zastepstwa egzekucyjnego")]
        [DecimalPrecision(10, 2)]
        public decimal RepresentationVindicationCosts { get; set; }
    }
}