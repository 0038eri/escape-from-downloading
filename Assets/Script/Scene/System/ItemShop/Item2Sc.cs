using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class Item2Sc : MonoBehaviour {

	// ショップ内アイテム2取り扱い数
    public static int item2Shop=1;

	// アイテム2所持数
	public static int item2Owned;
	// アイテム2所持数表示テキスト
	public Text item2OwnedText;  

	void Update () {
		// アイテム2所持数表示
        item2OwnedText.text = "Owned:" + item2Owned;

		// Spaceを押した時
		if (Input.GetKeyDown (KeyCode.Space)) {
			if (item2Shop == 1) {
				// アイテム2売り切れ
				item2Shop -= 1;
                // PlayerPrefsにデータを保存
                PlayerPrefs.SetInt("item2_shop", item2Shop);
				// 所持金 - 5
				MoneyManager.money -= 5;
				// 所持金を更新
				GameObject.Find("MoneyObj").SendMessage ("updateCoin");
				// アイテム2の所持数を増やす
                item2Owned += 1;
                //PlayerPrefsにデータを保存
                PlayerPrefs.SetInt("item2", item2Owned);
				//アイテムマネージャーにアイテム2の所持数を送信
                ItemManager.item2 = item2Owned;
			}
		}
	}

	//ショップに戻るメソッド
	public void backShop () {
		SceneManager.LoadScene ("Shop");
	}

}