using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Renting_Patterns.Interfaces
{
    public interface ITechnician
    {
        void Attach(IVehicle Observer);
        void Detach(IVehicle Observer);
        void Notify();
    }
}
