using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage12Scn : MonoBehaviour {

    private GameObject gamestartCanvas;

    // ステージ12クリア判定
    public static int stage12Clear = 0;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public int stage12Check()
    {
        return stage12Clear;
    }

    public void stage12Count()
    {
        stage12Clear++;
    }

}