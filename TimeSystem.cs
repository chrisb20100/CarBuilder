using UnityEngine;

public class TimeSystem : MonoBehaviour
{
    public float timeOfDay = 0f;
    public float dayLength = 300f; // seconds for full day

    void Update()
    {
        timeOfDay += Time.deltaTime / dayLength;
        if (timeOfDay >= 1f)
            timeOfDay = 0f;
    }

    public float GetTime()
    {
        return timeOfDay;
    }
}
