using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUiManager : SingletonMonoBehaviour<PlayerUiManager> {

    public CanvasGroup playerCanvasGroup;
    private int moneyForTtext;
    private Text moneyText;
    private Button pauseButton;

    private void Awake()
    {
        playerCanvasGroup = GameObject.Find("PlayerCanvas").GetComponent<CanvasGroup>();
        moneyText = GameObject.Find("Money").GetComponent<Text>();
        pauseButton = GameObject.Find("PauseButton").GetComponent<Button>();
    }

    public void Update()
    {
        //Debug.Log(playerCanvasGroup.alpha);
    }

    private void Start()
    {
        moneyForTtext = MoneyManager.Instance.sendMoney(); 
        moneyText.text = moneyForTtext.ToString();
        pauseButton.onClick.AddListener(pauseEvent);
    }

    public void truePlayerUi()
    {
        playerCanvasGroup.alpha = 1.0f;
        playerCanvasGroup.interactable = true;
    }

    public void falsePlayerUi()
    {
        
        playerCanvasGroup.alpha = 0.0f;

        playerCanvasGroup.interactable = false;
    }

    void pauseEvent()
    {
        SystemUiManager.Instance.openPauseUi();
    }

    public void updateMoneyText()
    {
        moneyForTtext = MoneyManager.Instance.sendMoney();
        moneyText.text = moneyForTtext.ToString();
    }

}