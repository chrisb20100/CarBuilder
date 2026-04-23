using System.Collections.Generic;
using UnityEngine;

public class BoltGroup : MonoBehaviour
{
    public List<Bolt> bolts = new List<Bolt>();

    void Awake()
    {
        for (int i = 0; i < 4; i++) // default 4 bolts
        {
            bolts.Add(new Bolt());
        }
    }

    public void TightenBolt(int index, float amount)
    {
        if (index >= 0 && index < bolts.Count)
        {
            bolts[index].Tighten(amount);
            Debug.Log("Bolt " + index + " tightened.");
        }
    }

    public bool AllBoltsTight()
    {
        foreach (Bolt bolt in bolts)
        {
            if (!bolt.IsTight())
                return false;
        }
        return true;
    }
}
