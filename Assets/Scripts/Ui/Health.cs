using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Health : MonoBehaviour, IDamageable
{
    [SerializeField] private float maxHealth;
    [SerializeField] private Image healthBar;
    [SerializeField] private Camera mainCamera;
    [SerializeField] private Canvas canvasHealthBar;
    
    private float _currentHealth;

    private void Start()
    {
        _currentHealth = maxHealth;
        UpdateHealthBar();
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
        if (!mainCamera && !canvasHealthBar)
        {
            canvasHealthBar.transform.LookAt(canvasHealthBar.transform.position + mainCamera.transform.forward);
        }
    }
}
