using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {

            try
            {   
                var isTrue = true;
                if (isTrue)
                {

                }
                Console.WriteLine("Podaj 1 liczbę ");

                var number1 = GetInput();


                Console.WriteLine("Jaką operacje checsz wykonać? Możliwe operacje To : '+', '-', '/', '*'. ");
                var action = Console.ReadLine();

                Console.WriteLine("Podaj 2 liczbę ");
                var number2 = GetInput();



                var result = Calculate(number1, number2, action);


                Console.WriteLine("Wynik Twojego działania To:" + result);

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.ReadLine();
            }
        }
           private static int GetInput()
    {
        if (!int.TryParse(Console.ReadLine(), out int input))

            throw new Exception("Podana wartość jest nieprawidłowa.");
        return input;
    }

    private static int Calculate(int number1, int number2, string action)
        {
            switch (action)
            {
                case "+":
                    return  number1 + number2;
                    break;
                case "-":
                    return number1 - number2;
                    break;
                case "/":
                    return  number1 / number2;
                    break;
                case "*":
                    return number1 * number2;
                    break;
                default:
                    throw new Exception("Wybrałeś złą operację");
            }
        }
    }
}
