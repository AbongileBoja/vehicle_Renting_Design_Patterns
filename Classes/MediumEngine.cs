using Vehicle_Renting_Patterns.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicle_Renting_Patterns.Classes
{
    public class MediumEngine : IEngineBehaviour
    {
        public void Engine()
        {
            Console.WriteLine("Medium Engine");
        }
    }
}