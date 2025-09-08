using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class EnemyHealth : MonoBehaviour, IDamageable
{
    [SerializeField] private float maxHealth;
    [SerializeField] private Image healthBar;
    [SerializeField] private Canvas canvasHealthBar;
    
    private float _currentHealth;
    private Camera _mainCamera;
    private void Start()
    {
        OnSpawn();
    }

    private void LateUpdate()
    {
        LookAtCamera();
    }
    
    public void TakeDamage(float damage)
    {
        _currentHealth -= damage;
        
        if (_currentHealth <= 0)
        {
            _currentHealth = 0;
            Die();
        }

        UpdateHealthBar();
    }

    private void UpdateHealthBar()
    {
        healthBar.fillAmount = _currentHealth/maxHealth;
    }

    private void Die()
    {
        Debug.Log("Mortis");
        Destroy(gameObject);
    }

    private void LookAtCamera()
    {
        if (_mainCamera != null)
        {
            canvasHealthBar.transform.LookAt(canvasHealthBar.transform.position + _mainCamera.transform.forward);
        }
    }

    public void OnSpawn()
    {
        _mainCamera = Camera.main;
        _currentHealth = maxHealth;
        UpdateHealthBar();
    }
}
