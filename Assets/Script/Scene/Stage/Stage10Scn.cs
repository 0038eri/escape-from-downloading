using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage10Scn : MonoBehaviour {

    private GameObject gamestartCanvas;

    // ステージ10クリア判定
    public static int stage10Clear = 0;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public int stage10Check()
    {
        return stage10Clear;
    }

    public void stage10Count()
    {
        stage10Clear++;
    }
}