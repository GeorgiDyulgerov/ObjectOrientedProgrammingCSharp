using System;

namespace Problem1HumanWorkerStudent
{
    class Worker:Human
    {
        private int weekSalary;
        private int workHoursPerDay;
        public Worker(string firstName, string lastName,int weekSalary,int workHoursPerDay) : base(firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary { get; set; }
        public int WorkHoursPerDay { get; set; }

        public decimal MoneyPerHour()
        {
            return this.WeekSalary/(this.WorkHoursPerDay*5);
        }

        public override string ToString()
        {
            string result = base.ToString();
            result += String.Format("   -Week Salary:{0}    -Work Hours Per Day:{1}", this.WeekSalary,
                this.WorkHoursPerDay);
            return result;
        }
    }
}
