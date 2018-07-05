using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage9Scn : MonoBehaviour {

    // ステージ9クリア判定
    public static bool stage9Clear = false;

    private void Awake()
    {

        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット

    }

    private void Start()
    {

        GameObject.Find("StageManager").SendMessage("startTimer"); // タイマースタート

    }

}