using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SystemUiManager : SingletonMonoBehaviour<SystemUiManager> {

    public GameObject[] canvases;
    private string gamemode;

    private void Awake()
    {
        //q
        //Debug.Log(canvases[1]);
    }

    public void openPauseUi()
    {
        canvases[0].SetActive(true);
    }

    public void closePauseUi()
    {
        canvases[0].SetActive(false);
    }

    public void displayClear()
    {
        canvases[1].SetActive(true);
    }

    public void displayOver()
    {
        canvases[2].SetActive(true);
    }

    public void destroyClear()
    {
        canvases[1].SetActive(false);
    }

    public void destroyOver()
    {
        canvases[2].SetActive(false);
    }

    public void playS()
    {
        StageStateManager.Instance.playGame();
    }

    public void menuS()
    {
        StageStateManager.Instance.backMenuS();
    }

    public void escapeS()
    {
        StageStateManager.Instance.escapeGameS();
    }

    public void nextP()
    {
        PlayerStateManager.Instance.nextGame();
    }

    public void restartP()
    {
        PlayerStateManager.Instance.restartGame();
    }

    public void menuP()
    {
        PlayerStateManager.Instance.backMenuP();
    }

    public void escapeP()
    {
        PlayerStateManager.Instance.escapeGameP();
    }

}