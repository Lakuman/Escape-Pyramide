using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
    public Transform player;
    public Vector3 offset;
    public float rotationForce = 2f;
	
	// Update is called once per frame
	void Update () {

        Vector3 v3 = new Vector3(Input.GetAxis("Vertical"), 0.0f, 0.0f);
        transform.Rotate(v3 * rotationForce * Time.deltaTime);
        if (Input.GetKey(KeyCode.Space))
        {
            transform.rotation = Quaternion.Euler(0,0,0);
        }
    }
}
