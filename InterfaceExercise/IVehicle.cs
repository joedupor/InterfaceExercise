using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceExercise;

internal interface IVehicle   //Note if written as such, this could use the Extended Interface principle: internal interface IVehicle : ICompany
{

    public string Make { get; set; }

    public string Model { get; set; }

    public int Year { get; set; }

    public int NumWheels { get; set; }

    

}
