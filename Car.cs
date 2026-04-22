using System.Collections.Generic;
using UnityEngine;

public class Car : MonoBehaviour
{
    public List<CarPart> parts = new List<CarPart>();

    void Awake()
    {
        parts.Add(new CarPart("Engine"));
        parts.Add(new CarPart("Battery"));
        parts.Add(new CarPart("Tires"));
    }

    public void InstallPart(string partName)
    {
        CarPart part = parts.Find(p => p.partName == partName);

        if (part != null)
        {
            part.isInstalled = true;
            Debug.Log(partName + " installed.");
        }
    }

    public void RemovePart(string partName)
    {
        CarPart part = parts.Find(p => p.partName == partName);

        if (part != null)
        {
            part.isInstalled = false;
            Debug.Log(partName + " removed.");
        }
    }

    public bool CanStart()
    {
        foreach (CarPart part in parts)
        {
            if (!part.isInstalled || part.IsBroken())
                return false;
        }
        return true;
    }

    public void DamageParts(float amount)
    {
        foreach (CarPart part in parts)
        {
            if (part.isInstalled)
            {
                part.condition -= amount;
                part.condition = Mathf.Clamp(part.condition, 0, 100);
            }
        }
    }
}
