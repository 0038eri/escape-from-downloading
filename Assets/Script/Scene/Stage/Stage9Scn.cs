using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage9Scn : MonoBehaviour {

    private GameObject gamestartCanvas;
    
    // ステージ9クリア判定
    public static int stage9Clear = 0;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public int stage9Check()
    {
        return stage9Clear;
    }

    public void stage9Count()
    {
        stage9Clear++;
    }

}