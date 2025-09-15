using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public static event Action OnPickedCoin;
    
    [SerializeField] private GameSettingsSO data;
    [SerializeField] private LayerMask clickeableLayer;
    private float _timer;
    private Camera _camera;
    private void Start()
    {
        _timer = data.ClickRate;
        _camera = Camera.main;
    }
    private void Update()
    {
        PlayerClick();
    }

    private void PlayerClick()
    {
        _timer += Time.deltaTime;
        if (_timer >= data.ClickRate && Input.GetMouseButtonDown(0))
        {
            _timer = 0;
            RaycastClick();
        }
    }

    private void RaycastClick()
    {
        Ray ray = _camera.ScreenPointToRay(Input.mousePosition);
        if (Physics.Raycast(ray, out var hit, Mathf.Infinity, clickeableLayer))
        {
            IClickeable clickeable = hit.transform.gameObject.GetComponent<IClickeable>();
            switch (clickeable.Type)
            {
                case ClickableType.Enemy:
                    AttackEnemy(hit.transform.GetComponent<Enemy>());
                    break;

                case ClickableType.Coin:
                    CollectCoin(hit.transform.GetComponent<Coin>());
                    OnPickedCoin?.Invoke();
                    break;
            }
        } 
    }
    
    private void AttackEnemy(Enemy enemy)
    {
        enemy.GetComponent<IDamageable>().TakeDamage(data.PlayerDamage);
    }

    private void CollectCoin(Coin coin)
    {
        //todo Hacer que sume una coin a la billetera
        Debug.Log("Agarre una coin");
        Destroy(coin.gameObject);
    }
    
}
