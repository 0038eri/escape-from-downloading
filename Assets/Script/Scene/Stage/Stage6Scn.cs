using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage6Scn : MonoBehaviour {

    // ステージ6クリア判定
    public static bool stage6Clear = false;

    private void Awake()
    {

        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット

    }

}