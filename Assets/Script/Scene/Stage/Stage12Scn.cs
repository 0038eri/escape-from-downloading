using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage12Scn : MonoBehaviour {

    private GameObject gamestartCanvas;
    private GameObject stageJudgeManager;

    // ステージ12クリア判定
    public static bool stage12Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        stageJudgeManager = GameObject.Find("StageJudgeManager");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public void clearTwelve()
    {
        if (stage12Clear == false)
        {
            stageJudgeManager.SendMessage("stageJudgeCount");
            stage12Clear = true;
        }
    }

}