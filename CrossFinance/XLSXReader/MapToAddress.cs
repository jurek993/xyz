using CrossFinance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrossFinance.XLSXReader
{
    public class MapToAddress : IMapper
    {
        public List<object> MapObject(List<List<object>> allData)
        {
            List<object> List = new List<object>();
            object[] adress = new object[20];
            for (int i = 0; i < allData.FirstOrDefault().Count(); i++)
            {
                int j = 0;
                foreach (var column in allData)
                {
                    if(column.ElementAt(i) == null)
                    {
                        adress[j] = (object)string.Empty;
                    }
                    else
                    {
                        adress[j] = column.ElementAt(i);
                    }
                    
                    j++;
                }
                List.Add(objectToAddress(adress));
            }
            return List;
        }

        private Address objectToAddress(object[] row)
        {
            return new Address
            {
                StreetName = row[0].ToString(),
                StreetNumber = row[1].ToString(),
                FlatNumber = row[2].ToString(),
                PostCode = row[3].ToString(),
                PostOfficeCity = row[4].ToString(),
                CorrespondenceStreetName = row[5].ToString(),
                CorrespondenceStreetnumber = row[6].ToString(),
                CorrespondenceFlatNumber = row[7].ToString(),
                CorrespondencePostCode = row[8].ToString(),
                CorrespondencePostOfficeCity = row[9].ToString()
            };
        }
    }
}