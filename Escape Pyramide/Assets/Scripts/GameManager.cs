using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public BatteryTimer lightBattery;
    public Camera playerCamera;
    public Camera menuCamera;
    public GameObject panelFlashLight;

    //Data used by Battery flashlight Timer script
    private void Start()
    {
        playerCamera.enabled = true;
        menuCamera.enabled = false;
    }
    // Update is called once per frame
    void Update () {
        OpenPauseMenu();
    }
    //Switch camera between player or pauseMenu Camera
    void OpenPauseMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (playerCamera.enabled == true)
            {
                panelFlashLight.SetActive(false);
                lightBattery.gameInPause = true;
                playerCamera.enabled = false;
                menuCamera.enabled = true;
            }
            else if (playerCamera.enabled == false)
            {
                panelFlashLight.SetActive(true);
                lightBattery.gameInPause = false;
                playerCamera.enabled = true;
                menuCamera.enabled = false;
            }
        }
    }
}
