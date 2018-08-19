using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemUiManager : SingletonMonoBehaviour<SystemUiManager> {
    
    private Canvas pauseCanvas;
    public Button[] buttonFromP;

    private Canvas clearCanvas;
    public Button[] buttonFromC;
    private Canvas overCanvas;
    public Button[] buttonFromO;

    void Awake()
    {
        pauseCanvas = GameObject.Find("PauseCanvas").GetComponent<Canvas>();
        clearCanvas = GameObject.Find("ClearCanvas").GetComponent<Canvas>();
        overCanvas = GameObject.Find("OverCanvas").GetComponent<Canvas>();
    }

    private void Start()
    {
        Debug.Log(buttonFromP[1]);
        buttonFromP[0].onClick.AddListener(playS);
        Debug.Log(StageStateManager.Instance);
        buttonFromP[1].onClick.AddListener(menuS);
        buttonFromP[2].onClick.AddListener(escapeS);
        buttonFromC[0].onClick.AddListener(nextP);
        buttonFromC[1].onClick.AddListener(menuP);
        buttonFromC[2].onClick.AddListener(escapeP);
        buttonFromO[0].onClick.AddListener(restartP);
        buttonFromO[1].onClick.AddListener(menuP);
        buttonFromO[2].onClick.AddListener(escapeP);
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

    void playS()
    {
        StageStateManager.Instance.playGame();
    }

    void menuS()
    {
        StageStateManager.Instance.backMenuS();
    }

    void escapeS()
    {
        StageStateManager.Instance.escapeGameS();
    }

    void nextP()
    {
        PlayerStateManager.Instance.nextGame();
    }

    void restartP()
    {
        PlayerStateManager.Instance.restartGame();
    }

    void menuP()
    {
        PlayerStateManager.Instance.backMenuP();
    }

    void escapeP()
    {
        PlayerStateManager.Instance.escapeGameP();
    }

}