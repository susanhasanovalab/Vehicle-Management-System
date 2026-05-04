using ConsoleApp12;

class Program
{
    static void Main(string[] args)
    {
        Garage garage = new Garage();

        Console.WriteLine("Car brand daxil et:");
        string carBrand = Console.ReadLine();

        Console.WriteLine("Car model daxil et:");
        string carModel = Console.ReadLine();

        Console.WriteLine("Car year daxil et:");
        int carYear = Convert.ToInt32(Console.ReadLine());

        Car car = new Car(carBrand, carModel, carYear, "Petrol", 4);

        Motorcycle moto = new Motorcycle(
            "Yamaha",
            "R1",
            2022,
            "Petrol",
            1000
        );

        Truck truck = new Truck(
            "Volvo",
            "FH16",
            2020,
            20
        );

        garage.AddVehicle(car);
        garage.AddVehicle(moto);
        garage.AddVehicle(truck);

        garage.ShowAllVehicles();
    }
}
