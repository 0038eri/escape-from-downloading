using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerState : MonoBehaviour {
    
    // ユーザーネーム文字列
	public static string username;
    // ユーザーネーム表示テキスト
	public Text usernameText;
	
	// プレイヤーHP
	public static int playerHp=30;
	// プレイヤーHP表示テキスト
	public Text playerHpText;

	void Start() {
        
		playerHpText.text = "HP : " + playerHp; // プレイヤーHPテキスト表示

	}

    // ユーザーネーム更新
	public void updateUsername () {
		usernameText.text = username; // 実行された時の現在のユーザーネームを表示      
		PlayerPrefs.SetString("username", username); // PlayerPrefsにデータを保存
    }
 
    // HP更新
    public void updatePlayerHp () {
		playerHpText.text = "HP : " + playerHp; // HPテキスト表示更新
		PlayerPrefs.SetInt("playerhp", playerHp); // PlayerPrefsにデータを保存
	}
	
	// アイテム1でHP増やす
	public void playerHpPlus1 () {
		playerHp++; // HPを1増やす
		updatePlayerHp ();
	}

	// アイテム2でHP増やす
	public void playerHpPlus2 () {
		playerHp += 10; // HP10を増やす
		updatePlayerHp ();
	}

	// アイテム2でHP減らす
	public void playerHpMinus2 () {
		playerHp -= 10; // HP10を減らす
		updatePlayerHp ();
	}

	// エネミーでHP減らす
	public void playerHpMinusE () {
		playerHp--; // HPを1減らす
		updatePlayerHp ();
	}

}