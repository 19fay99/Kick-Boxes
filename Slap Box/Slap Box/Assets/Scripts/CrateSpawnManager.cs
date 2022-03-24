using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawnManager : MonoBehaviour
{
    public GameObject[] Prefabs;
    private float spawnRangex = -1;
    private float startDelay = 2;
    private float spawnInterval = 5;

    // Start is called before the first frame update
    void Start()
    {
        InvokeRepeating("SpawnCrate", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCrate()
    {
        int PrefabIndex = Random.Range(0, Prefabs.Length);
        Vector2 spawnPos = new Vector2(0,0);

        Instantiate(Prefabs[PrefabIndex], spawnPos, Prefabs[PrefabIndex].transform.rotation);
    }


}
