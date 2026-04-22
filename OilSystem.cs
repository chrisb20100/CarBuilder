using UnityEngine;

public class OilSystem : MonoBehaviour
{
    public float oilLevel = 100f;
    public float oilUsageRate = 0.05f;

    public void UseOil()
    {
        oilLevel -= oilUsageRate * Time.deltaTime;
        oilLevel = Mathf.Clamp(oilLevel, 0, 100);
    }

    public bool HasOil()
    {
        return oilLevel > 10f;
    }
}
