using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ARandomWalk
{
    class Program
    {
        static void Main(string[] args)
        {
            int i = 0;
            Random random = new Random();//Create a new random instance
            while(i<10)
            {
                int step = random.Next(100);//generate numbers between 0 and 99
                Console.WriteLine("{0}",step);
                i++;
            }
            Console.ReadKey();
            //goals: I take user input for the number of steps, average the location over 100 runs. Print out the average location.
        }
    }
}
