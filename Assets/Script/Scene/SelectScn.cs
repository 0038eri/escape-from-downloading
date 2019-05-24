using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SelectScn : MonoBehaviour
{

  private float fadeTime;

  void Start()
  {
    GameModeManager.Instance.selectScene();
    fadeTime = FadeAnimation.Instance.valueFadeTime();
    FadeAnimation.Instance.goFadeIn();
    StartCoroutine(selectCoroutine());
  }

  IEnumerator selectCoroutine()
  {
    yield return new WaitForSeconds(fadeTime);
    SoundManager.Instance.playSound();
  }

  public void menuFromSelect()
  {
    FadeAnimation.Instance.goFadeOut();
    StartCoroutine(menuFromS_coroutine());
  }

  public void gameFromSelect()
  {
    FadeAnimation.Instance.goFadeOut();
    StartCoroutine(gameFromS_coroutine());
  }

  IEnumerator menuFromS_coroutine()
  {
    yield return new WaitForSeconds(fadeTime);
    SceneManager.LoadScene("Menu");
  }

  IEnumerator gameFromS_coroutine()
  {
    yield return new WaitForSeconds(fadeTime);
    StageJudgeManager.Instance.sceneTransition();
  }

}
