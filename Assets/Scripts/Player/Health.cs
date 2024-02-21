using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Health : MonoBehaviour
{
    [SerializeField] private int maxHealth = 5;
    private int health;
    public event Action OnDie;

    public bool isDead => health == 0;

    private void Start()
    {
        health = maxHealth;
    }

    public void TakeDamage(int damage)
    {
        if(health == 0)
        {
            return;
        }

        health = Mathf.Max(health - damage, 0);
        GameManager.instance.UpdateHealth(health);

        if(health == 0)
        {
            OnDie?.Invoke();
        }

    }
}
