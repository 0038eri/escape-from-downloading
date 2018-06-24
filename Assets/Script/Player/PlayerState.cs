using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerState : MonoBehaviour {

    // プレイヤーHP
    public static int playerHp = 60;
    // プレイヤーHP表示テキスト
    public Text playerHpText;
    // HPバー
    public Slider slider;
    // HPバー背景画像
    public Image hpImage;

 //   // ユーザーネーム文字列
	//public static string username;
 //   // ユーザーネーム表示テキスト
	//public Text usernameText;

    // クリア画面
    public GameObject gameClearUi;
    // ゲームオーバー画面
    public GameObject gameOverUi;

	void Start() {
        
        slider.value = playerHp; // HP反映
        hpImage = GameObject.Find("Fill").GetComponent<Image>(); // カラー取得

        playerHpText.text = playerHp.ToString(); // プレイヤーHPテキスト表示

	}
 
    // HP更新
    public void updatePlayerHp () {
        slider.value = playerHp; // HP反映更新
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

		PlayerPrefs.SetInt("playerhp", playerHp); // PlayerPrefsにデータを保存
	}

    // エネミーでHP減らす
    public void playerHpMinusE()
    {
        playerHp--; // HPを1減らす
        updatePlayerHp();
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

    //// ユーザーネーム更新
    //public void updateUsername()
    //{
    //    usernameText.text = username; // 実行された時の現在のユーザーネームを表示      
    //    PlayerPrefs.SetString("username", username); // PlayerPrefsにデータを保存
    //}

    // ゲームオーバー
    public void gameOver(){
        gameOverUi.SetActive(true); // ゲームオーバーパネル表示
    }

    // ゲームクリア
    public void gameClear(){
        gameClearUi.SetActive(true); // ゲームクリアパネル表示
    }

    // ゲームオーバー・ゲームクリアパネル非表示
    void gameUiFalse () {
        gameOverUi.SetActive(false);
        gameClearUi.SetActive(false);
    }

    // 次のゲームに進む
    public void nextGame () {
        gameUiFalse(); // ゲームUI非表示
        // 次のゲームシーンに移動する
    }

    // もう一度遊ぶ
    public void onemoreGame () {
        gameUiFalse(); // ゲームUI非表示
        // 今のゲームシーンをリロード
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
	
}