using Vehicle_Renting_Patterns.Abstract;
using Vehicle_Renting_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Renting_Patterns.Classes
{
    internal class SoundSystem : FeatureDecorator
    {
        private Technician _feature;

        public SoundSystem(Technician feature) : base(feature)
        {
            _feature = feature;
        }

        public override string FeatureDescription()
        {
            if (_feature.FeatureDescription().Contains("Motorcycle"))
                return _feature.FeatureDescription() + " Sound System: R1000\n";
            else if (_feature.FeatureDescription().Contains("Light"))
                return _feature.FeatureDescription() + " Sound System: R1200\n";
            else if (_feature.FeatureDescription().Contains("Custom"))
                return _feature.FeatureDescription() + " Sound System: R1200\n";
            else
                return _feature.FeatureDescription() + " Sound System: R1400\n";
        }

        public override double Cost()
        {
            if (_feature.FeatureDescription().Contains("Motorcycle"))
                return _feature.Cost() + 1000;
            else if (_feature.FeatureDescription().Contains("Light"))
                return _feature.Cost() + 1200;
            else if (_feature.FeatureDescription().Contains("Custom"))
                return _feature.Cost() + 1200;
            else
                return _feature.Cost() + 1400;
        }
    }
}