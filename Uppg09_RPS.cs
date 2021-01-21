using System;

namespace Uppg_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a game of Rock, paper, scissors!\n\nChoose your weapon..\n");


            int pickRPS = randomRPS(0,2);
                
                switch (pickRPS)
             {
                     case 0:
                        Console.WriteLine("Computer chose ROCK.");
                        break;
                    case 1:
                        Console.WriteLine("Computer chose PAPER.");
                        break;
                    case 2:
                        Console.WriteLine("Computer chose SCISSORS.");
                        break;
                }


            Console.ReadKey();
        }

        public static int randomRPS(int minValue, int maxValue)
        {
            Random numberGenerator = new Random();

            int rRPS = numberGenerator.Next(minValue, maxValue + 1);

            return rRPS;
        }
    }
}
