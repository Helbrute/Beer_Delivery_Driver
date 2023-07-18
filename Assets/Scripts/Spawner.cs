using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    [SerializeField] Vector3 spawnPosition;
    public Driver driver;
    private bool canSpawn = true;

    private void Start()
    {
        driver = GetComponent<Driver>();
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
        else if(prefab.activeSelf == false)
        {
            Debug.Log("Package Picked");
            canSpawn = true;
        }
    }

    public void Spawn()
    {
        Instantiate(prefab, spawnPosition, Quaternion.identity);
    }
}
