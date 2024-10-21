using Vehicle_Renting_Patterns.Abstract;
using Vehicle_Renting_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Renting_Patterns.Classes
{
    internal class CustomVehicle : Vehicle
    {
        private ITechnician Technician;

        public CustomVehicle(ICarrierBehaviour CarrierBehaviour, IEngineBehaviour EngineBehaviour, ITowBehaviour TowBehaviour) : base(CarrierBehaviour, EngineBehaviour, TowBehaviour)
        {
            this.Name = "Custom Vehicle";
        }

        public CustomVehicle(ITechnician Technician)
        {
            this.Technician = Technician;
            this.Technician.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine("R" + ((Technician)this.Technician).getState());
        }
    }
}