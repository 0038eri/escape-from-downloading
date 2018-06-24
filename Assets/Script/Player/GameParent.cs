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
			//PlayerState.username = PlayerPrefs.GetString ("username"); // 使用しているユーザーネーム
			PlayerState.playerHp = PlayerPrefs.GetInt ("playerhp"); // プレイヤーHP
			MoneyManager.money = PlayerPrefs.GetInt ("money"); // 所持金
		}

	}

}