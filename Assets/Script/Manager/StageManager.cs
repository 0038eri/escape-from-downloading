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
    // ポーズボタン
    public GameObject pauseButton;

    // BGM 素材
    public AudioClip[] stageBgm;
    public AudioClip[] systemBgm;

    // SE 素材
    public AudioClip[] stageSe;
    public AudioClip[] systemSe;

    // AudioSources
    private AudioSource[] audiosources;

    private void Awake()
    {
        SceneManager.sceneLoaded += checkScene; // シーン移動ごとに毎回呼び出し
    }

    private void Start()
    {
        audiosources = gameObject.GetComponents<AudioSource>(); // オーディオソース取得
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
        pauseUi.SetActive(false);
        pauseButton.SetActive(true); // ポーズボタンを表示
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

    /* SOUND */

    void checkScene (Scene scene,LoadSceneMode sceneMode) {

        /// Scene scenename,LoadSceneMode SceneMode は、SceneManager.sceneLoaded の引数である
        /// Awakeでの場合は引数は省略されている

        switch (scene.name) {

            /* System */

            case "Start":
                audiosources[0].clip = systemBgm[0]; // StartのBGMにする
                playBgm();
                break;

            case "Opening":
                audiosources[0].clip = systemBgm[1]; // OpeningのBGMにする
                playBgm();
                break;

            case "Menu":
                audiosources[0].clip = systemBgm[2]; // MenuのBGMにする
                playBgm();
                break;

            case "Option":
                audiosources[0].clip = systemBgm[3]; // OptionのBGMにする
                playBgm();
                break;

            case "Ending":
                audiosources[0].clip = systemBgm[4]; // EndingのBGMにする
                playBgm();
                break;

            /* System */

            /* Stage */



            /* Stage */

            default:
                StopBgm();
                break;
        }
    }


    // BGMを再生する
    void playBgm () {
        audiosources[0].Play();
    } 

    // BGMを停止する
    void StopBgm () {
        audiosources[0].Stop();
    }

    /* SOUND */
      
}