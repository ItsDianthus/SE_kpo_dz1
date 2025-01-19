using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KPO_DZ_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var customers = new List<Customer>
            {
            new() { Name = "Adam" },
            new() { Name = "John" },
            new() { Name = "Jack" },
            };

            var factory = new FactoryAF(customers);

            for (int i = 0; i < 6; i++)
                factory.AddCar();

            Console.WriteLine("At the start");

            Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));

            Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));

            factory.SaleCar();

            Console.WriteLine("After sale");

            Console.WriteLine(string.Join(Environment.NewLine, factory.Cars));

            Console.WriteLine(string.Join(Environment.NewLine, factory.Customers));
        }
    }
}
