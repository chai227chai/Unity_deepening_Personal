using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CountDownUI : UIBase
{
    [SerializeField] private TextMeshProUGUI countText;

    private void Start()
    {
        GameManager.instance.CountDown += UpdateCountDown;
        GameManager.instance.GameStart += CloseUI;

        countText.text = GameManager.instance.countdown.ToString();
    }

    private void UpdateCountDown(int countdown)
    {
        if(countdown > 0)
        {
            countText.text = countdown.ToString();
        }
        else if(countdown == 0)
        {
            countText.text = "Start!!!";
        }
    }


}
