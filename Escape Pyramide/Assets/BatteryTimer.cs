using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatteryTimer : MonoBehaviour {

    public float currentTime;
    public Light flashLight;
    public float noBatteryTime = 3600 ;
    public bool gameInPause;

    private float startTime;
    private float pauseTime;
    
    // Use this for initialization
    void Start () {
        gameInPause = true;
        currentTime = Time.deltaTime;
        startTime = currentTime;
	}
	
	// Update is called once per frame
	void Update () {
        if(gameInPause == false)
        {
            
            Debug.Log(currentTime);
            currentTime += Time.deltaTime;
        }
        
        if(currentTime >= 3600)
        {
            Destroy(flashLight);
        }
    }
}
