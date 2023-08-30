using BankingSystem;

public class Test
{
    public static void Main()
    {

        var loanAccount = new LoanAccount(1, "Loan", 25000, 13);
        var savingsAccount = new SavingsAccount(2, "Loan");
        var employee = new Employee();
        var customer = new Customer();

        Console.WriteLine("Inheritance and Object instantiation...");

        Console.WriteLine("Object of LoanAccount is Instantiated \n");
        loanAccount.GetLoanDetails("Ab102", 0);
        Console.WriteLine("\nFrom Object of LoanAccount executed getLoanDetails in same class\n");

        Console.WriteLine("From child class LoanAccount trying to access method in parent class Account \n");
        loanAccount.GetAccountDetails(1, 0);
        Console.WriteLine("\nFrom Object of LoanAccount executed getAccountDetails in parent class\n");

        Console.WriteLine("From child class LoanAccount trying to access method in parent class Account \n");
        loanAccount.GetAccountDetails(1, 0);
        Console.WriteLine("\nFrom Object of LoanAccount executed getAccountDetails in parent class\n");


        Console.WriteLine("Polymorphism...\n");

        loanAccount.PrintStatus();
        savingsAccount.PrintStatus();

        Console.WriteLine("\n Accessing classes created from Interface");

        Console.WriteLine(employee.GetPersonRole());

        Console.WriteLine(customer.GetPersonRole());


    }

}
