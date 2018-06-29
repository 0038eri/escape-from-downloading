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
		
        moneyText.text = money.ToString(); // 現在の所持金を表示

	}

    // コインゲット
    public void getCoin()
    {
        money++;
        updateMoney(); // 所持金更新
    }

    // 所持金更新メソッド
    public void updateMoney()
    {
        moneyText.text = money.ToString(); // 所持金更新時に表示しなおさせる
    }
		
}