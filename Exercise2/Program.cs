using Exercise2;

Car bentley = new("Bentley", 300, 500);
Motorbike harleyDavidson = new("Harley Davidson", 200, 100);
Bus scania = new("Scania", 130, 800);

var myGarage = new Vehicle[] { bentley, scania, harleyDavidson };

foreach (var vehicle in myGarage)
{
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"Start test drive for {vehicle.Name}");
    Console.ResetColor();
    TestDrive(vehicle);
    Console.ForegroundColor = ConsoleColor.DarkBlue;
    Console.WriteLine($"End test drive for {vehicle.Name}\n");
    Console.ResetColor();
}

static void TestDrive(IDriveable vehicle)
{
    vehicle.StartEngine();
    vehicle.Gas();
    vehicle.TurnLeft();
    vehicle.TurnRight();
    vehicle.TurnRight();
    vehicle.Break();
    vehicle.StartEngine();
}
