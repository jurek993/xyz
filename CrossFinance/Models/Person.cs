using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CrossFinance.Models
{
    [Table("Person")]
    public class Person
    {
        [Key]
        public int Id { get; set; }
        [Display(Name = "imie")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string FirstName { get; set; }
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string SecondName { get; set; }
        [Display(Name = "nazwisko")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string Surname { get; set; }
        [Display(Name = "PESEL")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string NationalIdentificationNumber { get; set; }
        [ForeignKey("Address")]
        public int AddressId { get; set; }
        public  Address Address { get; set; }
        [Display(Name = "Telefon 1")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string PhoneNumber { get; set; }
        [Display(Name = "Telefon2")]
        [Column(TypeName = "VARCHAR")]
        [StringLength(300)]
        public string PhoneNumber2 { get; set; }
    }
}