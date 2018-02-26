using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CrossFinance.Helpers
{
    public class PeselValidation
    {
        public bool Valid(string pesel)
        {
            int sum = 0;
            int[] control = { 9, 7, 3, 1, 9, 7, 3, 1, 9, 7 };
            if (pesel.Length != 11)
                return false;
            int checksum = pesel[10] - 48;
            
            for (int i = 0; i < control.Length; i++)
            {
                sum += control[i] * (Convert.ToInt16(pesel[i]) - 48);
            }
            if (sum % 10 == checksum)
                return true;
            else
                return false;
        }
    }
}