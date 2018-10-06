using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUiManager : SingletonMonoBehaviour<PlayerUiManager> {

    private GameObject playerCanvas;
    private int moneyForTtext;
    private Text moneyText;
    private Button pauseButton;

    private void Start()
    {
        playerCanvas = GameObject.Find("PlayerCanvas");
        moneyForTtext = MoneyManager.Instance.sendMoney(); 
        moneyText = GameObject.Find("Money").GetComponent<Text>();
        moneyText.text = moneyForTtext.ToString();
        pauseButton = GameObject.Find("PauseButton").GetComponent<Button>();
        pauseButton.onClick.AddListener(doPause);
    }

    public void truePlayerUi()
    {
        playerCanvas.SetActive(true);
    }

    public void falsePlayerUi()
    {
        playerCanvas.SetActive(false);
        Debug.Log("じっこうされるよん");
    }

    public void doPause()
    {
        StageStateManager.Instance.pauseMethod();
    }

    public void updateMoneyText()
    {
        moneyForTtext = MoneyManager.Instance.sendMoney();
        moneyText.text = moneyForTtext.ToString();
    }

}