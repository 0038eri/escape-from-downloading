using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage10Scn : MonoBehaviour {

    private GameObject gamestartCanvas;
    private GameObject stageJudgeManager;

    // ステージ10クリア判定
    public static bool stage10Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        stageJudgeManager = GameObject.Find("StageJudgeManager");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public void clearTen()
    {
        if (stage10Clear == false)
        {
            stageJudgeManager.SendMessage("stageJudgeCount");
            stage10Clear = true;
        }
    }

}