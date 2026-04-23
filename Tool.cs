using System;

[Serializable]
public class Tool
{
    public string toolName;
    public float efficiency;

    public Tool(string name, float eff)
    {
        toolName = name;
        efficiency = eff;
    }
}
