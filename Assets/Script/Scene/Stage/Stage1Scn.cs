using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1Scn : MonoBehaviour {

    private GameObject gamestartCanvas;
    
    // ステージ1クリア判定
    public static int stage1Clear = 0;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

    public int stage1Check()
    {
        return stage1Clear;
    }

    public void stage1Count()
    {
        stage1Clear++;
    }

}