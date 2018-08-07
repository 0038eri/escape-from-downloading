using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage5Scn : MonoBehaviour {
    
    private GameObject gamestartCanvas;

    // ステージ5クリア判定
    public static int stage5Clear = 0;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public int stage5Check()
    {
        return stage5Clear;
    }

    public void stage5Count()
    {
        stage5Clear++;
    }

}