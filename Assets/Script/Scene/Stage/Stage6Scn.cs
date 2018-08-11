using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage6Scn : MonoBehaviour {

    private GameObject gamestartCanvas;
    private GameObject stageJudgeManager;

    // ステージ6クリア判定
    public static bool stage6Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        stageJudgeManager = GameObject.Find("StageJudgeManager");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public void clearSix()
    {
        if (stage6Clear == false)
        {
            stageJudgeManager.SendMessage("stageJudgeCount");
            stage6Clear = true;
        }
    }

}