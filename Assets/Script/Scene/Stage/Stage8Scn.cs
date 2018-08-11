using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage8Scn : MonoBehaviour {

    private GameObject gamestartCanvas;
    private GameObject stageJudgeManager;

    // ステージ8クリア判定
    public static bool stage8Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        stageJudgeManager = GameObject.Find("StageJudgeManager");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public void clearEight()
    {
        if (stage8Clear == false)
        {
            stageJudgeManager.SendMessage("stageJudgeCount");
            stage8Clear = true;
        }
    }

}