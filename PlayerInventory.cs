using System.Collections.Generic;
using UnityEngine;

public class PlayerInventory : MonoBehaviour
{
    public List<string> items = new List<string>();

    public void AddItem(string item)
    {
        items.Add(item);
        Debug.Log(item + " added to inventory.");
    }

    public bool HasItem(string item)
    {
        return items.Contains(item);
    }

    public void RemoveItem(string item)
    {
        if (items.Contains(item))
        {
            items.Remove(item);
            Debug.Log(item + " removed from inventory.");
        }
    }
}
