using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage11Scn : MonoBehaviour {

    private GameObject gamestartCanvas;

    // ステージ11クリア判定
    public static int stage11Clear = 0;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public int stage11Check()
    {
        return stage11Clear;
    }

    public void stag11Count()
    {
        stage11Clear++;
    }

}