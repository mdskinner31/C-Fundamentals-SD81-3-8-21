using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace Comparison
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ComparisonOperators()
        {
            //start w/ our variables
            int age = 25;
            string userName = "Terry";

            //check to see if something is = to something else
            bool equals = age == 41;
            //in this container 
            Console.WriteLine(equals);

            bool userIsTerry = userName == "Terry";
            Console.WriteLine(userIsTerry);
            Console.WriteLine("User is 41:" + equals);

            //using the '!' (bang) operator!
            bool notEqual = age != 122;
            Console.WriteLine($"User is not 122:{notEqual}");

            bool userIsNotJustin = userName != "Justin";
            Console.WriteLine(userIsNotJustin);

            List<string> firstList = new List<string>();
            firstList.Add(userName);

            List<string> secondList = new List<string>();
            secondList.Add(userName);

            //compare the list
            bool listAreEqual = firstList == secondList;
            Console.WriteLine($"The list are equal?: {listAreEqual}");

            //greater than '>'
            bool greaterThan = age > 12;

            //greater than or equal to 
            bool greaterThanOrEqual = age >= 24;
            Console.WriteLine(greaterThanOrEqual);
            //less than
            bool lessThan = age < 66;
            Console.WriteLine(lessThan);

            //less than or equal to
            bool lessThanOrEqualTo = age <= 24;
            Console.WriteLine(lessThanOrEqualTo);

            //we have the or '||'
            bool orValue = equals || lessThan;

            bool trueValue = true;
            bool falseValue = false;

            bool tOrT = trueValue || trueValue;
            bool tOrF = falseValue || falseValue;
            bool fOrT = falseValue || trueValue;
            bool fOrF = falseValue || falseValue;

            Console.WriteLine($"True or True: {tOrT}");
            Console.WriteLine($"True or False: {tOrF}");
            Console.WriteLine($"False or True: {fOrT}");
            Console.WriteLine($"False or False: {fOrF}");

            // and '&&'
            bool andValue = greaterThan && orValue;

            bool tAndT = trueValue && trueValue;
            bool tAndF = trueValue && falseValue;
            bool fAndT = falseValue && trueValue;
            bool fAndF = falseValue && falseValue;

            Console.WriteLine($"True and True: {tAndT}");
            Console.WriteLine($"True and False: {tAndF}");
            Console.WriteLine($"False and True: {fAndT}");
            Console.WriteLine($"False and False: {fAndF}");









        }
    }
}
