using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Click : MonoBehaviour
{
    public static event Action OnPickedCoin;
    
    [SerializeField] private GameDataSO gameData;
    [SerializeField] private LayerMask clickeableLayer;
    private float _timer;
    private Camera _camera;
    private void Start()
    {
        _timer = gameData.ClickRate;
        _camera = Camera.main;
    }
    private void Update()
    {
        PlayerClick();
    }

    private void PlayerClick()
    {
        _timer += Time.deltaTime;
        if (_timer >= gameData.ClickRate && Input.GetMouseButtonDown(0))
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
                    break;
            }
        } 
    }
    
    private void AttackEnemy(Enemy enemy)
    {
        enemy.GetComponent<IDamageable>().TakeDamage(gameData.PlayerDamage);
    }

    private void CollectCoin(Coin coin)
    {
        //todo Hacer que sume una coin a la billetera
        Debug.Log("Agarre una coin");
        OnPickedCoin?.Invoke();
        gameData.Coins += gameData.CoinValue;
        Destroy(coin.gameObject);
    }
    
}
