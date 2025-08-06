using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class RuntimeUI : MonoBehaviour
{
    [Header("목숨 Life")]
    [SerializeField] private TextMeshProUGUI lifeText;
    [SerializeField] private Image lifeImage;
    [Header("동전 Coin")]
    [SerializeField] private TextMeshProUGUI coinText;
    [SerializeField] private Image coinImage;
    [Header("시간 Time")]
    [SerializeField] private TextMeshProUGUI timeText;
    private float timeValue = 60;
    [Header("점수 Score")]
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
