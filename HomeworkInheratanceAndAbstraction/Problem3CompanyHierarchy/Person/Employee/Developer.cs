using System;
using System.Net;
using Employee = global.Problem3CompanyHierarchy.Person.Employee.Employee;

namespace global::Problem3CompanyHierarchy.Person.Employee
{
    class Developer:Employee
    {
        private string projectName;
        private DateTime startDate;
        private string details;
        private string state="open";

        void CloseProject()
        {
            state = "closed";
        }
    }
}
