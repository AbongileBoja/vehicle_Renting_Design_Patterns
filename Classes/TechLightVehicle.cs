using Vehicle_Renting_Patterns.Abstract;
using Vehicle_Renting_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Renting_Patterns.Classes
{
    internal class TechLightVehicle : Technician
    {
        public override string FeatureDescription()
        {
            return "Light Vehicle\n";
        }

        public override double Cost()
        {
            return 0;
        }
    }
}