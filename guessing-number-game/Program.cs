using System;

namespace guessing_number_game
{
    class Program
    {
        static void Main(string[] args)
        {
            Random ranNumber = new Random();
            int num = ranNumber.Next(0, 100);
            
            bool winStatus = false;
            do
            {
                Console.Write("Guess a number between 0 to 100 that you think right: ");
                string s = Console.ReadLine();
                int i = int.Parse(s);
                if (i < num)
                {
                    Console.WriteLine("Too low, you must guess higher...");
                }
                else if (i > num)
                {
                    Console.WriteLine("Too high, you must guess lower...");
                }
                else if (i == num)
                {
                    Console.WriteLine("You win, so lucky :)");
                    winStatus = true;
                }
            } while (!winStatus);
            Console.ReadKey();
        }
    }
}
