﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCorePrograms
{
    public class QuotientAndRemainder
    {
        public void Compute()
        {
            int Dividend = 0;
            int Divisor = 0;

            Console.Write("Calculate the Dividend:"); //Input From Dividend
            Dividend = Convert.ToInt32(Console.ReadLine());//reading Dividend input from user
            Console.Write("Calculate the Divisor:"); //Input From Divisor
            Divisor = Convert.ToInt32(Console.ReadLine());//reading Divisor input from user
            int AndQuotient = Dividend / Divisor;  //calculate example (5/2)
            int AndRemainder = Dividend % Divisor; // calculate example (5%2)
            Console.WriteLine("Dividend:{0} Divisor:{1}", Dividend, Divisor); //redaing op
            Console.WriteLine("Quotient = " + AndQuotient); //op for Quotient
            Console.WriteLine("Remainder = " + AndRemainder); //Op for Remainder
            Console.ReadLine();
        }
    }
}
