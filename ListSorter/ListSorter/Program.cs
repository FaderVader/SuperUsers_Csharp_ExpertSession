using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSorter
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> liste = new List<Person>();
            liste.Add(new Person() { Alder = 12, Name = "Suliman" });
            liste.Add(new Person() { Alder = 10, Name = "Ernst" });
            liste.Add(new Person() { Alder = 20, Name = "Susi" });

            liste.Sort();

            foreach (var item in liste)
            {
                Console.WriteLine($"Navn: {item.Name}  Alder:{item.Alder}");
            }

            Console.ReadKey();

        }
    }

    public class Person : IComparable
    {
        public string Name { get; set; }

        public int Alder { get; set; }

        public int CompareTo(object person)
        {
            return ((Person)person).Alder - ((Person)this).Alder;
        }
    }
}
