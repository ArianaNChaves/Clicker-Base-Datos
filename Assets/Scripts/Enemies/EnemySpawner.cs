using UnityEngine;
using System.Collections.Generic;
using System.Linq; // Needed for Any() check

public class EnemySpawner : MonoBehaviour
{
    [Header("Spawning")]
    [SerializeField] private float spawnRate = 2.0f;
    [SerializeField] private Transform spawnPoint;

    private float _spawnTimer;

    private void Start()
    {

        if (spawnPoint == null)
        {
            spawnPoint = transform;
        }
        
        _spawnTimer = spawnRate;
    }

    private void Update()
    {
        _spawnTimer -= Time.deltaTime;

        if (_spawnTimer <= 0f)
        {
            SpawnEnemy();
            _spawnTimer = spawnRate;
        }
    }

    private void SpawnEnemy()
    {

        Enemy newEnemy = PoolManager.Instance.Get<Enemy>();

        if (newEnemy == null)
        {
            // Debug.LogError($"Error obteniendo enemigo de la pool '{selectedPoolName}'.", this);
            Debug.LogError("New enemy es nulo - EnemySpawner.cs - SpawnEnemy");
            return;
        }


        newEnemy.transform.position = spawnPoint.position;
        newEnemy.transform.rotation = spawnPoint.rotation;
        newEnemy.gameObject.SetActive(true);

        Enemy enemy = newEnemy.GetComponent<Enemy>();
        
    }
}
