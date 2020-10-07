using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events
{
    class Program
    {
        static bool accepted = true;
        static void Main(string[] args)
        {
            string navn;
            int alder;
            

            Person person = new Person();
            person.TooOld += onTooOld;

            Console.WriteLine("Anfør personens navn:");
            navn = Console.ReadLine();

            Console.WriteLine("Anfør personenens alder:");
            alder = int.Parse(Console.ReadLine());

            person.Alder = alder;
            person.Navn = navn;

            if (accepted)
            {
                Console.WriteLine($"Personen hedder {person.Navn} og er {person.Alder} år gammel.");                
            }

            Console.ReadKey();


        }

        private static void onTooOld(object sender, CustomEvents e)
        {
            Console.WriteLine($"Den angivne person er for gammel: {e.Alder}");
            accepted = false;
        }
    }
}
