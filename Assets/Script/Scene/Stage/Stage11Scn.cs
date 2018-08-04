using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Stage11Scn : MonoBehaviour {

    // ステージ11クリア判定
    public static bool stage11Clear = false;

    private void Awake()
    {

        GameObject.Find("StageManager").SendMessage("resetMethod"); // タイマー・HPリセット

    }

}