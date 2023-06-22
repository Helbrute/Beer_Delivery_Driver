using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collision : MonoBehaviour
{
    //Variables
    [SerializeField] float destoroyTimer = 0.1f;
    [SerializeField] GameObject packageUI;
    public bool hasPackage = false;


    private void Start()
    {
        packageUI.SetActive(false);
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "Package" && hasPackage == false)
        {
            Debug.Log("Package picked up!");
            hasPackage = true;
            Destroy(other.gameObject, destoroyTimer);
            packageUI.SetActive(true);
        }

        if (other.tag == "Customer" && hasPackage == true)
        {
            Debug.Log("Package delivered!");
            hasPackage = false;
            packageUI.SetActive(false);
        }
    }
}
