using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
   public class Banana : IFruit
    {
        public string Name
        {
            get
            {

                return "Banana";
            }
        }

        public bool IsPeeled { get; set; }

        public Banana()
        {

        }
        public Banana(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }


        public string Peel()
        {
            IsPeeled = true;
            return $"I peeled a {Name}";
        }

    }

    //We are going to make extra classes here but they
    //should go in their own file
    //these are classes and they implement ':' an interfacde
    //IFruit

    public class Orange : IFruit
    {
        public string Name { get { return "Orange"; } }
        
        public bool IsPeeled { get ; set ; }

        public Orange()
        {

        }

        public Orange(bool isPeeled)
        {
            IsPeeled = isPeeled;
        }

        public string Peel()
        {
            IsPeeled = true;
            return "You peeled an Orange";
        }

        public string Squeeze()
        {
            return "You squeezed the Orange....";

        }

    }

    public class Grape : IFruit
    {
       public string Name { get { return "Grape"; } }

       public bool IsPeeled { get; set; }

       public string Peel()
        {
            return "Who peels grapes?";
        }
    }
}
