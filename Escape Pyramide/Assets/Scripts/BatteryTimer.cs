using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryTimer : MonoBehaviour {

    public float currentTime;
    public Light flashLightCenter;
    public Light flashLightSide;
    public float noBatteryTime = 3600 ;
    public  bool gameInPause;

    private float pauseTime;

    public Image battery1;
    public Image battery2;
    public Image battery3;
    public Image battery4;

    // Use this for initialization
    void Start () {
        gameInPause = false;
    }
	
	// Update is called once per frame
	void Update () {
        if(gameInPause == false)
        {
            currentTime += Time.deltaTime;
        }
        else
        {
            Debug.Log("GameinPause");
        }
        if ((currentTime >= noBatteryTime/5)&&(currentTime < (noBatteryTime / 5)*2))
        {
            Debug.Log("Battery1");
            battery1.enabled = false;
        }
        else if ((currentTime >= (noBatteryTime / 5) * 2) && (currentTime < (noBatteryTime / 5) * 3))
        {
            Debug.Log("Battery2");
            battery2.enabled = false;
        }
        else if ((currentTime >= (noBatteryTime / 5) * 3) && (currentTime < (noBatteryTime / 5) * 4))
        {
            Debug.Log("Battery3");
            battery3.enabled = false;
        }
        else if ((currentTime >= (noBatteryTime / 5) * 4) && (currentTime < noBatteryTime))
        {
            Debug.Log("Battery4");
            battery4.color = new Color32(238,58,58,255);
        }
        else if (currentTime >= noBatteryTime)
        {
            battery4.enabled = false;
            flashLightSide.enabled = false;
            flashLightCenter.enabled = false;
        }
    }
}
