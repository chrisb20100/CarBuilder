using UnityEngine;

public class ToolSystem : MonoBehaviour
{
    public Tool currentTool;

    public void EquipTool(string name)
    {
        switch (name)
        {
            case "Wrench":
                currentTool = new Tool("Wrench", 10f);
                break;
            case "Screwdriver":
                currentTool = new Tool("Screwdriver", 5f);
                break;
        }

        Debug.Log("Equipped: " + currentTool.toolName);
    }

    public float GetEfficiency()
    {
        return currentTool != null ? currentTool.efficiency : 0f;
    }
}
