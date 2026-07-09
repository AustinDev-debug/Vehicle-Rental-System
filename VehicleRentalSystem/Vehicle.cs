using System;
namespace VehicleManagement
{
    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public int Year { get; set; }
        public bool IsRented { get; set; }


        public Vehicle(string make, string model, int year, bool isRented)
        {
            Make = make;
            Model = model;
            Year = year;
            IsRented = isRented;
        }
    }
}