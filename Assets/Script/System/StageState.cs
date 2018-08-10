using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageState : MonoBehaviour {

    // ステージクリア判定

    // ポーズ画面
    public GameObject pauseUi;
    // ポーズボタン
    public GameObject pauseButton;

    private void Awake()
    {}

    private void Start()
    {
        //audiosources = gameObject.GetComponents<AudioSource>(); // オーディオソース取得
        Debug.Log("isPlayingNowは現在ゲームプレイ中であるかの真偽を問うbool型の判定です。");
        Debug.Log("timerStopは現在タイマーが作動中であるかを真偽するbool型の判定です。");
    }

    /* ステージナンバー */



    /* ステージナンバー */


    /* タイマー */

    // リセットメソッド
    public void resetMethod () {
        //resetTimer(); // タイマー
        GameObject.Find("PlayerManager").SendMessage("resetPlayerHp"); // HP
        GameObject.Find("PlayerManager").SendMessage("resetGameJudge"); // ゲーム判定
    }

    /* タイマー */

    /* UI */

    // ポーズパネル非表示
    void pauseUIFalse () {
        
        pauseUi.SetActive(false);
        pauseButton.SetActive(true); // ポーズボタンを表示
    }

    // ゲームを再開する
    public void playGame () {
        pauseUIFalse(); // ポーズパネルを非表示

    }

    // メニューに戻る
    public void backMenuP () {
        pauseUIFalse(); // ポーズパネルを非表示
        SceneManager.LoadScene("Menu");
    }

    // ゲームをやめる
    public void escapeGameP () {
        pauseUIFalse(); // ポーズパネルを非表示
        // アプリ終了
    }

    /* UI */
   
}