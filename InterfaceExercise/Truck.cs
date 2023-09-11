using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class Truck : IVehicle, ICompany
    {

        public bool HasBed { get; set; }
        public int BedSize { get; set; }


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int NumWheels { get; set; }


        public int FoundingDate { get; set; }
        public string Name { get; set; }
    }
}
