using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            //Debug.Log("충돌한 오브젝트의 이름 : " + collision.gameObject.name);

            Destroy(collision.gameObject); // 충돌한 대상을 없애라
            //Destroy(gameObject); //부딛힌 자신을 없애라(isTrigger체크) 
        }
        if (collision.CompareTag("Player"))
        {
            Debug.Log("충돌한 오브젝트의 이름 : " + collision.gameObject.name);
        }

    }

}
