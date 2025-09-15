using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Store Data", menuName = "ScriptableObjects/Store Data")]
public class StoreSO : ScriptableObject
{
    [SerializeField] private int damagePrice;
    [SerializeField] private int healPrice;
    [SerializeField] private int healthPrice;
    [SerializeField] private int clickRatePrice;
    
    public int DamagePrice { get => damagePrice; set => damagePrice = value; }
    public int HealPrice { get => healPrice; set => healPrice = value; }
    public int HealthPrice { get => healthPrice; set => healthPrice = value; }
    public int ClickRatePrice { get => clickRatePrice; set => clickRatePrice = value; }
}
