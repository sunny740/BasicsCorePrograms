using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class PowerOfTwo
    {
        public void Power()
        {
            int num = 0;

            Console.Write("Enter a number:");//input from User
            num = Convert.ToInt32(Console.ReadLine());
            int result = num * num; //num*2 if 2*2==4
            Console.WriteLine(result);//Op
            Console.ReadLine();
        }
    }
}
