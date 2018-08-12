using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageState : MonoBehaviour {
    
    private GameObject timerManager;
    private GameObject systemUiManager;

    // ポーズ画面
    public GameObject pauseUi;
    // ポーズボタン
    public GameObject pauseButton;

    private void Awake()
    {
        timerManager = GameObject.Find("TimerManager");
        systemUiManager = GameObject.Find("SystemUiManager");
    }

    // ゲームを再開する
    public void playGame () {
        Debug.Log("playGame");
        systemUiManager.SendMessage("closePauseUi");
        timerManager.SendMessage("startTimer");
    }

    // メニューに戻る
    public void backMenuS () {
        Debug.Log("backMenuS");
        timerManager.SendMessage("resetTimer");
        SceneManager.LoadScene("Menu");
    }

    // ゲームをやめる
    public void escapeGameS () {
        Debug.Log("escapeGameS");
        timerManager.SendMessage("resetTimer");
        SceneManager.LoadScene("Start");
    }

}