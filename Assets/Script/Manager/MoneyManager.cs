using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : MonoBehaviour {
	
	// 所持金
	public static int money=10;
	// 所持金表示テキスト
	public Text moneyText;

	void Start () {
		
		/// 現在の所持金を表示      
        moneyText.text = money.ToString();

	}

    // 所持金更新メソッド
	public void updateCoin(){
		/// 所持金更新時に表示しなおさせる
        moneyText.text = money.ToString();
        // PlayerPrefsにデータを保存
		PlayerPrefs.SetInt ("money", money);
	}
		
    // コインゲット
	public void getCoin () {
		money++;
	}

}