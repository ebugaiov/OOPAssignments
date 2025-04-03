namespace Exercise3;

public abstract class EngineVehicle
{
    private int _speed;
    private int _fuel;
    
    public string Name { get; set; }
    public int VehicleSpeed { get; set; } = 0;
    public int RemainingFuel { get; set; }

    public virtual int Speed
    {
        get => _speed;
        set => _speed = value;
    }

    public virtual int Fuel
    {
        get => _fuel;
        set => _fuel = value;
    }

    public EngineVehicle(string name)
    {
        Name = name;
        Speed = 0;
        Fuel = 0;
    }
}
