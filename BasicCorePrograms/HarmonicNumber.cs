﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class HarmonicNumber
    {
        public void Number()
        {
            int num = 0;
            double Result = 0.0;
            Console.Write("Input the number: ");//i/p from user

            num = Convert.ToInt32(Console.ReadLine());

            for (int i = 1; i <= num; i++) //For loop if var is 1 it will check if 1< num den it will increment by 1
            {
                Result += 1 / (float)i;  //calculate result = 0.0+1/ 1
                Console.Write("1/{0} + ", i);   //1/1 +1/2+1/3........,or 1 or 2 etc
            }
            Console.WriteLine($"= {Result}");  //result or op
            Console.ReadLine();
        }
    }
}
