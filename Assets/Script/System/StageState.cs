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
        systemUiManager.SendMessage("closePauseUi");
        timerManager.SendMessage("startTimer");
    }

    // メニューに戻る
    public void backMenuS () {
        timerManager.SendMessage("resetTimer");
        systemUiManager.SendMessage("destroyPauseUi");
        SceneManager.LoadScene("Menu");
    }

    // ゲームをやめる
    public void escapeGameS () {
        timerManager.SendMessage("resetTimer");
        // アプリ終了
    }

}