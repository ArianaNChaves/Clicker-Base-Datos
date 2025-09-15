using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class StoreManager : MonoBehaviour
{
    [SerializeField] private StoreSO storeData;
    [SerializeField] private GameSettingsSO gameData;
    
    [Header("Store Buttons")] 
    [SerializeField] private Button damageButton; 
    [SerializeField] private Button healButton; 
    [SerializeField] private Button healthButton; 
    [SerializeField] private Button clickRateButton;
    
    [Header("Store Prices")] 
    [SerializeField] private TextMeshProUGUI damagePriceText;
    [SerializeField] private TextMeshProUGUI healPriceText;
    [SerializeField] private TextMeshProUGUI healthPriceText;
    [SerializeField] private TextMeshProUGUI clickRatePriceText;
    
    void Start()
    {
        UpdatePlayerUI();
    }

    private void UpdatePlayerUI()
    {
        damagePriceText.text = storeData.DamagePrice.ToString();
        healPriceText.text = storeData.HealPrice.ToString();  
        healthPriceText.text = storeData.HealthPrice.ToString();
        clickRatePriceText.text = storeData.ClickRatePrice.ToString();
    }
    
}
