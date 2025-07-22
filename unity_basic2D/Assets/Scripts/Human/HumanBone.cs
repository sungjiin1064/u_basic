using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HumanBone : MonoBehaviour
{
    SpriteRenderer spriteRenderer;
   
    void Awake()
    {
        spriteRenderer = GetComponent<SpriteRenderer>();
    }
    public void SetRenderProperty(Color _color, int _orderCount)
    {
        spriteRenderer.color = _color;
        spriteRenderer.sortingOrder = _orderCount;
    }
}
