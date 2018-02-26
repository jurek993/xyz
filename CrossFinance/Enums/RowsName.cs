using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace CrossFinance.Enums
{
    public enum RowsName
    {
        none,
        lp,
        nr_umowy,
        imie,
        nazwisko,
        PESEL,
        MAIN_STREET_NAME,
        MAIN_STREET_NUMBER,
        MAIN_STREET_FLAT_NUMBER,
        MAIN_POST_CODE,
        MAIN_POST_OFFICE_CITY,
        CORRESPONDENCE_STREET_NAME,
        CORRESPONDENCE_STREET_NUMBER,
        CORRESPONDENCE_STREET_FLAT_NUMBER,
        CORRESPONDENCE_POST_CODE,
        CORRESPONDENCE_POST_OFFICE_CITY,
        [Display(Name = "Telefon 1")]
        Telefon1,
        Telefon2,
        Kapital,
        odsetki,
        [Display(Name = "odsetki Karne")]
        odsetki_Karne,
        opłaty,
        [Display(Name = "koszty sadowe")]
        kosztysadowe,
        [Display(Name = "koszty zastepstwa sadowego")]
        koszty_zastepstwa_sadowego,
        [Display(Name = "koszty egzekucji")]
        kosztyegzekucji,
        [Display(Name = "koszty zastepstwa egzekucyjnego")]
        kosztyzastepstwa_egzekucyjnego



    }
}