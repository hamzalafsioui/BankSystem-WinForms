using System.Data;
using BankDataAccessLayer;
namespace BankBusinessLayer
{
	public class clsCurrency
    {
        public int ID {  get; set; }
        public string Country { get; set; }

        public string Code { get; set; }

        public string Name { get; set; }

        public decimal Rate { get; set; }

        enum enMode { AddNew = 0,Update = 1 }

        enMode Mode = enMode.AddNew;

        private clsCurrency(int iD, string country, string code, string name, decimal rate)
        {
            ID = iD;
            Country = country;
            Code = code;
            Name = name;
            Rate = rate;
            Mode = enMode.Update;
        }
        public clsCurrency()
        {
            ID = -1;
            Country = "";
            Code = "";
            Name = "";
            Rate = 0;
            Mode = enMode.AddNew;
        }
        public static DataTable GetAllCurrencies()
        {
            return clsCurrencyData.GetAllCurrencies();
        }

        public static bool IsCurrencyExistsByCode(string CurrencyCode)
        {
            return clsCurrencyData.IsCurrencyExistsByCode(CurrencyCode);
        }

        public static bool UpdateCurrency(string CurrencyCode,decimal NewRate)
        {
            return clsCurrencyData.UpdateCurrency(CurrencyCode, NewRate);
        }

        public static clsCurrency Find(string Code)
        {
            string Country = "", Name = "";
            decimal Rate = 0;
            int CurrencyID = -1;
            if (clsCurrencyData.getCurrencyInfoByCode(Code,ref CurrencyID,ref Country,ref Name,ref Rate)){
                return new clsCurrency(CurrencyID, Code, Country, Name, Rate);
            }
            else
            {
                return null;
            }
        }

    }
}
