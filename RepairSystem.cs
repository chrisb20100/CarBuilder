using UnityEngine;

public class RepairSystem : MonoBehaviour
{
    public void RepairPart(CarPart part, float amount)
    {
        part.condition += amount;
        part.condition = Mathf.Clamp(part.condition, 0, 100);

        Debug.Log(part.partName + " repaired.");
    }
}
