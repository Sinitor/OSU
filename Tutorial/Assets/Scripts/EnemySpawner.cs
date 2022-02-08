using System.Collections;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{
    public GameObject enemy;
    public float spawnDelay;
    private void Start()
    {
        StartCoroutine(SpawnEnemy());
    }
    IEnumerator SpawnEnemy()
    {
        while (true)
        {
            GameObject enemySpawner = GetRandomEnemySpawner();
            float randomXposition = Random.Range(-8f, 8f);
            float randomYposition = Random.Range(-4f, 4f);
            Vector3 spawnPosition = new Vector3(randomXposition, randomYposition, 0);
            Instantiate(enemySpawner, spawnPosition, Quaternion.identity);

            yield return new WaitForSeconds(spawnDelay);
        }
    }
    private GameObject GetRandomEnemySpawner()
    {
        float randomNumber = Random.Range(0, 1f); 
        return enemy;
    }
}
