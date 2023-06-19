using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Follow : MonoBehaviour
{
    [SerializeField] GameObject car;

    void Update()
    {
        transform.position = car.transform.position;
        transform.rotation = car.transform.rotation;
    }
}
