using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeManager : SingletonMonoBehaviour<GameModeManager> {

    // ゲーム判定
    private string gameMode;
    private bool playFlag;

    public string sendMode()
    {
        return gameMode;
    }

    public bool sendFlag()
    {
        return playFlag;
    }

    public void beforeGame()
    {
        gameMode = "beforeGame";
        playFlag = false;
    }

    public void isPlaying()
    {
        gameMode = "isPlaying";
        playFlag = true;
    }

    public void gameClear()
    {
        gameMode = "gameClear";
        playFlag = false;
    }

    public void gameOver()
    {
        gameMode = "gameOver";
        playFlag = false;
    }

    public void systemScene()
    {
        gameMode = "systemScene";
        playFlag = false;
    }

}