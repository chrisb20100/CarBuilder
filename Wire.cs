using System;

[Serializable]
public class Wire
{
    public string wireName;
    public bool isConnected;
    public bool hasPower;

    public Wire(string name)
    {
        wireName = name;
        isConnected = false;
        hasPower = false;
    }
}
