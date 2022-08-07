using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat catMurka = new Cat("Мурка");
            catMurka.ShowInfo();
            Console.WriteLine();
            Dog dogSharik = new Dog("Шарик");
            dogSharik.ShowInfo();
            Console.ReadKey();
        }
    }
}
