using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : SingletonMonoBehaviour<MoneyManager> {

    // 所持金
    private static int money = 10;

    private void Start()
    {
        //money = PlayerPrefs.GetInt("moneySave");
    }

    // コインゲット
    public void getCoin()
    {
        money++;
        PlayerUiManager.Instance.updateMoneyText();
        PlayerPrefs.SetInt("moneySave", money);
    }

    public int sendMoney()
    {
        return money;
    }
	
}