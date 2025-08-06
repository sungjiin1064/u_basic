using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RuntimeUI : MonoBehaviour
{
    [Header("��� Life")]
    [SerializeField] private TextMeshProUGUI lifeText;
    [SerializeField] private Image lifeImage;
    [Header("���� Coin")]
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private Image coinImage;
    [Header("�ð� Time")]
    [SerializeField] private TextMeshProUGUI timeText;
    private float timeValue = 60;
    [Header("���� Score")]
    [SerializeField] private TextMeshProUGUI scoreText;

    public void OnLifeUPdated(int lifeAmount)
    {
        lifeText.SetText($"X {lifeAmount}");
    }
    public void OnCoinUPdated(int coinAmount)
    {
        coinText.SetText($"X {coinAmount}");
    }
    public void OnTimeUPdated()
    {
        timeText.SetText($"Time : {(int)timeValue}");
    }
    public void OnScoreUPdated()
    {

    }
    private void Update()
    {
        timeValue -= Time.deltaTime;
        OnTimeUPdated();
    }

}
