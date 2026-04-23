using UnityEngine;

public class CarNetworkSync : MonoBehaviour
{
    public Car car;
    public FuelSystem fuel;
    public EngineSystem engine;

    void Update()
    {
        // SEND data
        NetworkManagerSimple.Instance.carData.fuel = fuel.fuel;
        NetworkManagerSimple.Instance.carData.engineTemp = engine.temperature;
    }

    public void ApplyNetworkData()
    {
        var data = NetworkManagerSimple.Instance.carData;

        fuel.fuel = data.fuel;
        engine.temperature = data.engineTemp;
    }
}
