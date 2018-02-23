using CrossFinance.Models;
using MySql.Data.Entity;
using System.Data.Entity;

namespace CrossFinance.Database
{
    [DbConfigurationType(typeof(MySqlEFConfiguration))]
    public class CrossFinanceDBContext : DbContext
    {
        public virtual DbSet<Person> Persons { get; set; }
        public virtual DbSet<Address> Addresses { get; set; }
        public virtual DbSet<FinancialState> FinancialStates { get; set; }
        public virtual DbSet<Agreement> Agreements { get; set; }

        
        public CrossFinanceDBContext()
                : base("CrossFinanceDBContext")
        {
            Database.CreateIfNotExists();
        }
    }
}