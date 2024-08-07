using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace verisoft
{
    internal class Frog : Animal, ILand, IWater
    {
        private int numOfLeghth = 4;

        public Frog(bool mammals, bool comivorous, int mood)
    : base(mammals, comivorous, mood)
        {
        }
        //public override void SayHello(int times)
        //{
        //    if (mood == (int)Lmood.MOOD_HAPPY)
        //    {
        //        for (int i = 0; i < times; i++)
        //        {
        //            Console.WriteLine("quack!");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("הצפרדע לא במצב רוח לומר שלום.");
        //    }
        //}
        public override void SayHello(int times)
        {
            if (times <= 0)
            {
                SayHello(3);
            }
            else
            {
                for (int i = 0; i < times; i++)
                {
                    Console.Write("quack!");
                }
                Console.WriteLine();
            }
        }
        public override void Whatmood()
        {
             if (mood == (int)Lmood.MOOD_HAPPY)
            {
                Console.Write("is will sing:");
                SayHello(3);
                Console.Write("on the shore");

            }
            else
            {
                Console.WriteLine("it will plop into the water");
            }

        }
        public int GetNumberLegs()
        {
            return numOfLeghth;
        }


        public bool hashGills()
        {
            return false;
        }

        public bool hashLaysEggs()
        {
            return true;
        }

    }
}
