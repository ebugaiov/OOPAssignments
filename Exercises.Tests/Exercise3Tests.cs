using Exercise3;

namespace Exercises.Tests;

[TestClass]
public sealed class Exercise3Test
{
    IDriveable[] testVehicles =
    [
        new Bus("Scania"),
        new Car("Bentley"),
        new Motorbike("Harley Davidson")
    ];
    
    void TestVehicleSpeed(IDriveable[] vehicles, int[] expectedSpeed)
    {
        for (int i = 0; i < vehicles.Length; i++)
        {
            Assert.AreEqual(vehicles[i].VehicleSpeed, expectedSpeed[i]);
        }
    }

    void TestVehicleFuel(IDriveable[] vehicles, int[] expectedFuel)
    {
        for (int i = 0; i < vehicles.Length; i++)
        {
            Assert.AreEqual(vehicles[i].RemainingFuel, expectedFuel[i]);
        }
    }
    
    [TestMethod]
    public void SpeedAfterVehicleGas()
    {
        foreach (var vehicle in testVehicles)
            vehicle.Gas();

        TestVehicleSpeed(testVehicles, [30, 50, 80]);
    }

    [TestMethod]
    public void FuelAfterVehicleGas()
    {
        foreach (var vehicle in testVehicles)
            vehicle.Gas();
        
        TestVehicleFuel(testVehicles, [135, 50, 35]);
    }

    [TestMethod]
    public void MaxSpeedLimit()
    {
        foreach (var vehicle in testVehicles)
            for (int i = 0; i < 10; i++)
                vehicle.Gas();
        
        TestVehicleSpeed(testVehicles, [120, 160, 160]);
    }

    [TestMethod]
    public void SpeedUp()
    {
        foreach (var vehicle in testVehicles)
            for (int i = 0; i < 2; i++)
                vehicle.Gas();
        
        TestVehicleSpeed(testVehicles, [60, 100, 160]);
        TestVehicleFuel(testVehicles, [120, 40, 30]);
    }

    [TestMethod]
    public void SpeedDown()
    {
        foreach (var vehicle in testVehicles)
        {
            vehicle.VehicleSpeed = 100;
            vehicle.Break();
        }
        
        TestVehicleSpeed(testVehicles, [70, 50, 20]);
    }
}