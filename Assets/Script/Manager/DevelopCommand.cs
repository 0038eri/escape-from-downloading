using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class DevelopCommand : MonoBehaviour {

	void Update () {

        // W,A,D,S はプレイヤー操作キー

        /// ゲームクリア判定送信
        if(Input.GetKeyDown(KeyCode.C)){
            GameObject.Find("PlayerManager").SendMessage("gameClear");   
        }

        /// ゲームオーバー判定送信
        if(Input.GetKeyDown(KeyCode.O)){
            GameObject.Find("PlayerManager").SendMessage("gameOver");   
        }

        /// ゲームポーズ判定送信
        if(Input.GetKeyDown(KeyCode.P)){
            GameObject.Find("StageManager").SendMessage("pause");
        }

        /// ゲームを再開する
        if(Input.GetKeyDown(KeyCode.R)){
            GameObject.Find("StageManager").SendMessage("playGame");
        }

        /// 次のゲームに進む
        if(Input.GetKeyDown(KeyCode.N)){
            GameObject.Find("PlayerManager").SendMessage("nextGame");
        }

        /// もう一度遊ぶ
        if(Input.GetKeyDown(KeyCode.M)){
            GameObject.Find("PlayerManager").SendMessage("onemoreGame");
        }

        /// メニューに戻る
        if(Input.GetKeyDown(KeyCode.B)){
            GameObject.Find("PlayerManager").SendMessage("backMenuG");
        }

        /// ゲームをやめる
        if(Input.GetKeyDown(KeyCode.Escape)){
            GameObject.Find("PlayerManager").SendMessage("escapeGameG");
        }

	}

}