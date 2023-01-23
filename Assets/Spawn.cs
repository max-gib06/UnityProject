using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject spawn;
    private float respawn;
    public float timeTospawn;

    public void get()
    {
        Instantiate(spawn, transform.position, transform.rotation);
    }
     void Update()
    {
        SpawnEnemy();
    }
    public void SpawnEnemy()
    {
        if (respawn > 0)
        {
            respawn -= Time.deltaTime;
            respawn = timeTospawn;
        }
        else
        {
            SpawnEnemy();

        }


    }
}
