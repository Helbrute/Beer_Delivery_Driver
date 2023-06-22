using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    [SerializeField] GameObject prefab;
    Driver driver;
    [SerializeField] Vector3 spawnPosition;
    float spawnRate = 2f;

    private void Awake()
    {
        driver = GetComponent<Driver>();
    }

    private void Update()
    {

    }

    private void Spawn()
    {
        Instantiate(prefab, spawnPosition, Quaternion.identity);
    }

}
