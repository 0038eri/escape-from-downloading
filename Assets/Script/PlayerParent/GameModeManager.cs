using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeManager : SingletonMonoBehaviour<GameModeManager> {

    // ゲーム判定
    private string gameMode;

    public string sendMode()
    {
        return gameMode;
    }

    public void beforeGame()
    {
        gameMode = "beforeGame";
    }

    public void isPlaying()
    {
        gameMode = "isPlaying";
    }

    public void gameClear()
    {
        gameMode = "gameClear";
    }

    public void gameOver()
    {
        gameMode = "gameOver";
    }

    public void systemScene()
    {
        gameMode = "systemScene";
    }

}