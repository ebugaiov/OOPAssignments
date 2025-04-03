namespace Exercise2;

public interface IDriveable
{
    // Properties
    public string Name { get; }
    public int VehicleSpeed { get; }
    public int RemainingFuel { get; }
    // Methods
    public void StartEngine();
    public void StopEngine();
    public void Gas();
    public void Break();
    public void TurnLeft();
    public void TurnRight();
}