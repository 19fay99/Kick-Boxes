using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CrateSpawnManager : MonoBehaviour
{
    public GameObject[] Prefabs;
    private float startDelay = 1;
    private float spawnInterval = 5;
    private GameManager gameManager;

    // Start is called before the first frame update
    void Start()
    {
        gameManager = GameObject.Find("Game Manager").GetComponent<GameManager>();
        InvokeRepeating("SpawnCrate", startDelay, spawnInterval);
    }

    // Update is called once per frame
    void Update()
    {

    }

    void SpawnCrate()
    {
        if (gameManager.isGameActive == true)
        {
            int PrefabIndex = Random.Range(0, Prefabs.Length);
            Vector2 spawnPos = new Vector2(.250f, -6.50f);

            Instantiate(Prefabs[PrefabIndex], spawnPos, Prefabs[PrefabIndex].transform.rotation);
        }
    }

}
