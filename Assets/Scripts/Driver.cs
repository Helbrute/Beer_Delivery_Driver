using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Driver : MonoBehaviour
{
    //Variables
    [SerializeField] float steerSpeed = 200f;
    [SerializeField] float moveSpeed = 5f;
    [SerializeField] float boostSpeed = 10f;
    [SerializeField] float boostDuration = 30f;
    private float bumperDuration = 0.5f;


    private void Update()
    {
        float steerAmount = Input.GetAxis("Horizontal") * steerSpeed * Time.deltaTime;
        float moveAmount = Input.GetAxis("Vertical") * moveSpeed * Time.deltaTime;

        transform.Rotate(0, 0, -steerAmount);
        transform.Translate(0, moveAmount, 0f);
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.tag == "trigger_area")
        {
            moveSpeed = 3f;
        }
        if (other.tag == "Booster")
        {
            StartCoroutine(BoostDelay(boostSpeed, boostDuration));
        }
        if (other.tag == "Bumper")
        {
            StartCoroutine(Bumper(bumperDuration));
        }
    }

    private IEnumerator BoostDelay(float speed, float timer)
    {
        Debug.Log("You just entered Booster");
        moveSpeed = speed;
        yield return new WaitForSeconds(timer);
        Debug.Log("Time's up!");
        moveSpeed = 5f;
    }

    private IEnumerator Bumper(float timer)
    {
        moveSpeed /= 2;
        yield return new WaitForSeconds(timer);
        moveSpeed = 5f;
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.tag == "trigger_area")
        {
            moveSpeed = 5f;
        }
    }
}