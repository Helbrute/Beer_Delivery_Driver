using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    //Scripts callback
    Driver player;
    Collision collision;

    //Objects
    [SerializeField] GameObject packageImage;

    private void Awake()
    {
        collision = GetComponent<Collision>();  
        player = GetComponent<Driver>();
    }
    private void Start()
    {
        packageImage.SetActive(false);
    }

    private void Update()
    {
        if (collision.hasPackage)
        {
            Debug.Log("Has package = true");
        }
    }

}
