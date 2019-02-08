using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour {
    public float speed;
    public float jump;
    public float rotationForce = 2f;
	
	// Update is called once per frame
	void Update () {
        Turn();
        Move();
	}
    private void Move()
    {
        if(Input.GetMouseButton(0))
        {
            transform.Translate(Vector3.forward * speed * Time.deltaTime, Space.Self);
        }
        else if (Input.GetMouseButton(1))
        {
            transform.Translate(Vector3.back * speed * Time.deltaTime, Space.Self);
        }
    }
    private void Turn()
    {
        Vector3 v3 = new Vector3(0.0f, Input.GetAxis("Horizontal"), 0.0f);
        transform.Rotate(v3 * rotationForce * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space))
        {
            transform.rotation = Quaternion.Euler(0, 0, 0);
        }
    }
}
