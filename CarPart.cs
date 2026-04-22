using System;

[Serializable]
public class CarPart
{
    public string partName;
    public bool isInstalled;
    public float condition; // 0 - 100

    public CarPart(string name)
    {
        partName = name;
        isInstalled = false;
        condition = 100f;
    }

    public bool IsBroken()
    {
        return condition <= 0;
    }
}
