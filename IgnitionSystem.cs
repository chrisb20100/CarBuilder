using UnityEngine;

public class IgnitionSystem : MonoBehaviour
{
    public bool keyInserted = false;
    public bool keyTurned = false;

    public WiringSystem wiring;
    public BatterySystem battery;

    public bool CanIgnite()
    {
        return keyInserted &&
               keyTurned &&
               battery.HasPower() &&
               wiring.IsWireConnected("BatteryToStarter") &&
               wiring.IsWireConnected("StarterToEngine");
    }
}
