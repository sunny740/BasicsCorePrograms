using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class EvenorOdd
    {
        public void Numbers()
        {
            int Number;
            int Rem;

            Console.WriteLine("Enter number to check whether it is even or odd");
            Number = Convert.ToInt32(Console.ReadLine());
            Rem = Number % 2;

            if (Rem == 0)
            {
                Console.WriteLine("{0} Is an Even number", Number);
            }
            else
            {
                Console.WriteLine("{0} Is an Odd number", Number);
            }
        }
    }
}
