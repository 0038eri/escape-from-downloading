using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemUi : MonoBehaviour {

    private GameObject timerManager;
    private GameObject playerUiManager;

    public GameObject pauseButton;
    public GameObject pauseUi;

    void Awake()
    {
        timerManager = GameObject.Find("TimerManager");
        playerUiManager = GameObject.Find("PlayerUiManager");
    }

    public void openPauseUi()
    {
        timerManager.SendMessage("stopTimer");
        pauseButton.SetActive(false);
        pauseUi.SetActive(true);
    }

    public void closePauseUi()
    {
        pauseUi.SetActive(false);
        pauseButton.SetActive(true);
    }

    public void destroyPlayerUi()
    {
        playerUiManager.SendMessage("closePlayerUi");
        Debug.Log("に");
        pauseButton.SetActive(false);
    }

}