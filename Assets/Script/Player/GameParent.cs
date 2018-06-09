using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameParent : MonoBehaviour {

	void Awake () {
		
		// これを消滅しない
		DontDestroyOnLoad(this);

	}

	void Start () {
		
        /// PlayerPrefsに保存
		/// 「保存切り替え判定 = true」だったら
		if (StartScn.prefsSave == true) {
            /// PlayerPrefsに現在のデータを保存
            /// Username, PlayerHp, Money, Item1, Item2
			PlayerState.username = PlayerPrefs.GetString ("username"); // 使用しているユーザーネーム
			PlayerState.playerHp = PlayerPrefs.GetInt ("playerhp"); // プレイヤーHP
			MoneyManager.money = PlayerPrefs.GetInt ("money"); // 所持金
            Item1Sc.item1Owned = PlayerPrefs.GetInt("item1"); // ショップ内 プレイヤーアイテム1所持数
			ItemManager.item1 = PlayerPrefs.GetInt ("item1"); // プレイヤーアイテム1所持数          
			Item2Sc.item2Owned = PlayerPrefs.GetInt("item2"); // ショップ内 プレイヤーアイテム2の所持数         
            ItemManager.item2 = PlayerPrefs.GetInt("item2"); // プレイヤーアイテム2所持数
            Item2Sc.item2Shop = PlayerPrefs.GetInt("item2_shop"); // ショップ内アイテム2取り扱い数
		}

	}

}