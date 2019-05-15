using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameModeManager : SingletonMonoBehaviour<GameModeManager>
{

  // ゲーム判定
  private string gameMode;
  private bool playFlag;

  void Update()
  {
    Debug.Log("現在のモードは、" + gameMode + "です");
    if (playFlag)
    {
      Debug.Log("ゲームは遊ばれています");
    }
    else
    {
      Debug.Log("ゲームは遊ばれていません");
    }
  }

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

  public void stopPlaying()
  {
    gameMode = "stopPlaying";
    playFlag = false;
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

  public void talkScene()
  {
    gameMode = "talkScene";
    playFlag = false;
  }

  public void selectScene()
  {
    gameMode = "selectScene";
    playFlag = false;
  }

}