using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bullet : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.CompareTag("Player"))
        {
            SpriteRenderer _sr = collision.GetComponent<SpriteRenderer>();

            if(_sr != null )
            {
                _sr.color = Color.red;
            }
            //if(collision.TryGetComponent(out SpriteRenderer sr))
            //{
            //    sr.color = Color.red;
            //}
        }
    }
}
