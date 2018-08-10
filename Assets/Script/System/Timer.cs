using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Timer : MonoBehaviour
{

    // タイマー
    private float timer;
    // タイマーセット判定
    private bool timerSet = false;
    // 制限時間
    private float timeLimit = 0.0f;
    // タイマー停止判定
    private static bool timerStop = true;
    // タイマー表示テキスト
    public Text timerText;

    private GameObject playerManager;

    void Awake()
    {
        playerManager = GameObject.Find("PlayerManager");
    }

    void Update()
    {
        /// タイマーが停止しなかったら
        /// タイマーアップデートする
        if (timerStop == false)
        {
            updateTimer();
        }
    }

    // タイマーを動かしている
    void updateTimer()
    {
        if (timerSet == false)
        {
            setupTimer();
            timerSet = true;
        }
        timer += (-1 * Time.deltaTime); // タイマーを動かす
        timerText.text = ((int)timer).ToString() + " sec"; // 時間を整数で表示する
        if (timer < timeLimit) // もしタイマーが制限時間に達したら
        {
            stopTimer();
            playerManager.SendMessage("gameOverMethod");
        }
    }

    public void startUpdateTimer()
    {
        timerStop = false;
    }

    // タイマーを開始
    public void startTimer()
    {
        timerStop = false;
        Time.timeScale = 1.0f;
    }

    // タイマーを停止
    public void stopTimer()
    {
        timerStop = true;
        Time.timeScale = 0.0f;
    }

    // タイマーセット
    public void setupTimer()
    {
        timer = 60.0f;
    }

    // タイマーリセット
    public void resetTimer()
    {
        stopTimer();
        timerSet = false;
    }

    //タイマーリスタート
    public void restartTimer()
    {
        resetTimer();
        startTimer();
    }

}