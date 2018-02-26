using CrossFinance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrossFinance.XLSXReader
{
    public class MapToFinancialState : IMapper
    {
        public List<object> MapObject(List<List<object>> allData)
        {
            List<object> List = new List<object>();
            object[] financialState = new object[20];
            for (int i = 0; i < allData.FirstOrDefault().Count(); i++)
            {
                int j = 0;
                foreach (var column in allData)
                {
                    if (column.ElementAt(i) == null)
                    {
                        financialState[j] = (object)Decimal.Parse("0");
                    }
                    else
                    {
                        financialState[j] = column.ElementAt(i);
                    }
                    j++;
                }
                var financial = objectToFinancialState(financialState);
                List.Add(financial);
            }
            return List;
        }


        private FinancialState objectToFinancialState(object[] row)
        {
            decimal temp;
            foreach (var item in row)
            {
                if (!decimal.TryParse(item.ToString(), out temp))
                {
                    return new FinancialState
                    {
                        Id = 404
                    };
                }
            }
            return new FinancialState
            {
                OutstandingLiabilites = decimal.Parse(row[0].ToString()),
                Interests = decimal.Parse(row[1].ToString()),
                PenaltyInterests = decimal.Parse(row[2].ToString()),
                Fees = decimal.Parse(row[3].ToString()),
                CourtFees = decimal.Parse(row[4].ToString()),
                RepresentationCourtFees = decimal.Parse(row[5].ToString()),
                VindicationCosts = decimal.Parse(row[6].ToString()),
                RepresentationVindicationCosts = decimal.Parse(row[7].ToString())
            };
        }
    }
}