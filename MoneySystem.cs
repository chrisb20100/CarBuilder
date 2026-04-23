using UnityEngine;

public class MoneySystem : MonoBehaviour
{
    public int money = 500;

    public bool Spend(int amount)
    {
        if (money >= amount)
        {
            money -= amount;
            Debug.Log("Spent: $" + amount);
            return true;
        }

        Debug.Log("Not enough money!");
        return false;
    }

    public void AddMoney(int amount)
    {
        money += amount;
        Debug.Log("Gained: $" + amount);
    }
}
