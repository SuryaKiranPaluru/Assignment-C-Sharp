using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public class Account : Bank
    {
        protected int AccNo;

        protected string? AccType;

        public decimal Balance = 1000;

        protected Account(int AccNo,string AccType)
        {
            this.AccNo = AccNo;
            this.AccType = AccType;
        }

        // overriding of abstract method from Abstract class Bank
        public override void GetAccountDetails(int AccNo, int sign)
        {
            CheckBankSignature(sign);
            Console.WriteLine(string.Format("Account Number: {0}",AccNo));
            Console.WriteLine(string.Format("Account Type: {0}", this.AccType));
        }

        // Illustrating Runtime Polymorphism
        // Illustraing virtual functions concept
        public virtual void PrintStatus()
        {
            Console.WriteLine("Serving in Account class");
        }

    }

    //Illustrating Inheritance and class heirarchy
    public class LoanAccount : Account 
    {
        private readonly decimal LoanAmount;

        private string LoanId;

        protected decimal Interest;

        public LoanAccount(int AccNo, string AccType, decimal LoanAmount, decimal Interest) : base(AccNo, AccType) 
        {
            base.AccNo = AccNo; 
            base.AccType = AccType; 
            this.LoanAmount = LoanAmount;   
            this.Interest = Interest;
            LoanId = "Ab102";
        }

        // Illustrating Compiletime Polymorphism
        public void GetLoanDetails(int AccNo, int sign)
        {
            CheckBankSignature(sign);

            Console.WriteLine(string.Format("Account Number: {0}", AccNo));

            Console.WriteLine(string.Format("Loan Id: {0}", this.LoanId));

            Console.WriteLine(string.Format("Loan Amount: {0}", this.LoanAmount));

            Console.WriteLine(string.Format("Loan Interest: {0}", this.Interest));
        }

        public void GetLoanDetails(string LoanId, int sign)
        {
            CheckBankSignature(sign);

            Console.WriteLine(string.Format("Account Number: {0}", base.AccNo));

            Console.WriteLine(string.Format("Loan Id: {0}", LoanId));

            Console.WriteLine(string.Format("Loan Amount: {0}", this.LoanAmount));

            Console.WriteLine(string.Format("Loan Interest: {0}", this.Interest));
        }

        // Illustrating Runtime Polymorphism
        public override void PrintStatus()
        {
            Console.WriteLine("Serving in LoanAccount class");
        }

    }

    //Illustrating Inheritance and Class Heirarchy
    public class SavingsAccount : Account
    {
        protected decimal MinimumBalance = 200;

        public SavingsAccount(int AccNo, string AccType) : base(AccNo, AccType)
        {
            base.AccNo = AccNo;
            base.AccType = AccType;
        }

        public void EffectiveBalance(int AccNo, int sign)
        {
            CheckBankSignature(sign);

            Console.WriteLine(string.Format("Account Number: {0}", AccNo));

            Console.WriteLine(string.Format("Account Number: {0}", Balance - MinimumBalance));
            
        }

        // Illustrating Runtime Polymorphism
        public override void PrintStatus()
        {
            Console.WriteLine("Serving in SavingsAccount class");
        }

    }


}


