using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageStateManager : SingletonMonoBehaviour<StageStateManager> {

    // ポーズ画面
    public GameObject pauseUi;
    // ポーズボタン
    public GameObject pauseButton;

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