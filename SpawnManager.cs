using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject Prefab;
    public float spawnRange = 9;
    private float startDelay = 2;
    private float spawnInterval = 3.0f;

    void Start()
    {
        InvokeRepeating("SpawnPrefab", startDelay, spawnInterval);
    }

    
    void Update()
    {
        
    }
    private Vector3 GenerateSpawnPosition(){
        float spawnPosX = Random.Range(-spawnRange, spawnRange);
        float spawnPosZ = Random.Range(-spawnRange, spawnRange);
        Vector3 randomPos = new Vector3(spawnPosX, 0, spawnPosZ);
        return randomPos;

    }
    void SpawnPrefab()
    {
        Instantiate(Prefab, GenerateSpawnPosition(), Prefab.transform.rotation);
    }
}
