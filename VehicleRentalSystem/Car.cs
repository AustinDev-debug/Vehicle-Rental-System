using System;

namespace VehicleManagement
{
    class Car : Vehicle
    {
        public int Doors { get; set; }

        public Car(string make, string model, int year, int doors, bool isRented) : base(make, model, year, isRented)
        {
            Doors = doors;
        }
    }
}