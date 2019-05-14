using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Stage12Scn : MonoBehaviour
{

  private GameObject gamestartCanvas;
  private GameObject stageJudgeManager;

  // ステージ12クリア判定
  public static bool stage12Clear = false;

  private float fadeTime;

  private void Awake()
  {
    gamestartCanvas = GameObject.Find("GameStartCanvas");
    stageJudgeManager = GameObject.Find("StageJudgeManager");
  }

  private void Start()
  {
    gamestartCanvas.SetActive(true);

    fadeTime = FadeAnimation.Instance.valueFadeTime();
  }

  public void clearTwelve()
  {
    if (stage12Clear == false)
    {
      stageJudgeManager.SendMessage("stageJudgeCount");
      stage12Clear = true;
    }
  }

  public void endMethod()
  {
    PlayerStateManager.Instance.gameFinishMethod();
    PlayerStateManager.Instance.sendClear();
    GameModeManager.Instance.gameClear();
    StageJudgeManager.Instance.stageJudgeCount();
    FadeAnimation.Instance.goFadeOut();
    StartCoroutine(endCor());
  }

  IEnumerator endCor()
  {
    yield return new WaitForSeconds(fadeTime);
    SceneManager.LoadScene("Ending");
  }

}