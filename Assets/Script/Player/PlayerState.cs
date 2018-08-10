using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerState : MonoBehaviour {
    
    private GameObject player;
    private GameObject hpManager;
    private GameObject gameModeManager;
    private GameObject playerUiManager;

    void Awake()
    {
        player = GameObject.Find("Player");
        hpManager = GameObject.Find("HpManager");
        gameModeManager = GameObject.Find("GameModeManager");
        playerUiManager = GameObject.Find("PlayerUiManager");
    }

    // ゲーム開始前
    public void beforeGameMethod()
    {
        player.SendMessage("cannotInput");
        player.SendMessage("stopRunning");
        hpManager.SendMessage("setupHp");
        gameModeManager.SendMessage("beforeGame");
    }

    public void isPlayingMethod()
    {
        gameModeManager.SendMessage("isPlaying");
    }

    // ゲーム終了
    private void gameFinishMethod()
    {
        player.SendMessage("cannotInput");
        player.SendMessage("stopRunning");
    }

    // ゲームクリア
    public void gameClearMethod()
    {
        gameFinishMethod();
        gameModeManager.SendMessage("gameClear");
        playerUiManager.SendMessage("displayClear");
    }

    // ゲームオーバー
    public void gameOverMethod()
    {
        gameFinishMethod();
        gameModeManager.SendMessage("gameOver");
        playerUiManager.SendMessage("displayOver");
    }

}