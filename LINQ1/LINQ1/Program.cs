using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LINQ1
{
    class Program
    {
        static void Main(string[] args)
        {
            kursusEntities kursusEnt = new kursusEntities();

            string countryOfInterest = "Germany";
            var customers = kursusEnt.Customers.Where(c => c.Country == countryOfInterest).ToList(); 
            
            customers.ForEach(c => Console.WriteLine($"Kunden {c.CompanyName} har afgivet {c.Orders.Count} ordre(r)"));
            Console.ReadKey();
        }
    }
}
