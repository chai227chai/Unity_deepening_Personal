using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class GamePlayUI : UIBase
{
    private float playTime;

    [SerializeField] private Transform health;
    private List<GameObject> healthList = new List<GameObject>();

    [SerializeField] private TextMeshProUGUI timeText;

    private void Start()
    {
        GameManager.instance.TakeDamage += UpdateHealth;

        for(int i = 0; i < health.childCount; i++)
        {
            healthList.Add(health.GetChild(i).gameObject);
        }
    }

    private void Update()
    {
        UpdateTime();
    }

    private void UpdateTime()
    {
        playTime = GameManager.instance.playTime;
        timeText.text = playTime.ToString("N2");
    }

    private void UpdateHealth(int nowHealth)
    {
        for (int i = 0; i < healthList.Count; i++)
        {
            if(i < nowHealth)
            {
                healthList[i].SetActive(true);
            }
            else
            {
                healthList[i].SetActive(false);
            }
        }
    }
}
