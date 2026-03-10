using UnityEngine;

public class Roullete : MonoBehaviour
{
    public MoneyManager moneyManager;

    public int betNumber;
    public float betAmount;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            SpinRoullete();
        }
    }

    public void SpinRoullete()
    {
        int randomNumber = Random.Range(0, 36);
        if (randomNumber == betNumber)
        {
            moneyManager.AddMoney(betAmount * 35);
        }
        else
        {
            moneyManager.RemoveMoney(betAmount);
        }
    }
}
