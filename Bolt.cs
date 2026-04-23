using UnityEngine;

[System.Serializable]
public class Bolt
{
    public float tightness = 0f; // 0–100
    public float requiredTightness = 100f;

    public void Tighten(float amount)
    {
        tightness += amount;
        tightness = Mathf.Clamp(tightness, 0, requiredTightness);
    }

    public bool IsTight()
    {
        return tightness >= requiredTightness;
    }
}
