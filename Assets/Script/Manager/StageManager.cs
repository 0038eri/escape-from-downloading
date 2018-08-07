using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StageManager : MonoBehaviour {

    // ステージクリア判定
    public static int stageNumber = 0;
    // プレイ中判定
    private bool isPlayingNow = false;

    // タイマー
    private float timer;
    private float timerValue;
    private bool timerSet = false;
    // 制限時間
    private float timeLimit = 0.0f;
    // タイマー停止判定
    public static bool timerStop = true;
    // タイマー表示テキスト
    public Text timerText;
    // スタートタイマー実行カウント
    public int startTimerCount = 0;

    // ポーズ画面
    public GameObject pauseUi;
    // ポーズボタン
    public GameObject pauseButton;

    //// BGM 素材
    //public AudioClip[] stageBgm;
    //public AudioClip[] systemBgm;

    //// SE 素材
    //public AudioClip[] stageSe;
    //public AudioClip[] systemSe;

    //// AudioSources
    //private AudioSource[] audiosources;

    private void Awake()
    {
        SceneManager.sceneLoaded += checkScene; // シーン移動ごとに毎回呼び出し
    }

    private void Start()
    {
        //audiosources = gameObject.GetComponents<AudioSource>(); // オーディオソース取得
        Debug.Log("isPlayingNowは現在ゲームプレイ中であるかの真偽を問うbool型の判定です。");
        Debug.Log("timerStopは現在タイマーが作動中であるかを真偽するbool型の判定です。");
    }

    void Update () {

        /// タイマーが停止しなかったら
        /// タイマーアップデートする
        if(timerStop==false){
            updateTimer(); 
        }

        Debug.Log("IsPlayingNow == " + isPlayingNow);
        Debug.Log("timerStop == " + timerStop);

    }

    /* ステージナンバー */

    public int stageNumberCheck()
    {
        Debug.Log(stageNumber);
        return stageNumber;
    }

    public void stageNumberCount()
    {
        if(stageNumber < 13)
        {
            stageNumber++;
        }
    }

    /* ステージナンバー */


    /* タイマー */

    // タイマーを動かしている
    void updateTimer()
    {
        if(timerSet==false)
        {
            timer = 60.0f;
            timerSet = true;
        }
        timer += (-1*Time.deltaTime); // タイマーを動かす
        timerText.text = ((int)timer).ToString() + " sec"; // 時間を整数で表示する
        if (timer < timeLimit) // もしタイマーが制限時間に達したら
        {
            GameObject.Find("PlayerManager").SendMessage("gameOver"); // ゲームオーバー
        }
        if(isPlayingNow==false)
        {
            isPlaying();
        }
    }

    // タイマーを開始
    public void startTimer () {
        startTimerCount++;
        timerStop = false;
        Time.timeScale = 1.0f;
    }

    // スタートタイマーカウント送信
    public int startTimerCountMethod()
    {
        return startTimerCount;
    }

    // タイマーを停止
    public void stopTimer () {
        timerStop = true;
        if(isPlayingNow==true)
        {
            Time.timeScale = 0.0f;
        }
    }

    // タイマーリセット
    public void resetTimer () {
        stopTimer();
        timerSet = false;
        notPlaying();
    }

    //タイマーリスタート
    public void restartTimer(){
        resetTimer(); // タイマーリセット
        startTimer(); // タイマースタート
    }

    // プレイ中判定
    public void isPlaying()
    {
        isPlayingNow = true;
    }

    // プレイ外判定
    public void notPlaying()
    {
        isPlayingNow = false;
    }

    // ポーズパネル表示
    public void pause () {
        timerValue = timer;
        stopTimer(); // タイマーを停止
        pauseUi.SetActive(true);
        pauseButton.SetActive(false); // ポーズボタンを非表示
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
        timer = timerValue;
        pauseUi.SetActive(false);
        pauseButton.SetActive(true); // ポーズボタンを表示
    }

    // ゲームを再開する
    public void playGame () {
        pauseUIFalse(); // ポーズパネルを非表示
        restartTimer();
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

    /* SOUND */

    private void checkScene (Scene scene,LoadSceneMode sceneMode) {

        /// Scene scenename,LoadSceneMode SceneMode は、SceneManager.sceneLoaded の引数である
        /// Awakeでの場合は引数は省略されている

        //switch (scene.name) {

            /* System */

            //case "Start":
            //    audiosources[0].clip = systemBgm[0]; // StartのBGMにする
            //    playBgm();
            //    break;

            //case "Opening":
            //    audiosources[0].clip = systemBgm[1]; // OpeningのBGMにする
            //    playBgm();
            //    break;

            //case "Menu":
            //    audiosources[0].clip = systemBgm[2]; // MenuのBGMにする
            //    playBgm();
            //    break;

            //case "Option":
            //    audiosources[0].clip = systemBgm[3]; // OptionのBGMにする
            //    playBgm();
            //    break;

            //case "Ending":
                //audiosources[0].clip = systemBgm[4]; // EndingのBGMにする
                //playBgm();
                //break;

            /* System */

            /* Stage */



            /* Stage */

            //default:
                //StopBgm();
                //break;
        //}
    }


    // BGMを再生する
    //void playBgm () {
    //    audiosources[0].Play();
    //} 

    //// BGMを停止する
    //void StopBgm () {
    //    audiosources[0].Stop();
    //}

    /* SOUND */
      
}