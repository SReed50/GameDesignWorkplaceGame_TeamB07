using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{

    public GameObject[] myObjects;
    public int spawnCount;

    void Start()
    {
        while (spawnCount < 125) {
            spawn();
        }
            
    }

    public void spawn () {
        int randomIndex = Random.Range(0, myObjects.Length);
        Vector3 randomSpawnPosition = new Vector3(Random.Range(-315, 185), 1.5f, Random.Range(0, 85));

        Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
        spawnCount++;

    }
}

