using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Rendering;
using UnityEngine.UI;

public class PlayerStatsManager : MonoBehaviour
{
    [SerializeField] private GameSettingsSO gameData;
    

    [SerializeField] private Button storeButton;
    [SerializeField] private Button settingsButton;
    
    void Start()
    {
        UpdatePlayerUI();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    private void UpdatePlayerUI()
    {
       
    }
}
