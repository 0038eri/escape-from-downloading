using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1Scn : MonoBehaviour
{

  private GameObject stageJudgeManager;

  // ステージ1クリア判定
  public static bool stage1Clear = false;

  private void Awake()
  {
    stageJudgeManager = GameObject.Find("StageJudgeManager");
  }

  public void clearOne()
  {
    if (stage1Clear == false)
    {
      stageJudgeManager.SendMessage("stageJudgeCount");
      stage1Clear = true;
      StageJudgeManager.stage1Clear_select = true;
    }
  }

}