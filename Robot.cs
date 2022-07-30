using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    internal class Robot
    {
        private string serialNumber;
        public string Name;
        public Robot(string serialNumber)
        {
            Console.WriteLine("Konstruktor");
            this.serialNumber = serialNumber;
        }
        public void SayHello()
        {
            Console.WriteLine("Cześć, jestem robot .Mój numer seryjny to:" + serialNumber );
        }
        public DateTime GetCurrentDate()
        {
            var currentTime = DateTime.Now;
            return currentTime;
        }
        public static void SayHelloStatic()
        {
            Console.WriteLine("czesc, jestem robot. Wywołałes metodę statyczna ");
        }

    }
}
