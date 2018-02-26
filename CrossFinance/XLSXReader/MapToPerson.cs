using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CrossFinance.Models;

namespace CrossFinance.XLSXReader
{
    public class MapToPerson : IMapper
    {
        public List<object> MapObject(List<List<object>> allData)
        {
            List<object> List = new List<object>();
            object[] person = new object[20];
            for (int i = 0; i < allData.FirstOrDefault().Count(); i++)
            {
                int j = 0;
                foreach (var column in allData)
                {
                    person[j] = column.ElementAt(i);
                    j++; 
                }
                List.Add(objectToPerson(person));
            }
            return List;
        }


        private Person objectToPerson(object[] row)
        {
            return new Person
            {
                FirstName = row[0].ToString(),
                Surname = row[1].ToString(),
                NationalIdentificationNumber = row[2].ToString(), //todo: tu chieli coś parsujące to
                PhoneNumber = row[3].ToString(),
                PhoneNumber2 = row[4].ToString()
            };
        }
    }

}