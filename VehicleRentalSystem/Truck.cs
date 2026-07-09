using System;
namespace VehicleManagement
{
    class Truck : Vehicle
    {
        public int TowingPower { get; set; }

        public Truck(string make, string model, int year, int towingPower, bool isRented) : base(make, model, year, isRented)
        {
            TowingPower = towingPower;
        }
    }
}