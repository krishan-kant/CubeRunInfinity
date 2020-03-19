using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BlockSpawner : MonoBehaviour
{
    public Transform[] spawnPoints;
    public GameObject blockPrefab;
    private float timeBetweenWaves = 1.0f;
    private float timeToSpawn = 0.0f;


    void Update()
    {
        if (Time.time >= timeToSpawn)
        {
            SpawnBlocks();
            timeToSpawn = Time.time + timeBetweenWaves;
            currS.currScor += 10;
            highS.currScor1 += 10;
        }

    }

    void SpawnBlocks()
    {
        int randomIndex = Random.Range(0, spawnPoints.Length);

        for (int i = 0; i < spawnPoints.Length; i++)
        {
            if (randomIndex != i)
            {
                Instantiate(blockPrefab, spawnPoints[i].position, Quaternion.identity);
            }
        }
    }
}
