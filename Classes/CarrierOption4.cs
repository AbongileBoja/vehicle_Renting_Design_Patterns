using Vehicle_Renting_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Renting_Patterns.Classes
{
    public class CarrierOption4 : ICarrierBehaviour
    {
        public void CarrierOption()
        {
            Console.WriteLine("20 people max");
        }
    }
}
