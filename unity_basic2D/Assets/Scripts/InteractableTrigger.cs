using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableTrigger : MonoBehaviour
{
    [SerializeField] JumpPlatform jumpPlatform;
    
    private void OnTriggerEnter2D(Collider2D collision)
    {
        //collision.gameObject.CompareTag("Player");        
        if(collision.CompareTag("Player"))
        {
            jumpPlatform.PlayTriggerAnimation("Trigger");
        }
    }
}
