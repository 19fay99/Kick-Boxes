using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] RainPrefabs;
    private float spawnRangex = -1;
    private float spawnPosZ = 20;
    private float startDelay = 2;
    private float spawnInterval = 1.5f;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCloud", startDelay, spawnInterval);
    } 

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnCloud()
    {
        int rainprefabIndex = Random.Range(0, RainPrefabs.Length);
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangex, spawnRangex), -12.19709f, spawnPosZ);

        Instantiate(RainPrefabs[rainprefabIndex], spawnPos, RainPrefabs[rainprefabIndex].transform.rotation);
    }
}
