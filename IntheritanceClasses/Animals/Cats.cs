using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntheritanceClasses
{
    public class Cats : Animals
    {
        public Cats()
        {
            Console.WriteLine("This is a cat consrtuctor.");
            IsMammal = true;
            DietType = DietType.Carnivore;
        }
        public bool IsEvil { get; set; }

        public int HowManyWhiskers { get; set; }

        public string Color { get; set; }

        public string HarirLength { get; set; }

        public virtual void MakesSound()
        {
            Console.WriteLine("Meow");
        }

        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} moves quickly!");
        }

    }
    public class Liger : Cats
    {
        public Liger()
        {
            Console.WriteLine("This is the Liger contructor.");
        }

        public override void Move()
        {
            Console.WriteLine($"The {GetType().Name} stalks its prey.");
        }
        public override void MakesSound()
        {
            Console.WriteLine("Roar.");
        }
    }
    public class Lion : Cats
    {
        public Lion()
        {
            Console.WriteLine("This is a Lion Contructor");
        }
        public override void MakesSound()
        {
            Console.WriteLine("Twinkle Toes");
        }
    }
}

