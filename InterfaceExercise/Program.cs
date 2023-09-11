using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ConstrainedExecution;

namespace InterfaceExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            //done - TODO Be sure to follow BEST PRACTICES when creating classes and interfaces

            //done - Create 2 Interfaces called IVehicle & ICompany

            //done - Create 3 classes called Car , Truck , & SUV

            //done - In your IVehicle

            /* Create 4 members that Car, Truck, & SUV all have in common.
             * Example: All vehicles have a number of wheels... for now..
             */


            //done - In ICompany

            /*Create 2 members that are specific to each every company
             * regardless of vehicle type.
             *
             *
             * Example: public string Logo { get; set; }
             */

            //done - In each of your car, truck, and suv classes

            /*Create 2 members that are specific to each class
             * Example: truck has a bed size while car has a trunk while suv has a cargo hold size
             *
             * Then, Set each class to inherit from both IVehicle and ICompany and implement their members.
             * 
             */

            //done - Now, create objects of your 3 classes and give their members values


            Car car1 = new Car()
            {
                HasTrunk = true,
                IsConvertible = false,
                Year = 2021,
                Make = "Ford",
                Model = "Focus",
                NumWheels = 4,
                FoundingDate = 1901,
                Name = "Ford Motor Company",
            };


            Truck truck1 = new Truck()
            {
                HasBed = true,
                BedSize = 25,
                Year = 2022,
                Make = "Dodge",
                Model = "Ram 2500",
                NumWheels = 4,
                FoundingDate = 1902,
                Name = "Chrysler",

            };

            SUV suv1 = new SUV()
            {
                HasThirdRow = true,
                NumberOfSUVSeats = 8, 
                Year = 2023,
                Make = "Nissan",
                Model = "Pathfinder",
                NumWheels = 4,
                FoundingDate = 1951,
                Name = "Nissan Masters",
            };


            //done - Creatively display and organize their values

            List<IVehicle> vehicles1 = new List<IVehicle>() {car1, truck1, suv1};
            List<ICompany> vehicles2 = new List<ICompany>() {car1, truck1, suv1};

            // Alternatively can be added as such:
            //vehicles.Add(car1);
            //vehicles.Add(truck1);
            //vehicles.Add(suv1);

            foreach (IVehicle item in vehicles1)
            {
                Console.WriteLine($"{item.NumWheels}wheel, {item.Year}"); //HasTrunk = {item.HasTrunk}, IsConvertible = false is a:");
                Console.WriteLine($"Make: {item.Make}");
                Console.WriteLine($"Model: {item.Model}");
                Console.WriteLine();
            }

            Console.WriteLine($"-------------------------------");

            foreach (var item in vehicles2)
            {
                Console.WriteLine($"Made by: {item.Name}");
                Console.WriteLine($"Since: {item.FoundingDate}");
                Console.WriteLine();
            }
        }
    }
}
