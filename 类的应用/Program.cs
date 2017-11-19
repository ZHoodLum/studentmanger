using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 类的应用
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat c1 = new Cat();
            c1.Weight = 20;
            Cat.Eat();
            Console.WriteLine(c1.Weight);
            Console.WriteLine(c1.Swarm());
            Console.ReadLine();

        }
    }

}
