using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employee
{
    class ProductionWorker : Employee
    {
        public double pay;
        public string assignment;
        enum schedule
        {
            Days, Nights, Weekends,
        }

        public string NewShift { get; private set; }

        public ProductionWorker() { }

        public ProductionWorker(string name, int id, string hireDate, double Pay, string Assignment) : base(name, id, hireDate)
        {
            pay = Pay;
            assignment = Assignment;
        }

        public virtual void Schedule(int myshift)
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
            Console.WriteLine("Hourly Pay Rate: ${0}", pay);
            Console.WriteLine("Assignment: {0}", assignment);
        }
    }
}
