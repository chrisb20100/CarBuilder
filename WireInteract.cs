using UnityEngine;

public class WireInteract : MonoBehaviour, IInteractable
{
    public string wireName;
    public WiringSystem wiring;

    public bool connected = false;

    public void Interact()
    {
        connected = !connected;

        if (connected)
        {
            wiring.ConnectWire(wireName);
        }
        else
        {
            wiring.DisconnectWire(wireName);
        }
    }
}
