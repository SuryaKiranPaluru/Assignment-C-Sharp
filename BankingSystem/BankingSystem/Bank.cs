using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    // Illustrating Abstract class
    public abstract class Bank
    {
        protected int BankID;

        public readonly string? IFSC;

        public readonly string? BankName;

        private readonly int BankAuthSignature;

        protected Bank() 
        {
            BankID = 1;
            IFSC = "ABC";
            BankName = "Bank";
            BankAuthSignature = 0;

        }

        protected string GetBankDetails(int bankID)
        {
            if (this.BankName != null) return this.BankName;
            return "Check Bank Id";
        }

        // BankSignature is created to illustrate the accessibility of method by succesor classes
        protected bool CheckBankSignature(int sign)
        {
            if (sign == this.BankAuthSignature) return true;
            return false;
        }

        // Illustrating Creation of Abstract method
        public abstract void GetAccountDetails(int AccNo, int sign);


    }

    // Illustrating Interface Creation
   
}
