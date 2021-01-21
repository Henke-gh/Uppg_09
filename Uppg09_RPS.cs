using System;

namespace Uppg_09
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("This is a game of Rock, paper, scissors!\n\nChoose your weapon..\n");
            Console.WriteLine("Type '1' for Rock, '2' for Paper or '3' for Scissors. Press <ENTER> to confirm.\n");

            int weaponNum = Convert.ToInt32(Console.ReadLine());

            switch (weaponNum)
            {
                case 1:
                    Console.WriteLine("You chose ROCK.");
                    break;
                case 2:
                    Console.WriteLine("You chose PAPER.");
                    break;
                case 3:
                    Console.WriteLine("You chose SCISSORS.");
                    break;
            }


            int pickRPS = randomRPS(1, 3);

            switch (pickRPS)
            {
                case 1:
                    Console.WriteLine("Computer chose ROCK.");
                    break;
                case 2:
                    Console.WriteLine("Computer chose PAPER.");
                    break;
                case 3:
                    Console.WriteLine("Computer chose SCISSORS.");
                    break;
            }

            if (pickRPS == weaponNum)
            {
                Console.WriteLine("You tied!");
            }

            else if (pickRPS == 1 && weaponNum == 2)
            {
                Console.WriteLine("You won!");
            }

            else if (pickRPS == 2 && weaponNum == 3)
            {
                Console.WriteLine("You won!");
            }

            else if (pickRPS == 3 && weaponNum == 1)
            {
                Console.WriteLine("You won!");
            }

            else
            {
                Console.WriteLine("You got beat by ones and zeroes..");
            }
            
            Console.WriteLine("\nJig's up, we're done. Press any key to exit.");
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
