using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public enum ClickableType
{
    Enemy,
    Coin
}

public interface IClickeable
{
    ClickableType Type { get; }
}
