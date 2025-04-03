namespace Exercise3;

public interface IDriveable
{
    // Properties
    public string Name { get; }
    public int VehicleSpeed { get; set; }
    public int RemainingFuel { get; set; }
    // Methods
    public void StartEngine();
    public void StopEngine();
    public void Gas();
    public void Break();
    public void TurnLeft();
    public void TurnRight();
}