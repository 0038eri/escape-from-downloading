using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AnimationManager : MonoBehaviour {

    // ゲームスタート Canvas
    private Canvas gameStartCanvas;

    void 

    public void getGameStartCanvas()
    {
        gameStartCanvas = GameObject.Find("GameStartCanvas").GetComponent<Canvas>();
    }

    public void StartGameMethod()
    {
        Debug.Log("StartGameMethod");
        //gameStartCanvas.enabled = true; // UI表示
        GameObject.Find("StageManager").SendMessage("startTimer"); // タイマー開始
        GameObject.Find("Player").SendMessage("canInput"); // 入力可能にする
    }

}