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
            PlayerStateManager.Instance.gameClearMethod();
        }
        /// ゲームオーバー判定送信
        if(Input.GetKeyDown(KeyCode.O)){
            Debug.Log("gameOverMethod");
            PlayerStateManager.Instance.gameOverMethod();
        }
        /// ゲームを再開する
        if(Input.GetKeyDown(KeyCode.P)){
            Debug.Log("playGame");
            StageStateManager.Instance.playGame();
        }
        /// 次のゲームに進む
        if(Input.GetKeyDown(KeyCode.N)){
            Debug.Log("nextGame");
            PlayerStateManager.Instance.nextGame();
        }
        /// もう一度遊ぶ
        if(Input.GetKeyDown(KeyCode.R)){
            Debug.Log("restartGame");
            PlayerStateManager.Instance.restartGame();
        }
        /// メニューに戻る
        if(Input.GetKeyDown(KeyCode.M)){
            Debug.Log("backMenuP");
            PlayerStateManager.Instance.backMenuP();
        }
        /// ゲームをやめる
        if(Input.GetKeyDown(KeyCode.E)){
            Debug.Log("escapeGameP");
            PlayerStateManager.Instance.escapeGameP();
        }
        if(Input.GetKeyDown(KeyCode.S)){
            Debug.Log("start");
            SceneManager.LoadScene("Start");
        }
	}

}