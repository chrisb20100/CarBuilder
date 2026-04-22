using UnityEngine;

public class CarStarter : MonoBehaviour
{
    public Car car;
    public EngineSystem engine;
    public FuelSystem fuel;
    public OilSystem oil;
    public AudioManager audioManager;

    public void TryStart()
    {
        if (!car.CanStart())
        {
            Debug.Log("Missing parts!");
            return;
        }

        if (!fuel.HasFuel())
        {
            Debug.Log("No fuel!");
            return;
        }

        if (!oil.HasOil())
        {
            Debug.Log("No oil!");
            return;
        }

        if (engine.IsOverheated())
        {
            Debug.Log("Engine overheated!");
            return;
        }

        engine.isRunning = true;
        audioManager.PlayEngine();

        Debug.Log("🚗 Engine Started!");
    }
}
