using System.Diagnostics;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
   

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    private float startDelay = 2;
    private float SpawnInterval = 1;
    void Start()
    {
        InvokeRepeating("SpawnRandomAnimal", startDelay, SpawnInterval);
    }

    // Update is called once per frame
    public GameObject[] animalPrefabs;
    private float spawnRangeX = 20;
    private float spawnPosZ = 20;
    void Update()
    {
      

            // Randomly generate animal index and spawn position

            void SpawnRandomAnimall()
            {
                int animalIndex = Random.Range(0, animalPrefabs.Length); ;
                Vector3 spawnPos = new Vector3(Random.Range(-spawnRangeX, spawnRangeX), 0, spawnPosZ);
                Instantiate(animalPrefabs[animalIndex], new Vector3(0, 0, 20),
                    animalPrefabs[animalIndex].transform.rotation);
            }
        }
    }