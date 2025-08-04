using TMPro;
using UnityEngine;


public class TitleLocalize : MonoBehaviour
{
    TextMeshProUGUI titleText;
    [SerializeField] private string engTitle; 
    [SerializeField] private string korTitle; 
    
    public bool IsKorean = true;
    private void Awake()
    {
        titleText = GetComponent<TextMeshProUGUI>();
    }
    private void Start()
    {
        //titleText.text = "�÷��� ����";
        //titleText.SetText("�÷��� ����2");
        if (IsKorean)
        {
            titleText.SetText(korTitle);
        }
        else
        {
            titleText.SetText(engTitle);
        }
    }
}
