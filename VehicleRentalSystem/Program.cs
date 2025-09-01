using System;

namespace VehicleRentalSystem
{
    // Base Class
    class Vehicle
    {
        public string Make { get; set; }
        public string Model { get; set; }
        public string LicensePlate { get; set; }

        public Vehicle(string make, string model, string licensePlate)
        {
            Make = make;
            Model = model;
            LicensePlate = licensePlate;
        }

        // Virtual method to be overridden
        public virtual double CalculateRentalCost(int days)
        {
            return 0; // Base implementation (not used directly)
        }

        // Method to display details
        public void GetVehicleDetails()
        {
            Console.WriteLine($"Make: {Make}, Model: {Model}, License Plate: {LicensePlate}");
        }
    }

    // Derived Class - Car
    class Car : Vehicle
    {
        private const double DailyRate = 50;

        public Car(string make, string model, string licensePlate)
            : base(make, model, licensePlate) { }

        public override double CalculateRentalCost(int days)
        {
            return days * DailyRate;
        }
    }

    // Derived Class - Bike
    class Bike : Vehicle
    {
        private const double DailyRate = 20;

        public Bike(string make, string model, string licensePlate)
            : base(make, model, licensePlate) { }

        public override double CalculateRentalCost(int days)
        {
            return days * DailyRate;
        }
    }

    // Derived Class - Truck
    class Truck : Vehicle
    {
        private const double DailyRate = 100;

        public Truck(string make, string model, string licensePlate)
            : base(make, model, licensePlate) { }

        public override double CalculateRentalCost(int days)
        {
            return days * DailyRate;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // Create sample vehicles
            Car car = new Car("Toyota", "Corolla", "ABC123");
            Bike bike = new Bike("Yamaha", "MT-15", "BIKE456");
            Truck truck = new Truck("Volvo", "FH16", "TRK789");

            // Get rental days from user
            Console.Write("Enter rental days for Car: ");
            int carDays = int.Parse(Console.ReadLine());

            Console.Write("Enter rental days for Bike: ");
            int bikeDays = int.Parse(Console.ReadLine());

            Console.Write("Enter rental days for Truck: ");
            int truckDays = int.Parse(Console.ReadLine());

            Console.WriteLine("\n--- Rental Details ---");

            // Car
            car.GetVehicleDetails();
            Console.WriteLine($"Rental Cost: ${car.CalculateRentalCost(carDays)}\n");

            // Bike
            bike.GetVehicleDetails();
            Console.WriteLine($"Rental Cost: ${bike.CalculateRentalCost(bikeDays)}\n");

            // Truck
            truck.GetVehicleDetails();
            Console.WriteLine($"Rental Cost: ${truck.CalculateRentalCost(truckDays)}\n");

            Console.WriteLine("Thank you for using Vehicle Rental System!");
        }
    }
}
