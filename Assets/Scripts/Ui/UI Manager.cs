using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameDataSO gameData;
    
    [Header("Show Values")] 
    [SerializeField] private TextMeshProUGUI coinsText;
    [SerializeField] private TextMeshProUGUI damageText;
    
    [Header("UI Buttons")] 
    [SerializeField] private Button storeButton;
    [SerializeField] private Button settingsButton;
    
    [Header("UI Panels")] 
    [SerializeField] private GameObject storePanel;
    [SerializeField] private GameObject settingsPanel;

    private void Start()
    {
        UpdateUI();
    }
    private void OnEnable()
    {
        storeButton.onClick.AddListener(OnStoreClick);
        settingsButton.onClick.AddListener(OnSettingsClick);
        Click.OnPickedCoin += UpdateUI;
        
    }

    private void OnDisable()
    {
        storeButton.onClick.RemoveAllListeners();
        settingsButton.onClick.RemoveAllListeners();
        Click.OnPickedCoin -= UpdateUI;
    }

    private void UpdateUI()
    {
        coinsText.text = gameData.Coins.ToString();
        damageText.text = gameData.PlayerDamage.ToString();
    }

    private void OnStoreClick()
    {
        if (storePanel.activeSelf)
        {
            storePanel.SetActive(false);
        }
        else
        {
            storePanel.SetActive(true);
        }
        
    }
    
    private void OnSettingsClick()
    {
        if (settingsPanel.activeSelf)
        {
            settingsPanel.SetActive(false);
        }
        else
        {
            settingsPanel.SetActive(true);
        }
        
    }
    
}
