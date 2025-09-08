using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IClickeable
{
    [SerializeField] EnemyHealth enemyHealth;

    public void Clicked()
    {
        enemyHealth.TakeDamage(30f);
    }
}
