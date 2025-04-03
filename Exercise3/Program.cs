using Exercise3;

Motorbike harleyDavidson = new("Harley Davidson");
Car bentley = new("Bentley");
Bus scania = new("Scania");

var myGarage = new IDriveable[] { bentley, scania, harleyDavidson };

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
    vehicle.StopEngine();
}
