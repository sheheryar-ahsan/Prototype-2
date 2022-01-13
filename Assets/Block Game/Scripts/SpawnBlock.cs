using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnBlock : MonoBehaviour
{
    public GameObject[] blockPrefabs;
    private float spawnPosX = -4.5f;
    private float spawnPosZ = 3.0f;

    private float startDelay = 2;
    private float endDelay = 1.5f;

    void Start()
    {
        InvokeRepeating("BlockSpawnManager",startDelay,endDelay);
        InvokeRepeating("BlockSpawnManager", startDelay, endDelay);
        InvokeRepeating("BlockSpawnManager", startDelay, endDelay);

    }
    void BlockSpawnManager()
    {
        Vector3 spawnPos = new Vector3(spawnPosX, 0, Random.Range(-spawnPosZ, spawnPosZ));
        // For Creating blocks
        int blockIndex = Random.Range(0, blockPrefabs.Length);
        Instantiate(blockPrefabs[blockIndex], spawnPos, blockPrefabs[blockIndex].transform.rotation);
    }
}
