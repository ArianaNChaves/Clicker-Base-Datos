using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class StatsDebug : MonoBehaviour
{
    [Header("Player Stats DEBUG")] 
    [SerializeField] private GameSettingsSO gameData;
    [SerializeField] private TextMeshProUGUI damageText;
    [SerializeField] private TextMeshProUGUI healthText;
    [SerializeField] private TextMeshProUGUI clickRateText;
    
    
    void Start()
    {
        UpdatePlayerUI();
    }

    private void UpdatePlayerUI()
    {
        damageText.text = gameData.PlayerDamage.ToString();
        healthText.text = gameData.PlayerMaxHealth.ToString();
        clickRateText.text = gameData.ClickRate.ToString("F1");
    }
}
