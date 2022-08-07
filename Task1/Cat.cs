using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task1
{
    class Cat : Animal
    {
        const string anymalType = "кошка";
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
        public Cat(string name)
            : base(name)
        {
            Name = name;
        }
        public override void Say()
        {
            Console.WriteLine("Мяу!"); ;
        }
    }
}
