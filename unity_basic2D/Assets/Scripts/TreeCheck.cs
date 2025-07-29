using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TreeCheck : MonoBehaviour
{
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.collider.CompareTag("Player"))
        {
            Destroy(collision.gameObject);
        }
    }
}
