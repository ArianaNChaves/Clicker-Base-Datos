using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Player Data", menuName = "ScriptableObjects/Player Data")]
public class GameDataSO : ScriptableObject
{
    [Header("Player Stats")] 
    [SerializeField] private int playerDamage;
    [SerializeField] private int playerMaxHealth;
    [SerializeField] private float clickRate;
    
    [Header("Coins Settings")] 
    [SerializeField] private int coins;
    [SerializeField] private int coinValue;
    
    [Header("Enemy Settings")] 
    [SerializeField] private int enemyDamage;
    [SerializeField] private int enemyMaxHealth;
    
   public int PlayerDamage  { get => playerDamage; set => playerDamage = value; }
   public int PlayerMaxHealth { get => playerMaxHealth; set => playerMaxHealth = value; }
   public float ClickRate { get => clickRate; set => clickRate = value; }
   public int Coins { get => coins; set => coins = value; }
   public int CoinValue { get => coinValue; set => coinValue = value; }
   public int EnemyDamage { get => enemyDamage; set => enemyDamage = value; }
   public int EnemyMaxHealth { get => enemyMaxHealth; set => enemyMaxHealth = value; }
}
