using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawner groundSpawner;
    public GameObject obstaclePrefab;
    public GameObject powerUpsPrefab;
    public Transform spawnPowerUp;

    void Start()
    {
        groundSpawner = GameObject.FindObjectOfType<GroundSpawner>();
        SpawnObstacle();
    }

    private void OnTriggerExit(Collider other)
    {
        groundSpawner.SpawnTile();
        Destroy(gameObject, 2);
    }
    
    void SpawnObstacle()
    {
        // Choose a random point to spawn the obstacle
        int obstacleSpawnIndex = Random.Range(4, 6);
        int cantObj = Random.Range(1, 5);
        int powerUps = Random.Range(1, 20);
        Transform spawnPoint = transform.GetChild(obstacleSpawnIndex).transform;

        // Spawn the obstacle at the position
        if (cantObj == 1)
        {
            Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);
        }

        if (powerUps == 3)
        {
            Instantiate(powerUpsPrefab, spawnPowerUp.position, Quaternion.identity, transform);
        }
    }
}
