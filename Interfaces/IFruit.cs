using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Interfaces
{
    //This is our contract
    //anything that implements IFruit must adhere to the contract
    //and do all of its methods and all of its properties

    public interface IFruit
    {
        string Name { get; }

        bool IsPeeled { get; set; }

        string Peel();
    }
   // public interface IOrange : IFruit
}
