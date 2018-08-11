using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage9Scn : MonoBehaviour {

    private GameObject gamestartCanvas;
    private GameObject stageJudgeManager;

    // ステージ9クリア判定
    public static bool stage9Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        stageJudgeManager = GameObject.Find("StageJudgeManager");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public void clearNine()
    {
        if (stage9Clear == false)
        {
            stageJudgeManager.SendMessage("stageJudgeCount");
            stage9Clear = true;
        }
    }

}