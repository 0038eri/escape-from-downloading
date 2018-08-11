using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage11Scn : MonoBehaviour {

    private GameObject gamestartCanvas;
    private GameObject stageJudgeManager;

    // ステージ11クリア判定
    public static bool stage11Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        stageJudgeManager = GameObject.Find("StageJudgeManager");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public void clearEleven()
    {
        if (stage11Clear == false)
        {
            stageJudgeManager.SendMessage("stageJudgeCount");
            stage11Clear = true;
        }
    }

}