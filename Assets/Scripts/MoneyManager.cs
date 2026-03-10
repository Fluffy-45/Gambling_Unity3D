using UnityEngine;

public class MoneyManager : MonoBehaviour
{
    public float currentMoney = 0f;

    public void AddMoney(float amount)
    {
        currentMoney += amount;
        Debug.Log("Added money: " + amount + ". Current money: " + currentMoney);
    }
    public void RemoveMoney(float amount)
    {
        if (currentMoney >= amount)
        {
            currentMoney -= amount;
            Debug.Log("Removed money: " + amount + ". Current money: " + currentMoney);
        }
    }
}
