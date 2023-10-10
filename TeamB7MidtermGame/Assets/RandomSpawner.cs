using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomObjectSpawner : MonoBehaviour
{

    public GameObject[] myObjects;
    public int spawnCount;

    void Update()
    {
        if (spawnCount >= 200) {

        }
        else {
            spawn();
        }
            
    }

    public void spawn () {
                    int randomIndex = Random.Range(0, myObjects.Length);
            Vector3 randomSpawnPosition = new Vector3(Random.Range(-330, 300), 4, Random.Range(-160, 160));

            Instantiate(myObjects[randomIndex], randomSpawnPosition, Quaternion.identity);
            spawnCount++;

    }
}

