using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrefabsManager : MonoBehaviour
{
    [SerializeField] private Coin coinPrefab;
    [SerializeField] private Enemy enemyPrefab;
    void Start()
    {
        PoolManager.Instance.InitializePool(coinPrefab, 15);
        PoolManager.Instance.InitializePool(enemyPrefab, 15);

    }


}
