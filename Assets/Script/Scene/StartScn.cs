using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScn : MonoBehaviour
{

  private float fadeTime;

  // シーン遷移洗濯用ステージ1クリア判定
  private bool stage1Flag = false;

  private void Start()
  {
    stage1Flag = StageJudgeManager.Instance.stage1ClearSelect();
    GameModeManager.Instance.systemScene();
    SoundManager.Instance.playSound();
    fadeTime = FadeAnimation.Instance.valueFadeTime();
    FadeAnimation.Instance.goFadeIn();

  }

  private void Update()
  {

    // クリックした時
    if (Input.GetMouseButtonDown(0))
    {
      FadeAnimation.Instance.goFadeOut();
      if (stage1Flag)
      {
        StartCoroutine(selectCoroutine());
      }
      else
      {
        StartCoroutine(nextScnCoroutine());
      }
    }

  }

  IEnumerator selectCoroutine()
  {
    yield return new WaitForSeconds(fadeTime);
    SceneManager.LoadScene("Selectmode");
  }

  IEnumerator nextScnCoroutine()
  {
    yield return new WaitForSeconds(fadeTime);
    StageJudgeManager.Instance.sceneTransition();
  }

}