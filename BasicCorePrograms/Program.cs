using System;

namespace BasicCorePrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Programs");
            bool end = true;
            Console.WriteLine("1. FlipCoin\n2. Leap Year\n3. Power Of Two Table\n4. End the Program");
            while (end == true)
            {
                Console.WriteLine("Take an option to execute");
                int option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 1:
                        FlipCoins flipCoin = new FlipCoins();
                        flipCoin.FlipCoin();
                        break;
                    case 4:
                        end = false;
                        break;

                    default:
                        Console.WriteLine("Enter Proper Option To Execute");
                        break;
                }
            }
        }
    }
}
