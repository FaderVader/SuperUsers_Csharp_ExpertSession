using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IComparableX
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> liste = new List<Person>() {
                new Person() { Alder = 12, Navn = "Jakob" },
                new Person() { Alder = 13, Navn = "Jacobina"},
                new Person() { Alder = 14, Navn = "Ernst" }
            };

            liste.Sort();

            foreach (var person in liste)
            {
                Console.WriteLine($"Denne person, {person.Navn} er {person.Alder} år gammel.");
            }

            Console.ReadKey();
        }
    }

    //public class Person : IComparable
    //{        
    //    public string Navn { get; set; }
    //    public int Alder { get; set; }

    //    public int CompareTo(object obj)
    //    {
    //        return ((Person)obj).Alder - this.Alder;
    //    }
    //}

    public class Person : IComparable<Person> // using generics
    {
        public string Navn { get; set; }
        public int Alder { get; set; }

        public int CompareTo(Person person)
        {
            return person.Alder - this.Alder;
        }
    }
}
