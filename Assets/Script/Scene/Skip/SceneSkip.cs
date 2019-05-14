using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSkip : SingletonMonoBehaviour<SceneSkip>
{

  private float fadeTime;

  private void Start()
  {
    fadeTime = FadeAnimation.Instance.valueFadeTime();
  }

  /// オープニングより
  /// ステージ1に移動
  public void skipToStage1()
  {
    FadeAnimation.Instance.goFadeOut();
    StartCoroutine(fromOpCoroutine());
  }

  IEnumerator fromOpCoroutine()
  {
    yield return new WaitForSeconds(fadeTime);
    SceneManager.LoadScene("Stage1");
  }

  /// エンディングより
  /// スタート画面に移動
  public void backToStart()
  {
    FadeAnimation.Instance.goFadeOut();
    StartCoroutine(fromEdCoroutine());
  }

  IEnumerator fromEdCoroutine()
  {
    yield return new WaitForSeconds(fadeTime);
    SceneManager.LoadScene("Start");
  }

}