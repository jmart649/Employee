using System;

namespace Employee
{
    class Program
    {
        static void Main(string[] args)
        {
            ProductionWorker Jesse = new ProductionWorker("Jesse", 1234, "07-15-2010", 10.00, "Computer I.T");
            Jesse.DisplayStats();
            Jesse.Schedule(1);
            Console.WriteLine("");

            ShiftSupervisor Carlos = new ShiftSupervisor("Carlos", 4444, "05-06-2012", 50_000);
            Carlos.AnnBonus(500);
            Carlos.DisplayStats();
            Carlos.Schedule(3);
            Console.WriteLine("");

            TeamLeader Karla = new TeamLeader("Karla", 5555, "07-08-2011", 15.00, "Team Leader", 200, 10);
            Karla.trainingHours(5);
            Karla.DisplayStats();
            Karla.Schedule(2);
        }
    }
}
