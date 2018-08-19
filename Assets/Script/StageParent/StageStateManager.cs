using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageStateManager : SingletonMonoBehaviour<StageStateManager> {

    // ポーズ画面
    private GameObject pauseUi;
    // ポーズボタン
    private GameObject pauseButton;

    private void Awake()
    {
        pauseUi = GameObject.Find("PauseCanvas");
        pauseButton = GameObject.Find("PauseButton");
    }

    // ゲームを再開する
    public void playGame () {
        SystemUiManager.Instance.closePauseUi();
        TimerManager.Instance.startTimer();
    }

    // メニューに戻る
    public void backMenuS () {
        SystemUiManager.Instance.destroyPauseUi();
        TimerManager.Instance.resetTimer();
        GameModeManager.Instance.systemScene();
        SceneManager.LoadScene("Menu");
    }

    // ゲームをやめる
    public void escapeGameS () {
        SystemUiManager.Instance.destroyPauseUi();
        TimerManager.Instance.resetTimer();
        GameModeManager.Instance.systemScene();
        SceneManager.LoadScene("Start");
    }

}