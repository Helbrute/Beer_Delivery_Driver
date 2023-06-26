using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    Driver driver;
    [SerializeField] Vector3 spawnPosition;
    //float spawnRate = 2f;
    private bool canSpawn = true;

    private void Start()
    {
        //canSpawn = true;
    }

    private void Update()
    {
        if (canSpawn == true)
        {
            Spawn();
        }

        if (prefab.activeSelf == true)
        {
            canSpawn = false;
            Debug.Log("Package Spawned");
        }
        if(prefab.activeSelf == false)
        {
            Debug.Log("Package Picked");
            canSpawn = true;
        }
    }

    //private void OnTriggerEnter2D(Collider2D other)
    //{
    //    if (other.tag == "Player")
    //    {
    //        canSpawn = false;
    //    }
    //}
    private void Spawn()
    {
        Instantiate(prefab, spawnPosition, Quaternion.identity);
    }

}
