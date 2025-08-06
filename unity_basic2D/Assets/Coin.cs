using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour
{
    [SerializeField] int CoinAmount = 1;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Player"))
        {
            var Coin = collision.GetComponent<PlayerEntity>();
            Coin.OnCoinUPdated(CoinAmount);
            Destroy(gameObject);
        }
    }
}
