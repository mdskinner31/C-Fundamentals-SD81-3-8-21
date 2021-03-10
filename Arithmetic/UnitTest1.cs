using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace Arithmetic
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void SimpleOperators()
        {
            int a = 22;
            int b = 15;

            //Addition '+'
            int sum = a + b;
            // This is shorthand addition
            sum += 3;
            Console.WriteLine(sum);

            //subtraction '-'
            int difference = a - b;
            // difference -=3 
            Console.WriteLine(difference);

            //multiplication '*'
            int product = a * b;
            // product *=3;
            Console.WriteLine(product);

            //division '/'
            int quotient = a / b;
            Console.WriteLine(quotient);

            //Modulous
            int remainder = a % b;
            Console.WriteLine(remainder);

            DateTime now = DateTime.Now;
            DateTime someday = new DateTime(1973, 3, 16);

            TimeSpan timespan = now - someday;
            Console.WriteLine(timespan.Days);







        }
    }
}
