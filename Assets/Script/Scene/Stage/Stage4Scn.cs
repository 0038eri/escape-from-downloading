using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage4Scn : MonoBehaviour {

    private GameObject gamestartCanvas;
    private GameObject stageJudgeManager;

    // ステージ4クリア判定
    public static bool stage4Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        stageJudgeManager = GameObject.Find("StageJudgeManager");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public void clearFour()
    {
        if (stage4Clear == false)
        {
            stageJudgeManager.SendMessage("stageJudgeCount");
            stage4Clear = true;
        }
    }

}