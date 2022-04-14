using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOfTwo2
    {
        public void PowerTable()
        {
            int i = 0;
            Console.WriteLine("Please Enter The Number : ");
            int Num = Convert.ToInt32(Console.ReadLine());
            for (i = 1; i <= Num; i++)
            {
                Console.WriteLine("2" + " " + "^" + " " + i + " = " + Math.Pow(2, i));
            }
        }
    }
}
