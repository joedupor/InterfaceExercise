using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise
{
    internal class SUV : IVehicle, ICompany
    {

        public bool HasThirdRow { get; set; }

        public int NumberOfSUVSeats { get; set; }


        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public int NumWheels { get; set; }


        public int FoundingDate { get; set; }
        public string Name { get; set; }
    }
}
