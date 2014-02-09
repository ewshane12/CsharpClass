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
            int stepsTaken = 0;
            int totalSteps = 0;
            int xPos = 0, yPos = 0;
            int i = 0;
            float sumX = 0, sumY = 0;
            Boolean done = true;

            Random random = new Random();//Create a new random instance
            Console.WriteLine("Pls give me the number of steps I should take!");
            totalSteps = Convert.ToInt32(Console.ReadLine());

            while (done)
            {
                xPos = yPos = 0;
                for (stepsTaken = 0; stepsTaken <= totalSteps; stepsTaken++)
                {

                    int step = random.Next(100);//generate numbers between 0 and 99
                    switch (step % 4)
                    {
                        case 0:
                            xPos++;
                            break;
                        case 1:
                            xPos--;
                            break;
                        case 2:
                            yPos++;
                            break;
                        case 3:
                            yPos--;
                            break;
                    }
                    i++;//loop counter
                    if(i == 100)
                        done = false;
                    sumX += xPos;
                    sumY += yPos;
                } 
            }
            sumX /= 100; // /= looks like a sad face
            sumY /= 100;
            Console.WriteLine("Phew! I wound up here a lot! ({0} {1})",sumX,sumY);
            Console.ReadKey();
        }
    }
}
