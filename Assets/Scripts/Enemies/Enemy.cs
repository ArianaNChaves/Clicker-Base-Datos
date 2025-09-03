using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IClickeable
{
    [SerializeField] Health health;

    public void Clicked()
    {
        health.TakeDamage(30f);
    }
}
