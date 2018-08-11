using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage5Scn : MonoBehaviour {
    
    private GameObject gamestartCanvas;
    private GameObject stageJudgeManager;

    // ステージ5クリア判定
    public static bool stage5Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        stageJudgeManager = GameObject.Find("StageJudgeManager");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public void clearFive()
    {
        if (stage5Clear == false)
        {
            stageJudgeManager.SendMessage("stageJudgeCount");
            stage5Clear = true;
        }
    }

}