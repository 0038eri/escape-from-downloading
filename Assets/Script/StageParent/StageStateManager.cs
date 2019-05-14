using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageStateManager : SingletonMonoBehaviour<StageStateManager>
{

  private GameObject pauseUi;
  private GameObject pauseButton;
  private float fadeTime;
  private FadeAnimation fadeAnm;

  private void Start()
  {
    fadeTime = FadeAnimation.Instance.valueFadeTime();
    fadeAnm = GameObject.Find("SceneFadeSystem").GetComponent<FadeAnimation>();
    pauseUi = GameObject.Find("PauseCanvas");
    pauseButton = GameObject.Find("PauseButton");
  }

  public void pauseMethod()
  {
    GameModeManager.Instance.stopPlaying();
    PlayerUiManager.Instance.falsePlayerUi();
    SystemUiManager.Instance.openPauseUi();
    Time.timeScale = 0.0f;
  }

  // ゲームを再開する
  public void playGame()
  {
    GameModeManager.Instance.isPlaying();
    SystemUiManager.Instance.closePauseUi();
    PlayerUiManager.Instance.truePlayerUi();
    Time.timeScale = 1.0f;
  }

  // メニューに戻る
  public void backMenuS()
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
  public void escapeGameS()
  {
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
    // fadeAnm.nextSceneName = "Start";
  }

}