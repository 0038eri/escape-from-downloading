using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SettingScn : MonoBehaviour {

	// アイテム1所持数表示テキスト
	public Text item1Text;
	// アイテム2所持数表示テキスト
	public Text item2Text;

	void Update () {
		      
		item1Text.text = "Item1:" + ItemManager.item1; // 現在のアイテム1所持数を表示      
		item2Text.text = "Item2:" + ItemManager.item2; // 現在のアイテム2所持数を表示

		// Menuに移動
		if (Input.GetKey (KeyCode.M)) {
			SceneManager.LoadScene ("Menu");
		}

		/// アイテム1使用
		/// HP更新
		if (Input.GetKeyDown (KeyCode.Alpha1)) {
			GameObject.Find("ItemObj").SendMessage ("item1use");
            GameObject.Find("PlayerManager").SendMessage("updatePlayerHp");
		}

		/// アイテム2使用
		/// HP更新
		if (Input.GetKeyDown (KeyCode.Alpha2)) {
			GameObject.Find("ItemObj").SendMessage ("item2use");
            GameObject.Find("PlayerManager").SendMessage("updatePlayerHp");
		}

	}
		
}