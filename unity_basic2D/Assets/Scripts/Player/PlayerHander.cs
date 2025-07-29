using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerHander : MonoBehaviour
{
    [SerializeField] private Rigidbody2D rigidbody2D;
    [SerializeField] private float moveSpeed = 5.0f;

    [SerializeField] private float jumpPower = 5f;

    [SerializeField] private float groundDistance = 1.2f;
    [SerializeField] private LayerMask groundLayer;

    private PlayerAnimatorController playerAnimatorController;

    private void Awake()
    {
        rigidbody2D = GetComponent<Rigidbody2D>();
        playerAnimatorController = GetComponent<PlayerAnimatorController>();
    }
    private void Start()
    {
        Setup();
    }

    private void Setup()
    {
        rigidbody2D.freezeRotation = true;
    }
    private void Update()
    {
        Move();
        Jump();
    }

    private void Jump()
    {
        if (CanJump())
        {
            rigidbody2D.velocity = new Vector2(rigidbody2D.velocity.x, jumpPower);
        }
        Debug.DrawRay(transform.position, Vector3.down * groundDistance, Color.red);
               
    }

    private bool CanJump()
    {
        return Input.GetKeyDown(KeyCode.Space) && GroundCheck();
    }

    private bool GroundCheck()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, groundDistance, groundLayer);
        return hit.collider != null;
    }

    private void Move()
    {
        playerAnimatorController.PlayerBoolAnimation("IsLadderMove", true);

        float horizontal = Input.GetAxisRaw("Horizontal");

        if(horizontal == 0)
        {
            playerAnimatorController.PlayerMoveAnimation();
        }
        else
        {

        }


            Vector2 moveVector = new Vector2(horizontal * moveSpeed, rigidbody2D.velocity.y);

        rigidbody2D.velocity = moveVector;
    }
}
