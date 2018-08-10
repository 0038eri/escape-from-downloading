using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUi : MonoBehaviour {

    // クリア画面
    public GameObject gameClearUi;
    // ゲームオーバー画面
    public GameObject gameOverUi;

    public void displayClear()
    {
        gameClearUi.SetActive(true);
    }

    public void displayOver()
    {
        gameOverUi.SetActive(true);
    }

}