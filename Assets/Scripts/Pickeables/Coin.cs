using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Coin : MonoBehaviour, IClickeable, IPooleable
{
    public ClickableType Type => ClickableType.Coin;

    public void ReturnToPool()
    {
        throw new NotImplementedException();
    }
    

}
