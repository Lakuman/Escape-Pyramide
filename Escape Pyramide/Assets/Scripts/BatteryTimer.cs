using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BatteryTimer : MonoBehaviour {

    public float currentTime;
    public Light flashLightCenter;
    public Light flashLightSide;
    public Light flashLightHardSides;
    public float noBatteryTime = 3600 ;
    public  bool TimerInPause;
    public bool gameInPause;
    private bool noBattery = false;

    private bool flashLightStatut;
    private Color color;

    public Image battery1;
    public Image battery2;
    public Image battery3;
    public Image battery4;
    public Image battery5;
    public Image battery6;

    // Use this for initialization
    void Start () {
        TimerInPause = false;
        //Blue Full Charge Color
        color = new Color32(0, 120, 255, 255);
    }
	// Update is called once per frame
	void Update () {
        flashLightSide.enabled = flashLightStatut;
        flashLightCenter.enabled = flashLightStatut;
        flashLightHardSides.enabled = flashLightStatut;
        if (noBattery ==false)
        {
            FlashLightBattery();
            SwitchOffFlashLight();
        }
        ChangeColor();
    }
    private void FlashLightBattery()
    {
        if (TimerInPause == false)
        {
            currentTime += Time.deltaTime;
            flashLightStatut = true;
        }
        else
        {
            Debug.Log("GameinPause");
            flashLightStatut = false;
        }


        if ((currentTime >= noBatteryTime / 6) && (currentTime < (noBatteryTime / 6) * 2))
        {
            Debug.Log("Battery1");
            color = new Color32(0, 255, 35, 255);
            battery1.enabled = false;
        }
        else if ((currentTime >= (noBatteryTime / 6) * 2) && (currentTime < (noBatteryTime / 6) * 3))
        {
            Debug.Log("Battery2");
            battery2.enabled = false;
        }
        else if ((currentTime >= (noBatteryTime / 6) * 3) && (currentTime < (noBatteryTime / 6) * 4))
        {
            Debug.Log("Battery3");
            color = new Color32(241, 150, 0, 255);
            battery3.enabled = false;
        }
        else if ((currentTime >= (noBatteryTime / 6) * 4) && (currentTime < (noBatteryTime / 6) * 5))
        {
            Debug.Log("Battery4");
            battery4.enabled = false;
        }
        else if ((currentTime >= (noBatteryTime / 6) * 5) && (currentTime < noBatteryTime))
        {
            Debug.Log("Battery5");
            color = new Color32(255, 23, 26, 255);
            battery5.enabled = false;
        }
        else if (currentTime >= noBatteryTime)
        {
            Debug.Log("Battery6");
            battery6.enabled = false;
            flashLightStatut = false;
            noBattery = true;
        }
    }
    private void SwitchOffFlashLight()
    {
        if(Input.GetKeyDown(KeyCode.X)){
            if(flashLightStatut == false)
            {
                flashLightStatut = true;
                TimerInPause = false;
            }
            else
            {
                flashLightStatut = false;
                TimerInPause = true;
            }
        }
    }
    private void ChangeColor()
    {
        battery1.color = color;
        battery2.color = color;
        battery3.color = color;
        battery4.color = color;
        battery5.color = color;
        battery6.color = color;
    }
}
