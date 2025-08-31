using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IClickeable
{


    public void Clicked()
    {
        Debug.Log("Clickee una moneda");

    }
}
