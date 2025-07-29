using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMove : MonoBehaviour
{
    [SerializeField] private Transform target; // ī�޶� ������ ���

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        offset = transform.position - target.position;
        Debug.Log($"����� ���� ��ġ : {offset}");

    }

    // Update is called once per frame
    void Update()
    {
        transform.position = target.position + offset;
    }
}
