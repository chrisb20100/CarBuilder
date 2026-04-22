using System.Collections.Generic;
using UnityEngine;

public class InventorySystem : MonoBehaviour
{
    public List<Item> items = new List<Item>();

    public void AddItem(string name, int amount)
    {
        Item item = items.Find(i => i.itemName == name);

        if (item != null)
        {
            item.quantity += amount;
        }
        else
        {
            items.Add(new Item(name, amount));
        }

        Debug.Log(name + " added x" + amount);
    }

    public bool HasItem(string name)
    {
        Item item = items.Find(i => i.itemName == name);
        return item != null && item.quantity > 0;
    }

    public void RemoveItem(string name, int amount)
    {
        Item item = items.Find(i => i.itemName == name);

        if (item != null)
        {
            item.quantity -= amount;

            if (item.quantity <= 0)
                items.Remove(item);
        }
    }
}
