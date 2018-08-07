using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerState : MonoBehaviour {

    // プレイヤーHP
    public static int playerHp = 100;
    // プレイヤーHP表示テキスト
    public Text playerHpText;
    // HPバー
    public Slider slider;
    // HPバー背景画像
    public Image hpImage;

    // ユーザーネーム文字列
    public static string username;
    // ユーザーネーム表示テキスト
    public Text usernameText;

    // ゲーム判定
    private string gameJudge = "none";
    private GameObject stagemanager;
    private GameObject stageScn;
    private Stage1Scn stage1scn;
    private Stage2Scn stage2scn;
    private Stage3Scn stage3scn;
    private Stage4Scn stage4scn;
    private Stage5Scn stage5scn;
    private Stage6Scn stage6scn;
    private Stage7Scn stage7scn;
    private Stage8Scn stage8scn;
    private Stage9Scn stage9scn;
    private Stage10Scn stage10scn;
    private Stage11Scn stage11scn;
    private Stage12Scn stage12scn;

    // クリア画面
    public GameObject gameClearUi;
    // ゲームオーバー画面
    public GameObject gameOverUi;

    void Start() {
        
        slider.value = playerHp; // HP反映
        hpImage = GameObject.Find("Fill").GetComponent<Image>(); // カラー取得
        playerHpText.text = playerHp.ToString(); // プレイヤーHPテキスト表示
        stagemanager = GameObject.Find("StageManager");

    }

    /* HP */

    // HPリセット
    public void resetPlayerHp(){
        playerHp = 100;
    }
 
    // HP更新
    public void updatePlayerHp () {
        slider.value = playerHp; // HP値反映更新
        playerHpText.text = playerHp.ToString(); // HPテキスト表示更新

        /// HPが10以下だったら
        /// HPバーの色を赤にする
        if (playerHp <= 10)
        {
            playerHpBarColorRed();

        }

        /// HPが30以下だったら
        /// HPバーの色を黄色にする
        else if (playerHp <= 30)
        {
            playerHpBarColorYellow();
        }

        /// HPが60以下だったら
        /// HPバーの色を緑にする
        else if (playerHp <= 60)
        {
            playerHpBarColorGreen();
        }

        /// HPが100以下だったら
        /// HPバーの色を青にする
        else if (playerHp <= 100)
        {
            playerHpBarColorBlue();
        }
    }

    // HPバーの色を青にする
    void playerHpBarColorBlue()
    {
        hpImage.color = Color.blue;
    }

    // HPバーの色を緑にする
    void playerHpBarColorGreen()
    {
        hpImage.color = Color.green;
    }

    // HPバーの色を黄色にする
    void playerHpBarColorYellow()
    {
        hpImage.color = new Color(255.0f / 255.0f, 255.0f / 255.0f, 0.0f / 255.0f, 255.0f / 255.0f); // 黄色
    }

    // HPバーの色を赤色にする
    void playerHpBarColorRed()
    {
        hpImage.color = Color.red;
    }

    /* HP */

    /* ユーザーネーム */

    // ユーザーネーム更新
    public void updateUsername()
    {
        usernameText.text = username; // 実行された時の現在のユーザーネームを表示      
    }

    /* ユーザーネーム */

    /* ゲームクリア・ゲームオーバー判定 */

    // ゲームクリア
    public void gameClear()
    {
        GameObject.Find("StageManager").SendMessage("resetTimer"); // タイマーリセット
        gameClearUi.SetActive(true); // ゲームクリアパネル表示
        stageClearCheck(); // クリア判定確認
        gameJudge = "clear"; // ゲームクリア判定送信
    }

    // ゲームオーバー
    public void gameOver(){
        GameObject.Find("StageManager").SendMessage("resetTimer"); // タイマーリセット
        gameOverUi.SetActive(true); // ゲームオーバーパネル表示
        gameJudge = "over"; // ゲームオーバー判定送信
    }

    // ゲーム判定リセット
    public void resetGameJudge()
    {
        gameJudge = "none";
    }

    // クリア判定確認
    void stageClearCheck(){
        switch (StageManager.stageNumber)
        {

            case 1:
                int stageOne = stage1scn.stage1Check();
                stageScn = GameObject.Find("Stage1Obj");
                if (stageOne==0) // ステージ1をクリアしていなかったら
                {
                    stagemanager.SendMessage("stageNumberCount");
                    stageScn.SendMessage("stage1Count"); // ステージ1クリア済み
                }
                break;

            case 2:
                int stageTwo = stage2scn.stage2Check();
                stageScn = GameObject.Find("Stage2Obj");
                if (stageTwo==0) // ステージ2をクリアしていなかったら
                {
                    stagemanager.SendMessage("stageNumberCount");
                    stageScn.SendMessage("stage2Count"); // ステージ2クリア済み
                }
                break;

            case 3:
                int stageThree = stage3scn.stage3Check();
                stageScn = GameObject.Find("Stage3Obj");
                if (Stage3Scn.stage3Clear == 0) // ステージ3をクリアしていなかったら
                {
                    stagemanager.SendMessage("stageNumberCount");
                    stageScn.SendMessage("stage3Count"); // ステージ3クリア済み
                }
                break;

            case 4:
                int stageFour = stage4scn.stage4Check();
                stageScn = GameObject.Find("Stage4Obj");
                if (Stage4Scn.stage4Clear == 0) // ステージ4をクリアしていなかったら
                {
                    stagemanager.SendMessage("stageNumberCount");
                    stageScn.SendMessage("stage4Count"); // ステージ4クリア済み
                }
                break;

            case 5:
                int stageFive = stage5scn.stage5Check();
                stageScn = GameObject.Find("Stage5Obj");
                if (Stage5Scn.stage5Clear == 0) // ステージ5をクリアしていなかったら
                {
                    stagemanager.SendMessage("stageNumberCount");
                    stageScn.SendMessage("stage5Count"); // ステージ5クリア済み
                }
                break;

            case 6:
                int stageSix = stage6scn.stage6Check();
                stageScn = GameObject.Find("Stage6Obj");
                if (Stage6Scn.stage6Clear == 0) // ステージ6をクリアしていなかったら
                {
                    stagemanager.SendMessage("stageNumberCount");
                    stageScn.SendMessage("stage6Count"); // ステージ6クリア済み
                }
                break;

            case 7:
                int stageSeven = stage7scn.stage7Check();
                stageScn = GameObject.Find("Stage7Obj");
                if (Stage7Scn.stage7Clear == 0) // ステージ7をクリアしていなかったら
                {
                    stagemanager.SendMessage("stageNumberCount");
                    stageScn.SendMessage("stage7Count"); // ステージ7クリア済み
                }
                break;

            case 8:
                int stageEight = stage8scn.stage8Check();
                stageScn = GameObject.Find("Stage8Obj");
                if (Stage8Scn.stage8Clear == 0) // ステージ8をクリアしていなかったら
                {
                    stagemanager.SendMessage("stageNumberCount");
                    stageScn.SendMessage("stage8Count"); // ステージ8クリア済み
                }
                break;

            case 9:
                int stageNine = stage9scn.stage9Check();
                stageScn = GameObject.Find("Stage9Obj");
                if (Stage9Scn.stage9Clear == 0) // ステージ9をクリアしていなかったら
                {
                    stagemanager.SendMessage("stageNumberCount");
                    stageScn.SendMessage("stage9Count"); // ステージ9クリア済み
                }
                break;

            case 10:
                int stageTen = stage10scn.stage10Check();
                stageScn = GameObject.Find("stage10Obj");
                if (Stage10Scn.stage10Clear == 0) // ステージ10をクリアしていなかったら
                {
                    stagemanager.SendMessage("stageNumberCount");
                    stageScn.SendMessage("stage10Count"); // ステージ10クリア済み
                }
                break;

            case 11:
                int stageEleven = stage11scn.stage11Check();
                stageScn = GameObject.Find("stage11Obj");
                if (Stage11Scn.stage11Clear == 0) // ステージ11をクリアしていなかったら
                {
                    stagemanager.SendMessage("stageNumberCount");
                    stageScn.SendMessage("stage11Scn"); // ステージ11クリア済み
                }
                break;

            case 12:
                int stageTwelve = stage12scn.stage12Check();
                stageScn = GameObject.Find("stage12Obj");
                if (Stage12Scn.stage12Clear == 0) // ステージ12をクリアしていなかったら
                {
                    stagemanager.SendMessage("stageNumberCount");
                    stageScn.SendMessage("stage12Count"); // ステージ12クリア済み
                }
                break;

            default:
                break;

        }
    }

    /* ゲームクリア・ゲームオーバー判定 */

    /* UI */

    // ゲームオーバー・ゲームクリアパネル非表示
    void gameUiFalse () {
        switch(gameJudge){
            
            /// ゲームクリアだったら
            /// クリアUI非表示
            case "clear":
                gameClearUi.SetActive(false);
                break;

            /// ゲームオーバーだったら
            /// オーバーUI非表示
            case "over":
                gameOverUi.SetActive(false);
                break;

            default:
                break;

        }
    }

    // 次のゲームに進む
    public void nextGame () {
        gameUiFalse(); // ゲームUI非表示
        // 次のゲームシーンに移動する
    }

    // もう一度遊ぶ
    public void onemoreGame () {
        Debug.Log("onemoreGame");
        gameUiFalse(); // ゲームUI非表示
        Scene nowScene = SceneManager.GetActiveScene(); // 現在のシーン名を取得
        SceneManager.LoadScene(nowScene.name); // シーンの再読み込み
        GameObject.Find("StageManager").SendMessage("restartMethod");
        GameObject.Find("StageManager").SendMessage("restartTimer");
    }

    // メニューに戻る
    public void backMenuG () {
        gameUiFalse(); // ゲームUI非表示
        SceneManager.LoadScene("Menu");
    }

    //ゲームをやめる
    public void escapeGameG () {
        gameUiFalse(); // ゲームUI非表示
        // アプリ終了
    }

    /* UI */
    
}