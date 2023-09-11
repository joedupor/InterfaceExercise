using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Car : IVehicle, ICompany
    {
        public bool HasTrunk { get; set; }

        public bool IsConvertible { get; set; }


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int NumWheels { get; set; }


        public int FoundingDate { get; set; }
        public string Name { get; set; }
    }


}
