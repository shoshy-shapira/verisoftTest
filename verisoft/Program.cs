using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verisoft
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat(true, true, 1);
            cat.WhatMood();
            cat.SayHello(3);
            cat.SayHello();
            cat.SayHello(-1);
            Console.WriteLine(cat);

            Animal cat2 = new Cat(true, true,0);
            cat.WhatMood();
            cat.SayHello(3);
            cat.SayHello();
            cat.SayHello(-1);
            Console.WriteLine(cat2);

            Dog dog = new Dog(true, true,0);
            dog.WhatMood();
            dog.SayHello(3);
            dog.SayHello();
            dog.SayHello(-1);
            Console.WriteLine(dog);

            Frog frog = new Frog(true, true, 0);
            frog.WhatMood();
            frog.SayHello(3);
            frog.SayHello(-1);
            frog.SayHello();
            frog.ToString();
            Console.WriteLine(frog);


            Console.ReadLine();

        }
    }
}
