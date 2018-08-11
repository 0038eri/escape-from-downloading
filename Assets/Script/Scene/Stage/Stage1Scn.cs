using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1Scn : MonoBehaviour {

    private GameObject gamestartCanvas;

    // ステージ1クリア判定
    public static bool stage1Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

}