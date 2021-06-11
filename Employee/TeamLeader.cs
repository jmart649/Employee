using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    sealed class TeamLeader : ProductionWorker
    {
        public double monthlyBonus;
        public int reqHours { get; private set; }
        public TeamLeader() { }

        public TeamLeader(string name, int id, string hireDate, double pay, string assignment, double MonthlyBonus, int ReqHours) : base(name, id, hireDate, pay, assignment)
        {
            monthlyBonus = MonthlyBonus;
            reqHours = ReqHours;
        }

        public void trainingHours(int attendedHrs) => reqHours -= attendedHrs;

        public override void Schedule(int myshift)
        {
            base.Schedule(myshift);
        }
        public override void DisplayStats()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Hire Date: {0}", hireDate);
            Console.WriteLine("Hourly Pay Rate: ${0}", pay);
            Console.WriteLine("Assignment: {0}", assignment);
            Console.WriteLine("Monthly Bonus: ${0}", monthlyBonus);
            Console.WriteLine("Required Training Hours: {0}", reqHours);
        }
    }
}
