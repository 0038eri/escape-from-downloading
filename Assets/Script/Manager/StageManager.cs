using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour {

    // ステージクリア判定
    public static int stageNumber = 0;

    // タイマー
    private float timer = 60.0f;
    // 制限時間
    private float timeLimit = 0.0f;
    // タイマー停止判定
    public bool timerStop;
    // タイマー表示テキスト
    public Text timerText;

    // ポーズ画面
    public GameObject poseUi;

    void Update () {

        /// タイマーが停止しなかったら
        /// タイマーアップデートする
        if(timerStop==false){
            updateTimer(); 
        }

    }

    // タイマーを動かしている
    void updateTimer()
    {
        timer += (-1*Time.deltaTime); // タイマーを動かす
        timerText.text = ((int)timer).ToString() + " sec"; // 時間を整数で表示する
        if (timer == timeLimit) // もしタイマーが制限時間に達したら
        {
            GameObject.Find("PlayerManager").SendMessage("gameOver"); // ゲームオーバー
            resetTimer(); // タイマーをリセット
        }
    }

    // タイマーを開始
    public void startTimer () {
        timerStop = false;
    }

    // タイマーを停止
    public void stopTimer () {
        timerStop = true;  
    }

    // タイマーリセット
    public void resetTimer () {
        stopTimer(); //タイマーを停止
        timer = 60.0f; // タイマーリセット
    }

    // ポーズパネル表示
    public void pose () {
        Debug.Log("ぽーず");
        stopTimer(); // タイマーを停止
        // ゲームを停止
        poseUi.SetActive(true);
    }

    // ポーズパネル非表示
    public void poseUIFalse () {
        poseUi.SetActive(false);
    }

    // ゲームを再開する
    public void playGame () {
        poseUIFalse(); // ポーズパネルを非表示
        startTimer(); // タイマーをうごかす
        // ゲームを再生
    }

    // メニューに戻る
    public void backMenuP () {
        poseUIFalse(); // ポーズパネルを非表示
        SceneManager.LoadScene("Menu");
    }

    // ゲームをやめる
    public void escapeGameP () {
        poseUIFalse(); // ポーズパネルを非表示
        // アプリ終了
    }
      
}