using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsolePerson
{
    class Program
    {
        static void Main(string[] args)
        {
            MyContext ctx = new MyContext();

            Console.WriteLine("Hvad hedder personen?");
            string navn = Console.ReadLine();
            Person p = new Person() { Navn = navn };

            ctx.Personer.Add(p);
            ctx.SaveChanges();
            Console.WriteLine("OK");            

            var liste = ctx.Personer.ToList();
            liste.ForEach(l => Console.WriteLine($"{l.Navn}:{l.Id}"));
            Console.ReadKey();
        }
    }
}
