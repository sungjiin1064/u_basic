using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpPlatform : MonoBehaviour
{
    private Animator animator;

    private void Awake()
    {
        animator = GetComponent<Animator>();
    }
    private void Start()
    {
        PlayTriggerAnimation("Trigger");
    }

    public void PlayTriggerAnimation(string paramName)
    {
        animator.SetTrigger(paramName);
    }

}
