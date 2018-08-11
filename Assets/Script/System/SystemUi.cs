using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemUi : MonoBehaviour {

    private GameObject timerManager;

    public GameObject pauseButton;
    public GameObject pauseUi;

    void Awake()
    {
        timerManager = GameObject.Find("TimerManager");
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

    public void DestroyPauseUi()
    {
        pauseUi.SetActive(false);
        pauseButton.SetActive(false);
    }

}