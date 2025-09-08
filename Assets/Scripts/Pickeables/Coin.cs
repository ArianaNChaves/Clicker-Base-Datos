using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IClickeable
{
    public static event Action OnPickedCoin;

    public void Clicked()
    {
        Debug.Log("Clickee una moneda");
        OnPickedCoin?.Invoke();

    }
}
