using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour {

    public GameObject pauseMenu;
    public BatteryTimer light;
    private bool pauseMenuStatut;

	// Use this for initialization
	void Start () {
        pauseMenu.SetActive(false);
    }
	
	// Update is called once per frame
	void Update () {
        OpenPauseMenu();
	}
    void OpenPauseMenu()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            if (pauseMenu.activeSelf == true )
            {
                pauseMenu.SetActive(false);
                light.gameInPause = false;
            }
            else if (pauseMenu.activeSelf == false)
            {
                pauseMenu.SetActive(true);
                light.gameInPause = true;
            }
        }
    }
}
