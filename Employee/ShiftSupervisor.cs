using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class ShiftSupervisor : Employee
    {
        public double salary { get; private set; }
        enum schedule
        {
            Days, Nights, Weekends,
        }

        public string NewShift { get; private set; }
        public ShiftSupervisor() { }

        public ShiftSupervisor(string name, int id, string hireDate, double Salary) : base(name, id, hireDate)
        {
            salary = Salary;
        }

        public void AnnBonus(double Bonus) => salary += Bonus;

        public void Schedule(int myshift)
        {
            if (myshift == 1)
            {
                schedule NewShift = schedule.Days;
                Console.WriteLine("Shift: {0}", NewShift);
            }
            else if (myshift == 2)
            {
                schedule NewShift = schedule.Nights;
                Console.WriteLine("Shift: {0}", NewShift);
            }
            else if (myshift == 3)
            {
                schedule NewShift = schedule.Weekends;
                Console.WriteLine("Shift: {0}", NewShift);
            }
            else
            {
                Console.WriteLine("Not a valid shift");
            }
        }

        public override void DisplayStats()
        {
            Console.WriteLine("Name: {0}", name);
            Console.WriteLine("Id: {0}", id);
            Console.WriteLine("Hire Date: {0}", hireDate);
            Console.WriteLine("Yearly Salary: ${0}", salary);
        }
    }
}
