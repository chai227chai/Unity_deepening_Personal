using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager instance;
    public Health playerHealth;

    private bool isStart;
    private bool isGameover;

    public event Action GameStart;
    public event Action<int> TakeDamage;
    public event Action<int> CountDown;

    public float playTime;
    public int countdown;
    private float countSec;

    private void Awake()
    {
        if(instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }

        playTime = 0f;
        countdown = 3;
        countSec = 1f;
    }

    private void Start()
    {
        isStart = false;
        isGameover = false;

        playerHealth.OnDie += GameOver;

        UIManager.instance.Show("CountDownCanvas");
    }

    private void Update()
    {
        if (!isStart)
        {
            countSec -= Time.deltaTime;
            if(countSec <= 0f)
            {
                countdown--;
                countSec = 1;
                CountDown?.Invoke(countdown);
            }

            if(countdown < 0)
            {
                StartGame();
            }
        }

        if (!isGameover && isStart)
        {
            playTime += Time.deltaTime;
        }
    }

    private void GameOver()
    {
        isGameover = true;
        UIManager.instance.Show("GameOverPopUp");
    }

    private void StartGame()
    {
        isStart = true;
        UIManager.instance.Show("GamePlayCanvas");
        GameStart?.Invoke();
    }

    public void UpdateHealth(int damage)
    {
        TakeDamage?.Invoke(damage);
    }
}
