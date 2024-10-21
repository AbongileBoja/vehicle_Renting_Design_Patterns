using Vehicle_Renting_Patterns.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Renting_Patterns.Classes
{
    internal class TechHeavydutyVehicle : Technician
    {
        public override string FeatureDescription()
        {
            return "Motorcycle\n";
        }

        public override double Cost()
        {
            return 0;
        }
    }
}