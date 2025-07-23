using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Human : MonoBehaviour
{
    [SerializeField] private HumanBone[] allBones;

    [SerializeField] private Arm[] arm;
    private Leg[] leg;
    private Body body;
    private Head head;

    [SerializeField] private Color legColor;
    [SerializeField] private int legSortingOrder = 10;
    void Start()
    {
        allBones = GetComponentsInChildren<HumanBone>();

        arm = GetComponentsInChildren<Arm>();
        leg = GetComponentsInChildren<Leg>();
        body = GetComponentInChildren<Body>();
        head = GetComponentInChildren<Head>();

        for(int i = 0;i<leg.Length;i++)
        {
            leg[i].SetRenderProperty(legColor, legSortingOrder);
        }
        for (int i = 0; i < arm.Length; i++)
        {
            arm[i].SetRenderProperty(legColor, legSortingOrder);
        }
        body.SetRenderProperty(legColor, legSortingOrder);
        head.SetRenderProperty(legColor, legSortingOrder);

    }


}
