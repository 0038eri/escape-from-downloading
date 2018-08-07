using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage4Scn : MonoBehaviour {

    private GameObject gamestartCanvas;

    // ステージ4クリア判定
    public static int stage4Clear = 0;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public int stage4Check()
    {
        return stage4Clear;
    }

    public void stage4Count()
    {
        stage4Clear++;
    }

}