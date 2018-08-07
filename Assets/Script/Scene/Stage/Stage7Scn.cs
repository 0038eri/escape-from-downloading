using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage7Scn : MonoBehaviour {

    private GameObject gamestartCanvas;

    // ステージ7クリア判定
    public static int stage7Clear = 0;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public int stage7Check()
    {
        return stage7Clear;
    }

    public void stage7Count()
    {
        stage7Clear++;
    }

}