using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

    // ゲームスタート Canvas
    private Animator gameStartAnimator;
    // 
    private StageManager stageManager;
    //
    public int gameStartCount;

    private void Awake()
    {
        gameStartAnimator = GameObject.Find("GameStart").GetComponent<Animator>();
    }

    public void StartGameMethod()
    {
        gameStartCount = stageManager.startTimerCountMethod();
        if (gameStartCount >= 1)
        {
            readyToOnemoreGame();
        }
        GameObject.Find("StageManager").SendMessage("startTimer"); // タイマー開始
        GameObject.Find("Player").SendMessage("goRunning"); 
        GameObject.Find("Player").SendMessage("canInput"); // 入力可能にする
    }

    public void readyToOnemoreGame()
    {
        Debug.Log("gameStartCount:" + gameStartCount);
        gameStartAnimator.enabled = false;
    }

}