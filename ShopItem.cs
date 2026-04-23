using System;

[Serializable]
public class ShopItem
{
    public string itemName;
    public int price;

    public ShopItem(string name, int cost)
    {
        itemName = name;
        price = cost;
    }
}
