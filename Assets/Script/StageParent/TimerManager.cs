using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TimerManager : SingletonMonoBehaviour<TimerManager>
{

    // タイマー
    private float timer;
    // タイマーセット判定
    private bool timerSet = false;
    // 制限時間
    private float timeLimit = 1.0f;
    // タイマー停止判定
    private static bool timerStop = true;
    // タイマー表示テキスト
    private Text timerText;

    private void Start()
    {
        timerText = GameObject.Find("Timer").GetComponent<Text>();
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
        //Debug.Log((int)timer);
        if (timer < timeLimit) // もしタイマーが制限時間に達したら
        {
            stopTimer();
            PlayerStateManager.Instance.gameOverMethod();
        }
    }

    // タイマーを開始
    public void startTimer()
    {
        timerStop = false;
    }

    // タイマーを停止
    public void stopTimer()
    {
        timerStop = true;
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