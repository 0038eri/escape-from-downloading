﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageStateManager : SingletonMonoBehaviour<StageStateManager> {
    
    private GameObject pauseUi;
    private GameObject pauseButton;
    private float fadeTime = 2.0f;

    private void Start()
    {
        pauseUi = GameObject.Find("PauseCanvas");
        pauseButton = GameObject.Find("PauseButton");
    }

    public void pauseMethod()
    {
        SystemUiManager.Instance.openPauseUi();
        PlayerUiManager.Instance.falsePlayerUi();
        Time.timeScale = 0.0f;
    }

    // ゲームを再開する
    public void playGame () {
        SystemUiManager.Instance.closePauseUi();
        PlayerUiManager.Instance.truePlayerUi();
        Time.timeScale = 1.0f;
    }

    // メニューに戻る
    public void backMenuS ()
    {
        Time.timeScale = 1.0f;
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(backMenuS_Coroutine());
    }

    IEnumerator backMenuS_Coroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SystemUiManager.Instance.closePauseUi();
        TimerManager.Instance.resetTimer();
        GameModeManager.Instance.systemScene();
        SceneManager.LoadScene("Menu");
    }

    // ゲームをやめる
    public void escapeGameS () {
        Time.timeScale = 1.0f;
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(escapeGameS_Coroutine());
    }

    IEnumerator escapeGameS_Coroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SystemUiManager.Instance.closePauseUi();
        TimerManager.Instance.resetTimer();
        GameModeManager.Instance.systemScene();
        SceneManager.LoadScene("Start");        
    }

}