using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using BankDataAccessLayer;
namespace BankBusinessLayer
{
    public class clsClient
    {
        public int ClientID { get; set; }
        public string AccountNumber { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string PinCode { get; set; }
        public decimal AccountBalance { get; set; }

        enum enMode { NewMode = 0, UpdateMode = 1 }
       enMode Mode = enMode.NewMode;

        private clsClient(int clientID, string accountNumber, string firstName, string lastName, string phone, string email, string pinCode, decimal accountBalance)
        {
            ClientID = clientID;
            AccountNumber = accountNumber;
            FirstName = firstName;
            LastName = lastName;
            Phone = phone;
            Email = email;
            PinCode = PinCode;
            AccountBalance = accountBalance;
            Mode = enMode.UpdateMode;
        }

        public clsClient()
        {
            ClientID = -1;
            AccountNumber = "";
            FirstName = "";
            LastName = "";
            Phone = "";
            Email = "";
            PinCode = "";
            AccountBalance = 0;
            Mode = enMode.NewMode;
        }

        public static clsClient FindByAccountNumber(string AccountNumber)
        {
            string FirstName = "", LastName = "", Phone = "", Email = "", PinCode = "";
            int ClientID = -1;
            decimal AccountBalance = 0;
            if (clsClientData.getClientInfoByAccountNumber(ref ClientID,AccountNumber,ref FirstName, ref LastName, ref Phone,ref Email, ref PinCode, ref AccountBalance))
            {
                return new clsClient(ClientID,AccountNumber,FirstName, LastName, Phone, Email, PinCode, AccountBalance);
            }
            else
            {
                return null;
            }
        }

        private bool _AddNewClient()
        {
            this.ClientID = clsClientData.AddNewClient( this.AccountNumber,this.FirstName, this.LastName, this.Phone, this.Email, this.PinCode
                , this.AccountBalance);

            return (this.ClientID != -1);
        }

        private bool _UpdateClient()
        {
            return clsClientData.UpdateClientInfo(this.AccountNumber, this.FirstName, this.LastName, this.Phone, this.Email, this.PinCode, this.AccountBalance);
        }

        public bool Save()
        {
            switch (Mode)
            {
                case enMode.NewMode:
                    if (_AddNewClient())
                    {
                        Mode = enMode.UpdateMode;
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                case enMode.UpdateMode:
                    return _UpdateClient();
            }
            return false;

        }

        public static bool DeleteClientByAccountNumber(string AccountNumber)
        {
            return clsClientData.DeleteClientByAccountNumber(AccountNumber);
        }

        public static DataTable GetAllClients()
        {
            return clsClientData.GetAllClients();
        }

        public static DataTable GetAllTransfers()
        {
            return clsClientData.GetAllTransfers();
        }
        public static DataTable GetAllDeposits()
        {
            return clsClientData.GetAllDeposits();
        }
        public static DataTable GetAllWithDraws()
        {
            return clsClientData.GetAllWithDraws();
        }
        public static bool IsClientExists(string AccountNumber)
        {
            return clsClientData.IsClientExists(AccountNumber);
        }

        public bool Deposit(decimal Amount)
        {
            int DepositID = clsClientData.Deposit(this.AccountNumber, Amount, DateTime.Now);
            return (DepositID!=-1);
        }

        public bool WithDraw(decimal Amount)
        {
            int DepositID = clsClientData.WithDraw(this.AccountNumber,Amount,DateTime.Now);
            return (DepositID!=-1);
        }


        public bool Transfer( string AccountNumberTo,decimal Amount)
        {
            return clsClientData.Transfer(this.AccountNumber,AccountNumberTo,Amount,DateTime.Now);
        }
    }

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
