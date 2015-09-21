using System;
using Employee = global.Problem3CompanyHierarchy.Person.Employee.Employee;

namespace global::Problem3CompanyHierarchy.Person.Employee
{
    class SalesEmployee:Employee
    {
        private string productName;
        private DateTime date;
        private decimal price;
    }
}
