using System;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public enum StorageItems
{
    DamageItem,
    HealItem,
    HealthItem,
    RateItem,
}
public class StoreUi : MonoBehaviour
{
    public static event Action<StorageItems> OnItemBuy;
    
    [SerializeField] private StoreSO storeData;
    [SerializeField] private GameDataSO gameData;
    
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
        UpdateStorePricesUI();
    }

    private void OnEnable()
    {
        damageButton.onClick.AddListener(OnDamageButtonClick);
        healButton.onClick.AddListener(OnHealButtonClick);
        healthButton.onClick.AddListener(OnHealthButtonClick);
        clickRateButton.onClick.AddListener(OnRateButtonClick);
    }

    private void OnDisable()
    {
        damageButton.onClick.RemoveAllListeners();
        healButton.onClick.RemoveAllListeners();
        healthButton.onClick.RemoveAllListeners();
        clickRateButton.onClick.RemoveAllListeners();

    }

    private void UpdateStorePricesUI()
    {
        damagePriceText.text = storeData.DamagePrice.ToString();
        healPriceText.text = storeData.HealPrice.ToString();  
        healthPriceText.text = storeData.HealthPrice.ToString();
        clickRatePriceText.text = storeData.ClickRatePrice.ToString();
    }

    private void OnDamageButtonClick()
    {
        OnItemBuy?.Invoke(StorageItems.DamageItem);
    }
    private void OnHealButtonClick()
    {
        OnItemBuy?.Invoke(StorageItems.HealItem);
    }
    private void OnHealthButtonClick()
    {
        OnItemBuy?.Invoke(StorageItems.HealthItem);
    }
    private void OnRateButtonClick()
    {
        OnItemBuy?.Invoke(StorageItems.RateItem);
    }
    
}
