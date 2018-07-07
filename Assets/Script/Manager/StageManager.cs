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
    public static bool timerStop = true;
    // タイマー表示テキスト
    public Text timerText;

    // ポーズ画面
    public GameObject pauseUi;

    private void Start()
    {

        pauseUIFalse();
    }

    void Update () {

        /// タイマーが停止しなかったら
        /// タイマーアップデートする
        if(timerStop==false){
            updateTimer(); 
        }

    }

    /* タイマー */

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

    //タイマーリスタート
    public void restartTimer(){
        resetTimer(); // タイマーリセット
        startTimer(); // タイマースタート
    }

    // ポーズパネル表示
    public void pause () {
        stopTimer(); // タイマーを停止
        // ゲームを停止
        pauseUi.SetActive(true);
        // ポーズボタンを非表示
    }

    // リセットメソッド
    public void resetMethod () {
        resetTimer(); // タイマー
        GameObject.Find("PlayerManager").SendMessage("resetPlayerHp"); // HP
        GameObject.Find("PlayerManager").SendMessage("resetGameJudge"); // ゲーム判定
    }

    /* タイマー */

    /* UI */

    // ポーズパネル非表示
    void pauseUIFalse () {
        pauseUi.SetActive(false);
    }

    // ゲームを再開する
    public void playGame () {
        pauseUIFalse(); // ポーズパネルを非表示
        startTimer(); // タイマーをうごかす
        // ゲームを再生
        // ポーズボタンを表示
    }

    // メニューに戻る
    public void backMenuP () {
        Debug.Log("backMenuP");
        pauseUIFalse(); // ポーズパネルを非表示
        SceneManager.LoadScene("Menu");
    }

    // ゲームをやめる
    public void escapeGameP () {
        Debug.Log("escapeGameP");
        pauseUIFalse(); // ポーズパネルを非表示
        // アプリ終了
    }

    /* UI */
      
}