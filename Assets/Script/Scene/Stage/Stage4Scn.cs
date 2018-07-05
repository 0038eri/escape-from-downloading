using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage4Scn : MonoBehaviour {

    // ステージ4クリア判定
    public static bool stage4Clear = false;

    private void Awake()
    {

        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット

    }

    private void Start()
    {

        GameObject.Find("StageManager").SendMessage("startTimer"); // タイマースタート

    }

}