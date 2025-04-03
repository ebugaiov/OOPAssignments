namespace Exercise3;

public class Bus : EngineVehicle, IDriveable
{
    // Const
    private const int MaxSpeed = 120;
    private const int SpeedStep = 30;
    private const int TankVolume = 150;
    private const int FuelStep = 15;
    private const int MinVolumeOfFuel = 20;

    #region Properties
    
    public override int Speed
    {
        get => VehicleSpeed;
        set
        {
            VehicleSpeed = Math.Clamp(value, 0, MaxSpeed);
            Console.WriteLine($"Speed: {VehicleSpeed}");
        }
    }

    public override int Fuel
    {
        get => RemainingFuel;
        set
        {
            RemainingFuel = Math.Clamp(value, 0, TankVolume);
            if (RemainingFuel < MinVolumeOfFuel)
            {   
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Refill fuel!");
                Console.ResetColor();
            }
            Console.WriteLine($"Fuel: {RemainingFuel}");
        }
    }
    
    #endregion

    // Constructor for define the full tank
    public Bus(string name) : base(name)
    {
        RemainingFuel = TankVolume;
    }
    
    #region Methods
    
    public void StartEngine()
    {
        Console.WriteLine($"Engine started.");
    }

    public void StopEngine()
    {
        Console.WriteLine($"Engine stopped.");
    }

    public void Gas()
    {
        Console.WriteLine($"Pressing Gas.");
        Fuel -= FuelStep;
        Speed += SpeedStep;
    }

    public void Break()
    {
        Console.WriteLine($"Pressing Break.");
        Speed -= SpeedStep;
    }

    public void TurnLeft()
    {
        Break();
        Console.WriteLine($"Turning Left.");
        Gas();
    }

    public void TurnRight()
    {
        Break();
        Console.WriteLine($"Turning Right.");
        Gas();
    }
    
    #endregion
}