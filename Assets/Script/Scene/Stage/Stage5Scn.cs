using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage5Scn : MonoBehaviour {
    
    private GameObject gamestartCanvas;

    // ステージ5クリア判定
    public static bool stage5Clear = false;

    private void Awake()
    {
        gamestartCanvas = GameObject.Find("GameStartCanvas");
    }

    private void Start()
    {
        gamestartCanvas.SetActive(true);
    }

}