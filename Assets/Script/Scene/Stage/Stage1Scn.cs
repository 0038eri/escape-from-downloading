using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage1Scn : MonoBehaviour {
    
    // ステージ1クリア判定
    public static bool stage1Clear = false;

    private void Awake()
    {

        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット

    }

    private void Start()
    {

        GameObject.Find("StageManager").SendMessage("startTimer"); // タイマースタート

    }

}