
namespace TestNPLabDB
{
    using NPLab.Data;
    using NPLab.Models;
    using System;
    using System.Linq;

    public class StartUp
    {
        public static void Main()
        {
            DateTime localDate = DateTime.Now;

            var db = new NPLabDbContext();

            var engineer = new Engineers
            {
                FirstName = "Malin",
                LastName = "Zhelev",
                Time = localDate
            };

            db.Engineers.Add(engineer);
            db.SaveChanges();

            Console.WriteLine(db.Engineers.Count());
        }
    }
}
