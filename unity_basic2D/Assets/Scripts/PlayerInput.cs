using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerInput : MonoBehaviour
{
    [SerializeField] private BoxCollider2D boxCollider2D;
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float movespeed = 5f;
    private Vector2 moveVector;
    // Start is called before the first frame update
    void Start()
    {
        rigidbody2D.velocity = moveVector.normalized;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.W))
        {
            moveVector = new Vector2(0, 1);
        }
        if (Input.GetKeyDown(KeyCode.A))
        {
            moveVector = new Vector2(-1, 0);
        }
        if (Input.GetKeyDown(KeyCode.S))
        {
            moveVector = new Vector2(0, -1);
        }
        if (Input.GetKeyDown(KeyCode.D))
        {
            moveVector = new Vector2(1, 0);
        }

        rigidbody2D.velocity = moveVector * movespeed;
    }
}
