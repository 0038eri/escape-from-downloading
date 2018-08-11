using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage7Scn : MonoBehaviour {

    private GameObject gamestartCanvas;
    private GameObject stageJudgeManager;

    // ステージ7クリア判定
    public static bool stage7Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        stageJudgeManager = GameObject.Find("stageJudgeManager");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public void clearSeven()
    {
        if (stage7Clear == false)
        {
            stageJudgeManager.SendMessage("stageJudgeCount");
            stage7Clear = true;
        }
    }

}