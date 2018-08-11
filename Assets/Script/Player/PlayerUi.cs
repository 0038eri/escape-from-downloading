using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUi : MonoBehaviour {

    public GameObject playerUi;
    // クリア画面
    public GameObject gameClearUi;
    // ゲームオーバー画面
    public GameObject gameOverUi;

    public void closePlayerUi()
    {
        playerUi.SetActive(false);
        Debug.Log("いち");
    }

    public void displayClear()
    {
        gameClearUi.SetActive(true);
    }

    public void displayOver()
    {
        gameOverUi.SetActive(true);
    }

}