using UnityEngine;

public class BoltInteract : MonoBehaviour, IInteractable
{
    public BoltGroup boltGroup;
    public int boltIndex;
    public ToolSystem toolSystem;

    public void Interact()
    {
        float power = toolSystem.GetEfficiency();

        if (power <= 0)
        {
            Debug.Log("No tool equipped!");
            return;
        }

        boltGroup.TightenBolt(boltIndex, power);
    }
}
