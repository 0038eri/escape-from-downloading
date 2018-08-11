using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage4Scn : MonoBehaviour {

    private GameObject gamestartCanvas;

    // ステージ4クリア判定
    public static bool stage4Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

}