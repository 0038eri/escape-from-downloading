using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageState : MonoBehaviour {

    private GameObject gameModeManager;
    private GameObject timerManager;
    private GameObject systemUiManager;

    // ポーズ画面
    public GameObject pauseUi;
    // ポーズボタン
    public GameObject pauseButton;

    private void Awake()
    {
        gameModeManager = GameObject.Find("GameModeManager");
        timerManager = GameObject.Find("TimerManager");
        systemUiManager = GameObject.Find("SystemUiManager");
    }

    // ゲームを再開する
    public void playGame () {
        systemUiManager.SendMessage("closePauseUi");
        timerManager.SendMessage("startTimer");
    }

    // メニューに戻る
    public void backMenuS () {
        systemUiManager.SendMessage("destroyPauseUi");
        timerManager.SendMessage("resetTimer");
        gameModeManager.SendMessage("systemScene");
        SceneManager.LoadScene("Menu");
    }

    // ゲームをやめる
    public void escapeGameS () {
        systemUiManager.SendMessage("destroyPauseUi");
        timerManager.SendMessage("resetTimer");
        gameModeManager.SendMessage("systemScene");
        SceneManager.LoadScene("Start");
    }

}