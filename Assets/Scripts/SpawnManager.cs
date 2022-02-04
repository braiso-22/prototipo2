using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnLowPosZ = 20;
    private float spawnUpPosZ = 30;
    private float startDelay = 2;
    private float spawnInterval = 1.75f;
    void SpawnRandomAnimal()
    {
        Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, Random.Range(spawnLowPosZ, spawnUpPosZ));

        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], spawnPos, animalPrefabs[animalIndex].transform.rotation);
    }
    public void SpawnRandomAnimalHorizontal()
    {


        Vector3 spawnPos = new Vector3(20, 0, Random.Range(-6, 6));

        int animalIndex = Random.Range(0, animalPrefabs.Length);

        Instantiate(animalPrefabs[animalIndex], spawnPos, Quaternion.Euler(0, 270, 0));
    }
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal",
        startDelay, spawnInterval);
        InvokeRepeating("SpawnRandomAnimalHorizontal",
       0, 5);
    }
}
