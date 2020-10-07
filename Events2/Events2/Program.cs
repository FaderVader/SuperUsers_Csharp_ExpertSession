using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Events2
{
    class Program
    {
        static bool accept = true;
        static void Main(string[] args)
        {
            string navn = "";
            int alder = 0;
            Person person = new Person();

            Console.WriteLine("Hvad hedder den?");
            navn = Console.ReadLine();
            Console.WriteLine("Hvor gammel er den?");
            alder = int.Parse(Console.ReadLine());

            person.TooOld += Person_TooOld; ;
            person.Alder = alder;
            person.Navn = navn;

            if (accept)
            {
                Console.WriteLine(person);
                Console.ReadKey();
            }
        }

        private static void Person_TooOld(object sender, TooOldEventArgs e)
        {
            accept = false;
            Console.WriteLine($"Personen er for gammel: {e.Alder}");
            Console.ReadKey();
        }
    }
}
