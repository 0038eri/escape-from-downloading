using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage10Scn : MonoBehaviour {

    private GameObject gamestartCanvas;

    // ステージ10クリア判定
    public static bool stage10Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

}