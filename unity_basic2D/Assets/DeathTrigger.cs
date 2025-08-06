using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeathTrigger : MonoBehaviour
{
    [SerializeField] GameObject GameOverPanel;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            var Life = collision.GetComponent<PlayerEntity>();
            Life.OnLifeUPdated(-1);
            if(Life.IsPlayerDead())
            {
                GameOverPanel.SetActive(true);
            }

            //GameOverPanel.SetActive(true);
        }
    }
}
