using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SystemUiManager : SingletonMonoBehaviour<SystemUiManager> {

    private GameObject pauseUi;
    private Canvas pauseCanvas;

    private GameObject gameClearUi;
    private Canvas clearCanvas;
    private GameObject gameOverUi;
    private Canvas overCanvas;

    void Awake()
    {
        pauseUi = GameObject.Find("PauseCanvas");
        pauseCanvas = pauseUi.GetComponent<Canvas>();
        gameClearUi = GameObject.Find("ClearCanvas");
        clearCanvas = gameClearUi.GetComponent<Canvas>();
        gameOverUi = GameObject.Find("OverCanvas");
        overCanvas = gameOverUi.GetComponent<Canvas>();
    }

    public void openPauseUi()
    {
        TimerManager.Instance.stopTimer();
        PlayerUiManager.Instance.falsePlayerUi();
        pauseCanvas.enabled = true;
    }

    public void closePauseUi()
    {
        pauseCanvas.enabled = false;
        PlayerUiManager.Instance.truePlayerUi();
    }

    public void displayClear()
    {
        clearCanvas.enabled = true;
    }

    public void displayOver()
    {
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