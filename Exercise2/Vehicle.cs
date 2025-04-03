namespace Exercise2;

public class Vehicle(string name, int vehicleSpeed, int remainingFuel) : IDriveable
{
    public string Name { get; } = name;
    public int VehicleSpeed { get; } = vehicleSpeed;
    public int RemainingFuel { get; } = remainingFuel;

    private string TypeOfVehicle => this.GetType().Name;

    public void StartEngine()
    {
        Console.WriteLine($"Engine started ({TypeOfVehicle})");
    }

    public void StopEngine()
    {
        Console.WriteLine($"Engine stopped ({TypeOfVehicle})");
    }

    public void Gas()
    {
        Console.WriteLine($"Press Gas ({TypeOfVehicle})");
    }

    public void Break()
    {
        Console.WriteLine($"Press Break ({TypeOfVehicle})");
    }

    public void TurnLeft()
    {
        Console.WriteLine($"Turning Left ({TypeOfVehicle})");
    }

    public void TurnRight()
    {
        Console.WriteLine($"Turning Right ({TypeOfVehicle})");
    }
}
