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
            var customers = new List<Customer> { new() { Name = "Adam" }, new() { Name = "John" }, new() { Name = "Jack" } };
            var factory = new FactoryAF(customers);
        
            for (int i = 0; i < 6; i++) factory.AddCar();
        
            Console.WriteLine("\n=== At the start ===");
            Print(factory);
        
            foreach (var customer in customers)
                Console.WriteLine($"Машина продана клиенту: {customer.Name}");
        
            Console.WriteLine("\n=== After sale ===");
            Print(factory);
        }
    
        static void Print(FactoryAF factory)
        {
            Console.WriteLine("Автомобили: " + (factory.Cars.Any() ? string.Join(", ", factory.Cars) : "Нет"));
            Console.WriteLine("Клиенты: " + (factory.Customers.Any() ? string.Join(", ", factory.Customers) : "Нет"));
        }

    }
}
