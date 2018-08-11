using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage3Scn : MonoBehaviour {

    private GameObject gamestartCanvas;

    // ステージ3クリア判定
    public static bool stage3Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

}