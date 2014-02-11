using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int steps = 0;
            int total = 0;
            int PosX = 0;
            int PosY = 0;
            int i = 0;
            float Xsum = 0;
            float Ysum = 0;

            Random random = new Random();// instantiates a new random instance
            Console.WriteLine("Please tell me how many steps to take.");
            total = Convert.ToInt32(Console.ReadLine());
           

            if (total == total)
            {
                PosX = 0;
                PosY = 0;
                for (steps = 0; steps <= total; steps++)
                {
                    int step = random.Next(100);//gives a random number from 0-99
                    switch (step % 4)
                    {
                        case 0:
                            PosX++;
                            break;
                        case 1:
                            PosX--;
                            break;
                        case 2:
                            PosY++;
                            break;
                        case 3:
                            PosY--;
                            break;
                    }
                    
                    i++;//increases until user input is reached
                    if (i == total) 
                        Xsum += PosX;
                        Ysum += PosY;
                }

            }
            Xsum /= 100;//means Xsum = Xsum / 100
            Ysum /= 100;
            Console.WriteLine("Here are my average coordinates, ({0},{1})", Xsum, Ysum);
            Console.ReadLine();
        }
    }
}
