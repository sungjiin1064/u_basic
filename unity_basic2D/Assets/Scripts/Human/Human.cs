using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    [SerializeField] private HumanBone[] allBones;

    private Arm arm;
    private Leg leg;
    private Body body;
    private Head head;

    [SerializeField] private Color legColor;
    [SerializeField] private int legSortingOrder = 10;
    void Start()
    {
        allBones = GetComponentsInChildren<HumanBone>();

        arm = GetComponentInChildren<Arm>();
        leg = GetComponentInChildren<Leg>();
        body = GetComponentInChildren<Body>();
        head = GetComponentInChildren<Head>();

        for (int i = 0; i < leg.Length; i++)
        {
            leg.SetRenderProperty(legColor, legSortingOrder);
        }

    }


}
