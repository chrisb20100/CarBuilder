using UnityEngine;

public class FuelSystem : MonoBehaviour
{
    public float fuel = 100f;
    public float fuelConsumptionRate = 0.1f;

    public bool HasFuel()
    {
        return fuel > 0;
    }

    public void ConsumeFuel()
    {
        fuel -= fuelConsumptionRate * Time.deltaTime;
        fuel = Mathf.Clamp(fuel, 0, 100);
    }

    public void Refuel(float amount)
    {
        fuel += amount;
        fuel = Mathf.Clamp(fuel, 0, 100);
        Debug.Log("Refueled: " + amount);
    }
}
