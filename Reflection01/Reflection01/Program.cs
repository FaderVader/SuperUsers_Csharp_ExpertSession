using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Linq;

namespace Reflection01
{
    class Program
    {
        static void Main(string[] args)
        {
            var currentAssembly = typeof(Program).Assembly;
            Console.WriteLine(currentAssembly.FullName);
            Console.WriteLine(currentAssembly.Location);
            //Console.ReadKey();

            MyClass myClass = new MyClass();


            var info = currentAssembly //typeof(Program).Assembly
                .GetTypes();
                //.Where(t => t.IsInterface);

            foreach (var item in info)
            {
                Console.WriteLine(item.Name);

            }

            Console.ReadKey();
        }

        static void MyMethod()
        {
            Console.WriteLine("Printing from myMythod");
        }
    }

    public class MyClass
    {        static void MyMethod()
        {
            Console.WriteLine("Printing from myMythod");
        }
    }
}
