using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage7Scn : MonoBehaviour {

    private GameObject gamestartCanvas;

    // ステージ7クリア判定
    public static bool stage7Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

}