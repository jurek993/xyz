using CrossFinance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrossFinance.XLSXReader
{
    public class MapToAgreement : IMapper
    {
        public List<object> MapObject(List<List<object>> allData)
        {
            List<object> List = new List<object>();
            object[] fields = new object[20];
            for (int i = 0; i < allData.FirstOrDefault().Count(); i++)
            {
                int j = 0;
                foreach (var column in allData)
                {
                    if (column.ElementAt(i) == null)
                    {
                        fields[j] = (object)string.Empty;
                    }
                    else
                    {
                        fields[j] = column.ElementAt(i);
                    }
                    j++;
                }
                List.Add(objectToAddress(fields));
            }
            return List;
        }

        private Agreement objectToAddress(object[] row)
        {
            return new Agreement
            {
                Number = row[0].ToString()
            };
        }
    }
}