using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMode : MonoBehaviour {

    // ゲーム判定
    private string gameMode;

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

}