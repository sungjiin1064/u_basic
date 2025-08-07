using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntity : MonoBehaviour
{
    [SerializeField] RuntimeUI runtimeUI;
    [Header("Life")]
    [SerializeField] int currentLife;
    [SerializeField] int maxLife = 10;
    [Header("Coin")]
    [SerializeField] int currentCoin;
    [SerializeField] int maxCoinForLife =100;
    private void Start()
    {
        //currentLife = maxLife/2;
        currentCoin = 0;
        OnLifeUPdated(0);
        OnCoinUPdated(currentCoin);
    }

    public void OnLifeUPdated(int amount)
    {
        currentLife += amount;

        if(currentLife > maxLife)
        {
            currentLife = maxLife;
        }

        runtimeUI.OnLifeUPdated(currentLife);
    }
    public void OnCoinUPdated(int amount)
    {
        currentCoin += amount;

        if (currentCoin >= maxCoinForLife)
        {
            currentCoin -= maxCoinForLife;
            OnLifeUPdated(1);
        }

        runtimeUI.OnCoinUPdated(currentCoin);
    }
    public bool IsPlayerDead()
    {
        return currentLife <= 0;
    }
}
