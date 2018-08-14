using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Scn : MonoBehaviour {
    
    private GameObject stageJudgeManager;

    // ステージ2クリア判定
    public static bool stage2Clear = false;

    private void Awake()
    {
        stageJudgeManager = GameObject.Find("StageJudgeManager");
    }

    public void clearTwo()
    {
        if (stage2Clear == false)
        {
            stageJudgeManager.SendMessage("stageJudgeCount");
            stage2Clear = true;
        }
    }

}