using System;

namespace BasicCorePrograms
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Basic Programs");
            bool end = true;
            Console.WriteLine("1. FlipCoin\n2. Leap Year\n3. Power Of Two Table\n4. HarmonicNumbers\n5. Factors\n6. QuotientAndRemainder\n7. SwapTwoNumbers\n8. EvenorOdd\n9. End the Program");
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
                    case 2:
                        LeapYear Leap = new LeapYear();
                        Leap.LeapYears();
                        break;
                    case 3:
                        PowerOfTwo Power = new PowerOfTwo();
                        Power.Power();
                        break;
                    case 4:
                        HarmonicNumber Numbers = new HarmonicNumber();
                        Numbers.Number();
                        break;
                    case 5:
                        Factors facto = new Factors();
                        facto.Factorial();
                        break;
                    case 6:
                        QuotientAndRemainder Quto = new QuotientAndRemainder();
                        Quto.Compute();
                        break;
                    case 7:
                        SwapTwoNumbers Number = new SwapTwoNumbers();
                        Number.Numbers();
                        break;
                    case 8:
                        EvenorOdd Num = new EvenorOdd();
                        Num.Numbers();
                        break;
                    default:
                        Console.WriteLine("Enter Proper Option To Execute");
                        break;
                }
            }
        }
    }
}
