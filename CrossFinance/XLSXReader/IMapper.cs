using CrossFinance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrossFinance.XLSXReader
{
   public interface IMapper
    {
         List<object> MapObject(List<List<object>> allData);
    }
}
