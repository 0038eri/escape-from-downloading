using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Scn : MonoBehaviour {

    private GameObject gamestartCanvas;
    private GameObject stageJudgeManager;

    // ステージ2クリア判定
    public static bool stage2Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        stageJudgeManager = GameObject.Find("StageJudgeManager");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
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