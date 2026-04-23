using UnityEngine;

public class BatterySystem : MonoBehaviour
{
    public float charge = 100f;

    public bool HasPower()
    {
        return charge > 5f;
    }

    public void Drain(float amount)
    {
        charge -= amount * Time.deltaTime;
        charge = Mathf.Clamp(charge, 0, 100);
    }

    public void Recharge(float amount)
    {
        charge += amount;
        charge = Mathf.Clamp(charge, 0, 100);
    }
}
