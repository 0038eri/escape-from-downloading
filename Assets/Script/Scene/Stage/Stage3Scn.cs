using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3Scn : MonoBehaviour {

    private GameObject gamestartCanvas;

    // ステージ3クリア判定
    public static int stage3Clear = 0;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public int stage3Check()
    {
        return stage3Clear;
    }

    public void stage3Count()
    {
        stage3Clear++;
    }

}