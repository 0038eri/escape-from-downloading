using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage7Scn : MonoBehaviour {

    // ステージ7クリア判定
    public static bool stage7Clear = false;

    private void Awake()
    {

        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット

    }

    private void Start()
    {

        GameObject.Find("StageManager").SendMessage("startTimer"); // タイマースタート

    }

}