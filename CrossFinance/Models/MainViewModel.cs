using CrossFinance.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrossFinance.Models
{
    public class MainViewModel
    {
        public MainViewModel()
        {
            this.RowsNamesInImportedDocument = new List<RowsName>();
            this.ErrorList = new List<string>();
        }

        [Required]
        [DataType(DataType.Upload)]
        [Display(Name = "File")]
        public HttpPostedFileBase File { get; set; }
        public List<string> ErrorList { get; set; }

        public int CorrectlyAdded { get; set; } = 0;

        public int DataSize { get; set; }
        public List<RowsName> RowsNamesInImportedDocument { get; set; }
    }
}