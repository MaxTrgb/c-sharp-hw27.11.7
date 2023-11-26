namespace MySpace
{
    class Vehicle
    {
        // Properties
        public string Make { get; set; }
        public int Year { get; set; }

        // Constructor
        public Vehicle(string make, int year)
        {
            Make = make;
            Year = year;
        }

        // Method to display information about the vehicle
        public virtual void DisplayInfo()
        {
            Console.WriteLine($"Make: {Make}, Year: {Year}");
        }
    }

    class Car : Vehicle
    {
        // Additional property for Car
        public int NumberOfDoors { get; set; }

        // Constructor
        public Car(string make, int year, int doors) : base(make, year)
        {
            NumberOfDoors = doors;
        }

        // Override the DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Number of Doors: {NumberOfDoors}");
        }
    }

    class Motorcycle : Vehicle
    {
        // Additional property for Motorcycle
        public bool HasSideCar { get; set; }

        // Constructor
        public Motorcycle(string make, int year, bool sideCar) : base(make, year)
        {
            HasSideCar = sideCar;
        }

        // Override the DisplayInfo method
        public override void DisplayInfo()
        {
            base.DisplayInfo();
            Console.WriteLine($"Has Sidecar: {HasSideCar}");
        }
    }

    class Program
    {
        public static void Main(string[] args)
        {
            // Create objects of both classes
            List<Vehicle> vehicles = new List<Vehicle>
            {
                new Car("Toyota", 2022, 4),
                new Motorcycle("Harley Davidson", 2021, true),
                new Car("Honda", 2023, 2),
                new Motorcycle("BMW", 2022, false)
            };

            // Display information about each vehicle
            Console.WriteLine("Vehicle Information:");
            foreach (Vehicle vehicle in vehicles)
            {
                vehicle.DisplayInfo();
                Console.WriteLine(); 
            }
        }
    }
}
