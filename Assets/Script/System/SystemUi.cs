using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemUi : MonoBehaviour {

    private GameObject playerUiManager;
    private PlayerUi playerUi;
    private GameObject timerManager;

    public GameObject pauseUi;

    public GameObject gameClearUi;
    public GameObject gameOverUi;

    void Awake()
    {
        playerUiManager = GameObject.Find("PlayerUiManager");
        playerUi = playerUiManager.GetComponent<PlayerUi>();
        timerManager = GameObject.Find("TimerManager");
    }

    public void openPauseUi()
    {
        timerManager.SendMessage("stopTimer");
        playerUi.closePlayerUi();
        pauseUi.SetActive(true);
    }

    public void closePauseUi()
    {
        pauseUi.SetActive(false);
        playerUi.openPlayerUi();
    }

    public void displayClear()
    {
        playerUi.closePlayerUi();
        gameClearUi.SetActive(true);
    }

    public void displayOver()
    {
        playerUi.closePlayerUi();
        gameOverUi.SetActive(true);
    }

    public void destroyPauseUi()
    {
        pauseUi.SetActive(false);
    }

    public void destroyClear()
    {
        gameClearUi.SetActive(false);
    }

    public void destroyOver()
    {
        gameOverUi.SetActive(false);
    }

}