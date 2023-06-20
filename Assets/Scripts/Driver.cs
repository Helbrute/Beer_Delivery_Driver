using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //Variables
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float baseMoveSpeed = 5f;
    [SerializeField] float boostSpeed = 7f;
    [SerializeField] float boostDuration = 5f;

    private void Start()
    {
        
    }

    private void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * baseMoveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0f);
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        Debug.Log("Get out of my lawn!!!");
        baseMoveSpeed = 3f;

        if (other.tag == "Booster")
        {
            baseMoveSpeed = boostSpeed;
            //StartCoroutine(ResetSpeed(baseMoveSpeed, boostDuration));
        }

    }

    //private IEnumerator ResetSpeed(float moveSpeed, float delay)
    //{
    //    moveSpeed = boostSpeed;
    //    yield return new WaitForSeconds(delay);
    //    moveSpeed = baseMoveSpeed;
    //}

    private void OnTriggerExit2D(Collider2D other)
    {
        Debug.Log("That's right!");
        baseMoveSpeed = 5f;
    }
}