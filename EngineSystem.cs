using UnityEngine;

public class EngineSystem : MonoBehaviour
{
    public float temperature = 20f;
    public float maxTemp = 120f;
    public float heatRate = 5f;
    public float coolRate = 2f;

    public bool isRunning = false;

    public void UpdateEngine()
    {
        if (isRunning)
        {
            temperature += heatRate * Time.deltaTime;
        }
        else
        {
            temperature -= coolRate * Time.deltaTime;
        }

        temperature = Mathf.Clamp(temperature, 20f, maxTemp);
    }

    public bool IsOverheated()
    {
        return temperature >= maxTemp;
    }
}
