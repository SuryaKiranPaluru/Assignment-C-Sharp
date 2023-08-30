using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingSystem
{
    public interface IPerson
    {
        public string GetPersonName();

        public string GetPersonRole();

    }

    public class Employee : IPerson
    {
        private readonly string Name = "Koteswara rao Kavoori";

        private readonly string Role = "Employee";

        private readonly int EmpId = 10025;


        public string GetPersonName()
        {
            return this.Name;
        }

        public string GetPersonRole()
        {
            return this.Role;
        }

        public int GetEmpId()
        {
            return EmpId;
        }

        
    }

    public class Customer : IPerson
    {
        private readonly string Name = "Paluru Surya Kiran";

        private readonly string Role = "Customer";

        private readonly string CustId = "Abc100";


        public string GetPersonName()
        {
            return this.Name;
        }

        public string GetPersonRole()
        {
            return this.Role;
        }

        public string GetEmpId()
        {
            return CustId;
        }
    }
}
