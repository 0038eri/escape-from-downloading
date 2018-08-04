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
    string gameJudge = "none";

    // クリア画面
    public GameObject gameClearUi;
    // ゲームオーバー画面
    public GameObject gameOverUi;

	void Start() {
        
        slider.value = playerHp; // HP反映
        hpImage = GameObject.Find("Fill").GetComponent<Image>(); // カラー取得
        playerHpText.text = playerHp.ToString(); // プレイヤーHPテキスト表示

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
                if (Stage1Scn.stage1Clear == false) // ステージ1をクリアしていなかったら
                {
                    StageManager.stageNumber++; // クリアステージ数追加
                    Stage1Scn.stage1Clear = true; // ステージ1クリア済み
                }
                break;

            case 2:
                if (Stage2Scn.stage2Clear == false) // ステージ2をクリアしていなかったら
                {
                    StageManager.stageNumber++; // クリアステージ数追加
                    Stage2Scn.stage2Clear = true; // ステージ2クリア済み
                }
                break;

            case 3:
                if (Stage3Scn.stage3Clear == false) // ステージ3をクリアしていなかったら
                {
                    StageManager.stageNumber++; // クリアステージ数追加
                    Stage3Scn.stage3Clear = true; // ステージ3クリア済み
                }
                break;

            case 4:
                if (Stage4Scn.stage4Clear == false) // ステージ4をクリアしていなかったら
                {
                    StageManager.stageNumber++; // クリアステージ数追加
                    Stage4Scn.stage4Clear = true; // ステージ4クリア済み
                }
                break;

            case 5:
                if (Stage5Scn.stage5Clear == false) // ステージ5をクリアしていなかったら
                {
                    StageManager.stageNumber++; // クリアステージ数追加
                    Stage5Scn.stage5Clear = true; // ステージ5クリア済み
                }
                break;

            case 6:
                if (Stage6Scn.stage6Clear == false) // ステージ6をクリアしていなかったら
                {
                    StageManager.stageNumber++; // クリアステージ数追加
                    Stage6Scn.stage6Clear = true; // ステージ6クリア済み
                }
                break;

            case 7:
                if (Stage7Scn.stage7Clear == false) // ステージ7をクリアしていなかったら
                {
                    StageManager.stageNumber++; // クリアステージ数追加
                    Stage7Scn.stage7Clear = true; // ステージ7クリア済み
                }
                break;

            case 8:
                if (Stage8Scn.stage8Clear == false) // ステージ8をクリアしていなかったら
                {
                    StageManager.stageNumber++; // クリアステージ数追加
                    Stage8Scn.stage8Clear = true; // ステージ8クリア済み
                }
                break;

            case 9:
                if (Stage9Scn.stage9Clear == false) // ステージ9をクリアしていなかったら
                {
                    StageManager.stageNumber++; // クリアステージ数追加
                    Stage9Scn.stage9Clear = true; // ステージ9クリア済み
                }
                break;

            case 10:
                if (Stage10Scn.stage10Clear == false) // ステージ10をクリアしていなかったら
                {
                    StageManager.stageNumber++; // クリアステージ数追加
                    Stage10Scn.stage10Clear = true; // ステージ10クリア済み
                }
                break;

            case 11:
                if (Stage11Scn.stage11Clear == false) // ステージ11をクリアしていなかったら
                {
                    StageManager.stageNumber++; // クリアステージ数追加
                    Stage11Scn.stage11Clear = true; // ステージ11クリア済み
                }
                break;

            case 12:
                if (Stage12Scn.stage12Clear == false) // ステージ12をクリアしていなかったら
                {
                    StageManager.stageNumber++; // クリアステージ数追加
                    Stage12Scn.stage12Clear = true; // ステージ12クリア済み
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