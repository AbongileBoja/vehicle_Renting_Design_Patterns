using Vehicle_Renting_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Renting_Patterns.Abstract
{
    internal abstract class Technician : ITechnician
    {
        public abstract string FeatureDescription();

        public abstract double Cost();

        public double stateCost { get; set; }

        private List<IVehicle> Observers = new List<IVehicle>();

        public void Attach(IVehicle observer)
        {
            Observers.Add(observer);
        }

        public void Detach(IVehicle observer)
        {
            Observers.Remove(observer);
        }

        public void Notify()
        {
            foreach (IVehicle observer in Observers)
                observer.Update();
        }

        public void setState(double cost)
        {
            this.stateCost = cost;
            Notify();
        }

        public double getState()
        {
            return this.stateCost;
        }
    }
}