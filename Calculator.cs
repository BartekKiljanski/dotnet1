using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    static class Calculate  
    {   
        static Calculate()
        {
            Console.WriteLine("konstruktor statyczny");
        }
        public static int Sum(int number1, int number2)
        {
            return number1 + number2;
        }
    }
}
