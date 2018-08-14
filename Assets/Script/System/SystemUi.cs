using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemUi : MonoBehaviour {

    private GameObject playerUiManager;
    private GameObject timerManager;

    private GameObject pauseUi;
    private Canvas pauseCanvas;

    private GameObject gameClearUi;
    private Canvas clearCanvas;
    private GameObject gameOverUi;
    private Canvas overCanvas;

    void Awake()
    {
        playerUiManager = GameObject.Find("PlayerUiManager");
        timerManager = GameObject.Find("TimerManager");

        pauseUi = GameObject.Find("PauseCanvas");
        pauseCanvas = pauseUi.GetComponent<Canvas>();
        gameClearUi = GameObject.Find("ClearCanvas");
        clearCanvas = gameClearUi.GetComponent<Canvas>();
        gameOverUi = GameObject.Find("OverCanvas");
        overCanvas = gameOverUi.GetComponent<Canvas>();
    }

    public void openPauseUi()
    {
        timerManager.SendMessage("stopTimer");
        playerUiManager.SendMessage("falsePlayerUi");
        pauseCanvas.enabled = true;
    }

    public void closePauseUi()
    {
        pauseCanvas.enabled = false;
        playerUiManager.SendMessage("truePlayerUi");
    }

    public void displayClear()
    {
        playerUiManager.SendMessage("falsePlayerUi");
        clearCanvas.enabled = true;
    }

    public void displayOver()
    {
        playerUiManager.SendMessage("falsePlayerUi");
        overCanvas.enabled = true;
    }

    public void destroyPauseUi()
    {
        pauseCanvas.enabled = false;
    }

    public void destroyClear()
    {
        clearCanvas.enabled = false;
    }

    public void destroyOver()
    {
        overCanvas.enabled = false;
    }

}