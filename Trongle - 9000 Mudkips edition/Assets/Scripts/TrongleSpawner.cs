using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class TrongleSpawner : MonoBehaviour
{
    public Transform enemyPrefab;
    public Transform spawnPoint;

    void Update()
    {
        SpawnEnemy();
    }

    void SpawnEnemy()
    {
        Instantiate(enemyPrefab, spawnPoint.position, spawnPoint.rotation);
    }
}