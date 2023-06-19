using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //Variables
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 5f;

    private void Start()
    {
        
    }

    private void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Get out of my lawn!!!");
        moveSpeed = 3f;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("That's right!");
        moveSpeed = 5f;
    }
}