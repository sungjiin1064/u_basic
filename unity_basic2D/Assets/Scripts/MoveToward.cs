using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveToward : MonoBehaviour
{
    [SerializeField] private Transform target;

    [SerializeField] private float moveSpeed;
    [SerializeField] private Vector3 startVector;

    // Start is called before the first frame update
    void Start()
    {      
        transform.position = transform.position + startVector;

        // 이동하는 방향만 표현해주는 방법.(벡터의 정규화)
        startVector = startVector.normalized;

        startVector = (target.position - transform.position).normalized;
    }

    // Update is called once per frame
    void Update()
    {
        startVector = (target.position - transform.position).normalized;
        transform.position += startVector * moveSpeed * Time.deltaTime;
    }
}
