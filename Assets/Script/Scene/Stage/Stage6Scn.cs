using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage6Scn : MonoBehaviour {

    private GameObject gamestartCanvas;
    
    // ステージ6クリア判定
    public static int stage6Clear = 0;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public int stage6Check()
    {
        return stage6Clear;
    }

    public void stage6Count()
    {
        stage6Clear++;
    }

}