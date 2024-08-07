using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verisoft
{
    public class Cat: Animal, ILand
    {
        private int numOfLeghth = 4;

        public Cat(bool mammals, bool comivorous, int mood) : base(mammals, comivorous, mood)
        {

        }

        //public override void SayHello()
        //{
        //    if (mood == (int)Lmood.MOOD_HAPPY)
        //    {
        //        Console.WriteLine("meou!");
        //    }
        //    else
        //    {
        //        Console.WriteLine("The cat is in no mood to say hello");
        //    }
        //}

        //public override void SayHello(int times)
        //{
        //    if (mood == (int)Lmood.MOOD_HAPPY)
        //    {
        //        for (int i = 0; i < times; i++)
        //        {
        //            Console.WriteLine("meow!");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("The cat is in no mood to say hello.");
        //    }
        //}

        //public override void SayHello()
        //{
        //}

        public override void SayHello(int times)
        {
            if (times <= 0)
            {
                SayHello();
            }
            else
            {
            for (int i = 0; i < times; i++)
                {
                    Console.Write("meow!");
                }
                Console.WriteLine();

            }
            
        }

        public override void Whatmood()
        {
            if (mood == (int)Lmood.MOOD_HAPPY)
            {
                Console.WriteLine("purr, purr!");
            }
            else
            {
                Console.WriteLine("hiss");

            }
        }


        public int GetNumberLegs()
        {
            return numOfLeghth;
        }


    }
}
