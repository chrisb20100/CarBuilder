using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Text fuelText;
    public Text speedText;

    public FuelSystem fuelSystem;
    public CarController carController;

    void Update()
    {
        fuelText.text = "Fuel: " + fuelSystem.fuel.ToString("F1");
        speedText.text = "Speed: " + carController.speed.ToString("F1");
    }
}
