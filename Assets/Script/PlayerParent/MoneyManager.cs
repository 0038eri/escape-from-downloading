using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class MoneyManager : SingletonMonoBehaviour<MoneyManager> {

    // 所持金
    private static int money = 10;

    // コインゲット
    public void getCoin()
    {
        money++;
        PlayerUiManager.Instance.updateMoneyText();
    }

    public int sendMoney()
    {
        return money;
    }
	
}