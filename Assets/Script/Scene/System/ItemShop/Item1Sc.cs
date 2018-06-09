using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Item1Sc : MonoBehaviour {
	
	// アイテム1購入予定総数
	public int item1Buy=0;
	// アイテム1購入予定総数表示テキスト
	public Text item1BuyText;

	// アイテム1購入予定総額
	private int item1Price=0;
	// アイテム1購入予定総額表示テキスト　
	public Text item1PriceText;

	// アイテム1所持数
	public static int item1Owned;
	// アイテム1所持数表示テキスト
	public Text item1OwnedText;
		
	void Update () {
		// アイテム1購入総数表示
		item1BuyText.text = "number:" + item1Buy;
		// アイテム1購入総額表示
		item1PriceText.text = "price:" + item1Price;
		// アイテム1所持数表示
        item1OwnedText.text = "Owned:" + item1Owned;

		// Spaceを押した時
		if (Input.GetKeyDown (KeyCode.Space)) {
			// アイテム1の購入総数 × 3 ＜ 所持金
            if (item1Buy >= 1) {
				if(item1Buy * 3 <= MoneyManager.money){
				// 所持金 - アイテム1の購入総数 × 3
                MoneyManager.money -= item1Buy * 3;
				// 所持金を更新
				GameObject.Find("MoneyObj").SendMessage ("updateCoin");
				// アイテム1購入予定総数をアイテム1所持数に増やす
                item1Owned += item1Buy;
                // PlayerPrefsにデータを保存
                PlayerPrefs.SetInt("item1", item1Owned);
				// アイテムマネージャーにアイテム1所持数を送信
                ItemManager.item1 = item1Owned;
                }
			}
		}
	}
		
    // ショップに戻る
	public void backShop () {		
		SceneManager.LoadScene ("Shop");
	}
		
    // アイテム1を増やす
	public void item1Plus() {
		// Item1 購入個数 プラス
		item1Buy++;
		// Item1 購入総額 プラス
		item1Price+=3;
	}
		
    //アイテム1減らすメソッド
	public void item1Minus() {
		// Item1 購入個数 マイナス
		item1Buy--;
		// Item1 購入総額 マイナス
		item1Price-=3;
	}

}