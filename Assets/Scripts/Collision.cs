using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    //Booleans
    bool hasPackage = false;

    //Variables
    [SerializeField] float destoroyTimer = 0.1f;
    [SerializeField] GameObject outline;


    private void Start()
    {
        outline.SetActive(false);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && hasPackage == false)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            Destroy(other.gameObject, destoroyTimer);
            outline.SetActive(true);
        }

        if (other.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Package delivered!");
            hasPackage = false;
            outline.SetActive(false);
        }
    }
}
