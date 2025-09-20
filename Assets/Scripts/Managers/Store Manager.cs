using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreManager : MonoBehaviour
{
    public static event Action UpdateUi;
    
    [SerializeField] private GameDataSO gameData;
    [SerializeField] private StoreSO storeData;
    private void OnEnable()
    {
        StoreUi.OnItemBuy += BuyProcess;
    }

    private void OnDisable()
    {
        StoreUi.OnItemBuy -= BuyProcess;
    }


    private void BuyProcess(StorageItems item)
    {
        int currentCoins = gameData.Coins;
        switch (item)
        {
            case StorageItems.DamageItem:
            {
                if (currentCoins >= storeData.DamagePrice)
                {
                    //todo cambiar ese 20 por alguna variable, nose, un balance data o algo asi
                    gameData.Coins -= storeData.DamagePrice;
                    gameData.PlayerDamage += 20;
                }
                else
                {
                    Debug.Log("No hay plata para DamageItem");
                }
                break;
            }
            
            case StorageItems.HealItem:
            {
                if (currentCoins >= storeData.HealPrice)
                {
                    gameData.Coins -= storeData.HealPrice;
                    //todo poner aca la vida del player y que se cure
                    Debug.Log("Te curaste!");
                }
                else
                {
                    Debug.Log("No hay plata para HealItem");
                }
                break;
            }
            
            case StorageItems.HealthItem:
            {
                if (currentCoins >= storeData.HealthPrice)
                {
                    gameData.Coins -= storeData.HealthPrice;
                    //todo poner aca la vida del player y que aumente
                    Debug.Log("Tu vida maxima AUMENTO");
                }
                else
                {
                    Debug.Log("No hay plata para HealthItem");
                }
                break;
            }
            
            case StorageItems.RateItem:
            {
                if (currentCoins >= storeData.ClickRatePrice)
                {
                    gameData.Coins -= storeData.ClickRatePrice;
                    //todo cambiar ese 0.5 por alguna variable, nose, un balance data o algo asi o un multiplicador yo que se
                    gameData.ClickRate -= 0.5f;
                }
                else
                {
                    Debug.Log("No hay plata para RateItem");
                }
                break;
            }
        }
        
        UpdateUi?.Invoke();
    }
    
    
}
