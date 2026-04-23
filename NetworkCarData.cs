using System;
using System.Collections.Generic;

[Serializable]
public class NetworkCarData
{
    public List<bool> partInstalled = new List<bool>();
    public List<float> partCondition = new List<float>();

    public float fuel;
    public float engineTemp;
}
