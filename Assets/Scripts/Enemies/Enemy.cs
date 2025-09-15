using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IClickeable, IPooleable
{
    [SerializeField] EnemyHealth enemyHealth;
    
    public void ReturnToPool()
    {
        throw new NotImplementedException();
    }

    public ClickableType Type => ClickableType.Enemy;
}
