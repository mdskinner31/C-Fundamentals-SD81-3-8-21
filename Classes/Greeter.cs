using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    public class Greeter
    {
        public void SayHello(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        public void SayHello()
        {
            Console.WriteLine("Hello");
        }

        Random _random = new Random();
        public void GetRandomGreeting()
        {
            string[] availableGreeting = new string[] { "Good Morning", "What's Up", "Howdy", "Aloha" };
            int randomNumber = _random.Next(0, availableGreeting.Length);
            string randomGreeting = availableGreeting.ElementAt(randomNumber);
            Console.WriteLine($"{randomGreeting}");
        }
            
    }
}
