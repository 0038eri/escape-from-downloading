using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DevelopCommand : MonoBehaviour {

    private void Awake()
    {
        DontDestroyOnLoad(gameObject);
    }

    void Update () {

        // W,A,D,S はプレイヤー操作キー

        /// ゲームクリア判定送信
        if(Input.GetKeyDown(KeyCode.C)){
            Debug.Log("gameClearMethod");
            GameObject.Find("PlayerManager").SendMessage("gameClearMethod");   
        }
        /// ゲームオーバー判定送信
        if(Input.GetKeyDown(KeyCode.O)){
            Debug.Log("gameOverMethod");
            GameObject.Find("PlayerManager").SendMessage("gameOverMethod");   
        }
        /// ゲームを再開する
        if(Input.GetKeyDown(KeyCode.P)){
            Debug.Log("playGame");
            GameObject.Find("StageManager").SendMessage("playGame");
        }
        /// 次のゲームに進む
        if(Input.GetKeyDown(KeyCode.N)){
            Debug.Log("nextGame");
            GameObject.Find("PlayerManager").SendMessage("nextGame");
        }
        /// もう一度遊ぶ
        if(Input.GetKeyDown(KeyCode.R)){
            Debug.Log("restartGame");
            GameObject.Find("PlayerManager").SendMessage("restartGame");
        }
        /// メニューに戻る
        if(Input.GetKeyDown(KeyCode.M)){
            Debug.Log("backMenuP");
            GameObject.Find("PlayerManager").SendMessage("backMenuP");
        }
        /// ゲームをやめる
        if(Input.GetKeyDown(KeyCode.E)){
            Debug.Log("escapeGameP");
            GameObject.Find("PlayerManager").SendMessage("escapeGameP");
        }
	}

}