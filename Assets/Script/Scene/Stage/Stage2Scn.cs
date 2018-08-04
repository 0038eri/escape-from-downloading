using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage2Scn : MonoBehaviour {

    // ステージ2クリア判定
    public static bool stage2Clear = false;

    private void Awake()
    {

        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット

    }

}