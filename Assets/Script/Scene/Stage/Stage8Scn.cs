using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage8Scn : MonoBehaviour {

    private GameObject gamestartCanvas;

    // ステージ8クリア判定
    public static int stage8Clear = 0;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public int stage8Check()
    {
        return stage8Clear;
    }

    public void stage8Count()
    {
        stage8Clear++;
    }

}