using UnityEngine;

public class CarPartInteract : MonoBehaviour, IInteractable
{
    public string partName;
    public Car car;

    public void Interact()
    {
        car.InstallPart(partName);
        Debug.Log(partName + " installed via interaction.");
        Destroy(gameObject);
    }
}
