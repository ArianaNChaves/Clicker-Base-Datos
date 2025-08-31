using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour, IClickeable
{


    public void Clicked()
    {
        Debug.Log("Clickee un enemigo");
    }
}
