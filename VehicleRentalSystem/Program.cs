// Vehicle rental system by AustinDev-Debug
using System;

namespace VehicleManagement
{
    class Program
    {
        List<Vehicle> vehicles = new List<Vehicle>();
        static void Main(string[] args)
        {
            Program program = new Program();
            bool runProgram = true; 
            while(runProgram)
            {
                Console.WriteLine("Select from the following options\n" +
                    "1. Add Car\n" +
                    "2. Add Truck\n" +
                    "3. List Vehicles\n" +
                    "4. Search Vehicle\n" +
                    "5. Rent Vehicle\n" +
                    "6. Return Vehicle\n" +
                    "7. Exit");
                Console.Write("Input: ");
                int input = program.NumberValidation(Console.ReadLine());
                switch (input)
                {
                    case 1:
                        program.AddCar();
                        break;
                    case 2:
                        program.AddTruck();
                        break;
                    case 3:
                        program.ListVehicles();
                        break;
                    case 4:
                        Console.WriteLine("Enter the model for the vehicle you are looking for");
                        string model = program.InputValidation(Console.ReadLine());
                        program.VehicleSearch(model);
                        break;
                    case 5:
                        program.RentVehicle();
                        break;
                    case 6:
                        program.ReturnVehicle();
                        break;
                    case 7:
                        runProgram = false;
                        break;
                }
            }
        }

        string InputValidation(string? input)
        {
            while(string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Input can not be empty");
                Console.Write("Input: ");
                input = Console.ReadLine();
            }
            return input;
        }

        int NumberValidation(string? input)
        {
            int number = 0;
            while (true)
            {
                while(string.IsNullOrEmpty(input))
                {
                    Console.WriteLine("Input can not be empty");
                    Console.Write("Input: ");
                    input = Console.ReadLine();
                }
                if (int.TryParse(input, out number))
                {
                    return number;
                }
                Console.WriteLine("Enter a valid number");
                input = Console.ReadLine();
            }
        }

        void AddCar()
        {
            Console.WriteLine("How many cars do you want to add?");
            int carAmount = NumberValidation(Console.ReadLine());
            for(int i = 0;  i < carAmount; i++)
            {
                // Ask for vehicle make, Ex: Ford, dodge, chevy
                Console.WriteLine($"Enter the make of vehicle #{i + 1}");
                string make = InputValidation(Console.ReadLine());
                // Ask for vehicle model, Ex: Dart, charger, Silverado
                Console.WriteLine($"Enter the model of vehicle #{i + 1}");
                string model = InputValidation(Console.ReadLine());
                // Ask for vehicle year
                Console.WriteLine($"Enter the year of vehicle #{i + 1}");
                int year = NumberValidation(Console.ReadLine());
                // Ask how many doors the car has 
                Console.WriteLine("How many doors does this car have?");
                int doors = NumberValidation(Console.ReadLine());
                // Create a new car and assign values to it
                Car car = new Car(make, model, year, doors, false);
                // Add car to the vehicles list
                vehicles.Add(car);
                Console.WriteLine("Vehicle successfully added");
            }
        }

        void AddTruck()
        {
            Console.WriteLine("How many trucks do you want to enter?");
            int truckAmount = NumberValidation(Console.ReadLine());
            for(int i = 0; i < truckAmount; i++)
            {
                // Ask for truck make
                Console.WriteLine($"Enter the make of truck #{i + 1}");
                string make = InputValidation(Console.ReadLine());
                // Ask for truck model
                Console.WriteLine($"Enter the model of truck #{i + 1}");
                string model = InputValidation(Console.ReadLine());
                // Ask for truck year
                Console.WriteLine($"Enter the year of truck #{i + 1}");
                int year = NumberValidation(Console.ReadLine());
                // Ask for towing power
                Console.WriteLine($"Enter towing power for truck #{i + 1}");
                int towingPower = NumberValidation(Console.ReadLine());
                // Create new truck and assign values
                Truck truck = new Truck(make, model, year, towingPower, false);
                vehicles.Add(truck);
                Console.WriteLine("Vehicle successfully added");
            }
        }

        void ListVehicles()
        {
            // List all vehicles 
            foreach (Vehicle vehicle in vehicles)
            {
                Console.WriteLine($"Vehicle Make: {vehicle.Make}");
                Console.WriteLine($"Vehicle Model: {vehicle.Model}");
                Console.WriteLine($"Vehicle Year: {vehicle.Year}");
                Console.WriteLine($"Vehicle Rented? {vehicle.IsRented}");
            }
        }

        Vehicle VehicleSearch(string? model)
        {
            
            model = model.ToLower();
            while (true)
            {
                foreach (Vehicle vehicle in vehicles)
                {
                    if (vehicle.Model.ToLower().Contains(model))
                    {
                        Console.WriteLine($"Vehicle Make: {vehicle.Make}");
                        Console.WriteLine($"Vehicle Model: {vehicle.Model}");
                        Console.WriteLine($"Vehicle Year: {vehicle.Year}");
                        Console.WriteLine($"Vehicle Rented? {vehicle.IsRented}");
                        return vehicle;
                    }
                }

            }
            
        }

        void RentVehicle()
        {
            Console.WriteLine("Enter the model for the vehicle you are looking for");
            string model = InputValidation(Console.ReadLine());
            Vehicle vehicle = VehicleSearch(model);
            if (vehicle.IsRented)
            {
                Console.WriteLine("Vehicle is already rented, try again");
            }
            else
            {
                vehicle.IsRented = true;
                Console.WriteLine("Vehicle has been checked out");
            }
        }

        void ReturnVehicle()
        {
            Console.WriteLine("Enter the model for the vehicle you are looking for");
            string model = InputValidation(Console.ReadLine());
            Vehicle vehicle = VehicleSearch(model);
            if (vehicle.IsRented)
            {
                vehicle.IsRented = false;
                Console.WriteLine("Vehicle returned");
            }
            else
            {
                Console.WriteLine("Vehicle has not been rented");
            }
        }
    }
}