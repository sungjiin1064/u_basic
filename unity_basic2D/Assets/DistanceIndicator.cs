using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DistanceIndicator : MonoBehaviour
{
    [Header("플레이어와 목표 지점을 연결하세요.")]
    [SerializeField] private Transform player;
    [SerializeField] private Transform target;
    [SerializeField] private Slider playerSlider;
    [Header("Enemy Slider")]
    [SerializeField] private Transform enemy;
    [SerializeField] private Slider enemySlider;

    private float StartX;
    private float StartEnemyX;
    public void SetPlayerValue(float value)
    {
        playerSlider.value = value;
    }
    public void SetEnemyValue(float value)
    {
        enemySlider.value = value;
    }

    private void Start()
    {
        StartX = player.transform.position.x;
        StartEnemyX = enemy.transform.position.x;        
    }

    private void Update()
    {
        float playerX = player.position.x - StartX;
        float targerX = target.position.x - StartX;
        float enemyX = enemy.position.x - StartEnemyX;

        float sliderValue = playerX / targerX;
        float ememysliderValue = enemyX / targerX;
        SetPlayerValue(sliderValue);
        SetEnemyValue(ememysliderValue);
    }
}
