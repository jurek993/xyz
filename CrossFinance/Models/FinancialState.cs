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
        public decimal OutstandingLiabilites { get; set; }
        [DecimalPrecision(10, 2)]
        public decimal Interests { get; set; }
        [DecimalPrecision(10, 2)]
        public decimal PenaltyInterests { get; set; }
        [DecimalPrecision(10, 2)]
        public decimal Fees { get; set; }
        [DecimalPrecision(10, 2)]
        public decimal CourtFees { get; set; }
        [DecimalPrecision(10, 2)]
        public decimal RepresentationCourtFees { get; set; }
        [DecimalPrecision(10, 2)]
        public decimal VindicationCosts { get; set; }
        [DecimalPrecision(10, 2)]
        public decimal RepresentationVindicationCosts { get; set; }
    }
}