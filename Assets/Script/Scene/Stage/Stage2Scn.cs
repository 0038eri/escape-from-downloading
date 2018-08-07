using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Scn : MonoBehaviour {

    private GameObject gamestartCanvas;

    // ステージ2クリア判定
    public static int stage2Clear = 0;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public int stage2Check()
    {
        return stage2Clear;
    }

    public void stage2Count()
    {
        stage2Clear++;
    }

}