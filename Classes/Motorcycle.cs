using Vehicle_Renting_Patterns.Abstract;
using Vehicle_Renting_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Renting_Patterns.Classes
{
    internal class Motorcycle : Vehicle
    {
        private ITechnician Technician;

        public Motorcycle() : base(new CarrierOption2(), new SmallEngine(), new NoTow())
        {
            this.Name = "Motorcycle";
        }

        public Motorcycle(ITechnician Technician) : base(new CarrierOption2(), new SmallEngine(), new NoTow())
        {
            this.Technician = Technician;
            this.Technician.Attach(this);
        }

        public override void Update()
        {
            Console.WriteLine(((Technician)this.Technician).getState().ToString("C"));
        }
    }
}