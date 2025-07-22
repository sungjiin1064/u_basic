using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerCheck : MonoBehaviour
{
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("Enemy"))
        {
            //Debug.Log("�浹�� ������Ʈ�� �̸� : " + collision.gameObject.name);

            Destroy(collision.gameObject); // �浹�� ����� ���ֶ�
            //Destroy(gameObject); //�ε��� �ڽ��� ���ֶ�(isTriggerüũ) 
        }
        if (collision.CompareTag("Player"))
        {
            Debug.Log("�浹�� ������Ʈ�� �̸� : " + collision.gameObject.name);
        }

    }

}
