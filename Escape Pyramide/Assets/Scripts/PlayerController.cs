using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float jump;
    public float crouchSpeed = 500f;
    public float rotationForce = 2f;
    private bool isRunning = false;
    private bool isCrouching = false;

    // Update is called once per frame
    void FixedUpdate () {
        //RightShift
        Run();
        //ARROWS
        Move();
        //ZQSD
        Turn();
        //LeftShift
        Crouch();

    }
    private void Move()
    {
        if(Input.GetKey(KeyCode.UpArrow))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Translate(Vector3.left * speed * Time.deltaTime, Space.Self);
        }
        else if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Translate(Vector3.right * speed * Time.deltaTime, Space.Self);
        }
    }
    private void Turn()
    {
        Vector3 v3 = new Vector3(0.0f, Input.GetAxis("Horizontal"), 0.0f);
        transform.Rotate(v3 * rotationForce * Time.deltaTime); 
    }
    private void Run()
    {
        if (Input.GetKey(KeyCode.RightShift))
        {
            if (isRunning == false)
            {
                speed = speed + speed;
                isRunning = true;
            }
        }
        else 
        {
            if (isRunning == true)
            {
                speed = speed - (speed/2);
                isRunning = false;

            }
        }

    }
    private void Crouch()
    {
        if (Input.GetKey(KeyCode.LeftShift))
        {
            
            if (isCrouching == false)
            {
                speed = speed - (speed / 2);
                isCrouching = true;
                transform.localScale = transform.localScale / 2;
            }
        }
        else
        {
            if (isCrouching == true)
            {
                speed = speed * 2;
                isCrouching = false;
                transform.localScale = transform.localScale * 2;
            }
        }
    }
}
