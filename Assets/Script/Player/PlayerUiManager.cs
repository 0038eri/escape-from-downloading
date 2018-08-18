using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerUiManager : SingletonMonoBehaviour<PlayerUiManager> {

    private GameObject playerCanvas;
    private Canvas playerUiCanvas;

    private void Awake()
    {
        playerCanvas = GameObject.Find("PlayerCanvas");
        playerUiCanvas = playerCanvas.GetComponent<Canvas>();
    }

    public void truePlayerUi()
    {
        playerUiCanvas.enabled = true;
    }

    public void falsePlayerUi()
    {
        playerUiCanvas.enabled = false;
    }

}