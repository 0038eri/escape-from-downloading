using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage12Scn : MonoBehaviour {

    private GameObject gamestartCanvas;

    // ステージ12クリア判定
    public static bool stage12Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

}