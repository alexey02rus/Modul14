using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Dog : Animal
    {
        const string anymalType = "собака";
        public override string Name { get; set; }
        public override string AnymalType
        {
            get
            {
                return anymalType;
            }
            set
            {
                AnymalType = anymalType;
            }
        }
        public Dog(string name)
            : base(name)
        {
            Name = name;
        }
        public override void Say()
        {
            Console.WriteLine("Гав!"); ;
        }
    }
}
