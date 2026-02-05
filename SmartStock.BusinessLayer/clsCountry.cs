using SmartStock.DataLayer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartStock.BusinessLayer
{
    public class clsCountry
    {
        public  int CountryID { get; set; }
        public string CountryName { get; set; }
        public string CountryCode { get; set; }

        public clsCountry()
        {
            this.CountryID = -1;
            this.CountryCode = string.Empty;
            this.CountryName = string.Empty;
        }

        public clsCountry(int CountryID, string CountryName, string CountryCode)
        {
            this.CountryID=CountryID;
            this.CountryName=CountryName;
            this.CountryCode=CountryCode;
        }

        public static clsCountry FindCountryByID(int CountryID)
        {
            var DTOCountry = clsCountriesData.FindCountryByID(CountryID);
            if (DTOCountry == null)
                return null;

            return new clsCountry(DTOCountry.CountryID, DTOCountry.CountryName, DTOCountry.CountryCode);
        }

        public static DataTable GetAllcountries()
        {
            return clsCountriesData.GetALlCountries();
        }

    }
}
