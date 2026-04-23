using System.Collections.Generic;
using UnityEngine;

public class ShopSystem : MonoBehaviour
{
    public List<ShopItem> items = new List<ShopItem>();
    public MoneySystem moneySystem;
    public InventorySystem inventory;

    void Start()
    {
        items.Add(new ShopItem("Engine", 200));
        items.Add(new ShopItem("Battery", 100));
        items.Add(new ShopItem("Tires", 150));
    }

    public void BuyItem(string name)
    {
        ShopItem item = items.Find(i => i.itemName == name);

        if (item != null)
        {
            if (moneySystem.Spend(item.price))
            {
                inventory.AddItem(name, 1);
                Debug.Log("Bought: " + name);
            }
        }
    }
}
