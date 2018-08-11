using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage9Scn : MonoBehaviour {

    private GameObject gamestartCanvas;

    // ステージ9クリア判定
    public static bool stage9Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

}