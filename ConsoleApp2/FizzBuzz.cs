﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class FizzBuzz
    {
        public int upperbound;
        public void Display()
        {
            for (int i = 1; i<=upperbound ; i++)
            {
                if (i%3 == 0 && i%5 ==0)
                {
                    Console.WriteLine("FizzBuzz");
                }
                else if (i % 3 == 0)
                {
                    Console.WriteLine("Fizz");
                }
                else if (i % 5 == 0)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }



            }
        }
}
}
