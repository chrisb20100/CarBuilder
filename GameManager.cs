using UnityEngine;

public class GameManager : MonoBehaviour
{
    public Car car;
    public PlayerInventory inventory;

    void Start()
    {
        Debug.Log("Game Started");

        inventory.AddItem("Engine");
        inventory.AddItem("Battery");
        inventory.AddItem("Tires");
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            TryInstall("Engine");
            TryInstall("Battery");
            TryInstall("Tires");
        }

        if (Input.GetKeyDown(KeyCode.R))
        {
            if (car.CanStart())
                Debug.Log("🚗 Car Started!");
            else
                Debug.Log("❌ Car Missing Parts or Broken!");
        }

        if (Input.GetKeyDown(KeyCode.T))
        {
            car.DamageParts(5f);
            Debug.Log("Parts wearing down...");
        }
    }

    void TryInstall(string part)
    {
        if (inventory.HasItem(part))
        {
            car.InstallPart(part);
            inventory.RemoveItem(part);
        }
    }
}
