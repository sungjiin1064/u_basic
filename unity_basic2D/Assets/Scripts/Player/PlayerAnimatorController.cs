using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerAnimatorController : MonoBehaviour
{
    private Animator animator;
    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    public void PlayerMoveAnimation()
    {
        PlayerBoolAnimation("IsMove", true);
        PlayerBoolAnimation("IsLadderMove", false);
    }
    
    public void PlayerBoolAnimation(string paraName, bool enable)
    {
        animator.SetBool(paraName, enable);
    }


}
