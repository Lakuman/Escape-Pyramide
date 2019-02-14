using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public BatteryTimer lightBattery;
    public Camera playerCamera;
    public Camera menuCamera;
    public GameObject panelFlashLight;
    public GameObject player;

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
            // Display Menu Camera
            if (playerCamera.enabled == true)
            {
                player.SetActive(false);
                panelFlashLight.SetActive(false);
                lightBattery.TimerInPause = true;
                lightBattery.gameInPause = true;
                playerCamera.enabled = false;
                menuCamera.enabled = true;
            }
            // Display Play Camera
            else if (playerCamera.enabled == false)
            {
                player.SetActive(true);
                panelFlashLight.SetActive(true);
                lightBattery.gameInPause = false;
                lightBattery.TimerInPause = false;
                playerCamera.enabled = true;
                menuCamera.enabled = false;
            }
        }
    }
}
