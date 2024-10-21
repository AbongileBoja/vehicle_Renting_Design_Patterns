using Vehicle_Renting_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Renting_Patterns.Abstract
{
    internal abstract class FeatureDecorator : Technician
    {
        private Technician _feature = null;

        public FeatureDecorator(Technician feature)
        {
            _feature = feature;
        }

        public override string FeatureDescription()
        {
            return _feature.FeatureDescription();
        }
    }
}