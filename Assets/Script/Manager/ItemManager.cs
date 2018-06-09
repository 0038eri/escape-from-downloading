using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemManager : MonoBehaviour {

	// アイテム1所持数
	public static int item1=0;
	// アイテム2所持数
	public static int item2=0;   
    
	void Start () {
		
		/// アイテム1ショップ内所持数より
		/// 現在の所持数に代入
        item1 = Item1Sc.item1Owned;
		/// アイテム2ショップ内所持数より
		/// 現在の所持数に代入
        item2 = Item2Sc.item2Owned;

	}
    
	// アイテム1使用メソッド
	public void item1Use () {
        if (item1 >= 1) {
			item1--; // アイテム1所持数1減らす
			PlayerPrefs.SetInt("item1", item1); // PlayerPrefsにデータを保存         
			GameObject.Find("PlayerManager").SendMessage ("playerHpPlus1"); // HP1増やす
		}
	}

	// アイテム2使用メソッド
	public void item2Use () {
		if (item2 == 1) {
			item2--; // アイテム2所持数1減らす
			PlayerPrefs.SetInt ("item2", item2); // PlayerPrefsにデータを保存         
			GameObject.Find("PlayerManager").SendMessage ("playerHpPlus2"); // HP10増やす
		}else if(item2 == 0) {
			item2++; // アイテム2所持数1つ増やす
			PlayerPrefs.SetInt ("item2", item2); // PlayerPrefsにデータを保存         
			GameObject.Find("PlayerManager").SendMessage ("playerHpMinus2"); // HP10減らす
		}
	}

}