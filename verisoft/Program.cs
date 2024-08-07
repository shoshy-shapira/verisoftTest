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
            cat.Whatmood();
            cat.SayHello(3);
            cat.SayHello();
            cat.SayHello(-1);

            Dog dog = new Dog(true, true,0);
            dog.Whatmood();
            dog.SayHello(3);
            dog.SayHello();
            dog.SayHello(-1);

            Frog frog = new Frog(true, true, 0);
            frog.Whatmood();
            frog.SayHello(3);
            frog.SayHello(-1);
            frog.SayHello();



            Console.ReadLine();

        }
    }
}
