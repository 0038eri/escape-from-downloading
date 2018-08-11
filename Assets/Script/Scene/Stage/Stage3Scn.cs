using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3Scn : MonoBehaviour {

    private GameObject gamestartCanvas;
    private GameObject stageJudgeManager;

    // ステージ3クリア判定
    public static bool stage3Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        stageJudgeManager = GameObject.Find("StageJudgeManager");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public void clearThree()
    {
        if (stage3Clear == false)
        {
            stageJudgeManager.SendMessage("stageJudgeCount");
            stage3Clear = true;
        }
    }

}