using System;
using System.Collections.Generic;
using System.Linq;

namespace LambdasFuncTToQuery
{
    class Program
    {
        static void Main(string[] args)
        {
            var custs = new List<Customer> 
            {
                new Customer{City = "Phoenix",FirstName = "John",LastName="Doe",Id=1 },
                new Customer{City = "Phoenix",FirstName = "Jane",LastName="Doe",Id=500 },
                new Customer{City = "Seatle",FirstName = "Suki",LastName="Pizaro",Id=3 },
            };

            var phxCusts = custs
                .Where(c => c.City == "Phoenix" && c.Id < 500)
                .OrderBy(c => c.FirstName);

            foreach(var cust in phxCusts)
            {
                Console.WriteLine(cust.FirstName);
            }
            var worker = new Worker();
            worker.WorkPerformed += (s, e) =>
            {
                Console.WriteLine("Worked : " + e.Hours + "hours doing: " + e.WorkType);
                Console.WriteLine("Some Other value");
            };
            worker.WorkCompleted += (s, e) => Console.WriteLine("Work is done");


            worker.DoWork(8, WorkType.GenerateReports);

            Console.Read();
        }

        

    }
}
