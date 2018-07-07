using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DevelopCommand : MonoBehaviour {

    //private void Start()
    //{
    //    DontDestroyOnLoad(gameObject);
    //}

    void Update () {

        // W,A,D,S はプレイヤー操作キー

        /// ゲームクリア判定送信
        if(Input.GetKeyDown(KeyCode.C)){
            Debug.Log("gameClear");
            GameObject.Find("PlayerManager").SendMessage("gameClear");   
        }

        /// ゲームオーバー判定送信
        if(Input.GetKeyDown(KeyCode.O)){
            Debug.Log("gameOver");
            GameObject.Find("PlayerManager").SendMessage("gameOver");   
        }

        /// ゲームポーズ判定送信
        if(Input.GetKeyDown(KeyCode.P)){
            Debug.Log("pause");
            GameObject.Find("StageManager").SendMessage("pause");
        }

        /// ゲームを再開する
        if(Input.GetKeyDown(KeyCode.R)){
            Debug.Log("playGame");
            GameObject.Find("StageManager").SendMessage("playGame");
        }

        /// 次のゲームに進む
        if(Input.GetKeyDown(KeyCode.N)){
            Debug.Log("nextGame");
            GameObject.Find("PlayerManager").SendMessage("nextGame");
        }

        /// もう一度遊ぶ
        if(Input.GetKeyDown(KeyCode.M)){
            Debug.Log("onemoreGame");
            GameObject.Find("PlayerManager").SendMessage("onemoreGame");
        }

        /// メニューに戻る
        if(Input.GetKeyDown(KeyCode.B)){
            Debug.Log("backMenuG");
            GameObject.Find("PlayerManager").SendMessage("backMenuG");
        }

        /// ゲームをやめる
        if(Input.GetKeyDown(KeyCode.Escape)){
            Debug.Log("escapeGameG");
            GameObject.Find("PlayerManager").SendMessage("escapeGameG");
        }

	}

    public void DebugConsole () {
        Debug.Log("デバッグ");
    }

}