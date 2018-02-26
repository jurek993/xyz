using CrossFinance.Helpers;
using CrossFinance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrossFinance.Database
{
    public class CrossFinanceDatabase : CrossFinanceDBContext
    {
        private MainViewModel _model;
        public CrossFinanceDatabase(MainViewModel model)
        {
            _model = model;
        }

        public void InsertRows(List<Person> persons, List<Address> addresses, List<FinancialState> financials, List<Agreement> agrements)
        {
            for(int i = 0; i < persons.Count; i++)
            {
                var error = checkData(persons.ElementAt(i), financials.ElementAt(i));
                if (error == string.Empty)
                {
                    if (!InsertSingleRow(persons.ElementAt(i), addresses.ElementAt(i), financials.ElementAt(i), agrements.ElementAt(i)))
                    {
                        _model.ErrorList.Add("Can't add row number: " + i + 1 + " to database");
                    }
                    
                }
                else
                {
                    _model.ErrorList.Add("Can't add row number: " + i + 1 + " to database\nErrorMessage:"+ error);
                }
            }
        }

        public bool InsertSingleRow(Person person, Address address, FinancialState financial, Agreement agreement)
        {

            using (var dbContextTransaction = Database.BeginTransaction())
            {
                try
                {
                    Addresses.Add(address);
                    FinancialStates.Add(financial);
                    person.Address = address;
                    Persons.Add(person);
                    agreement.FinancialState = financial;
                    agreement.Person = person;
                    Agreements.Add(agreement);
                    dbContextTransaction.Commit();
                    SaveChanges();
                    return true;
                }
                catch (Exception)
                {
                    dbContextTransaction.Rollback();
                    return false;
                }
            }
        }


        private string checkData(Person person, FinancialState financial)
        {
            string error = string.Empty;
            PeselValidation peselValidation = new PeselValidation();
            if (!peselValidation.Valid(person.NationalIdentificationNumber))
            {
                error+= "Pesel: " + person.NationalIdentificationNumber + "is incorrect";
            }
            if(financial == null)
            {
                error += "Wrong data in FinancialState.";
            }
            return error;
        }
    }
}