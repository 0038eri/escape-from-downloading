using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStateManager : SingletonMonoBehaviour<PlayerStateManager> {

    private string gameModeCheck;
    private int stageCheckNumber;

    // ゲーム開始前
    public void beforeGameMethod()
    {
        PlayerOperation.Instance.playerStartPos();
        //GameStartAnimator.Instance.startGameAnimation();
        HpManager.Instance.setupHp();
        GameModeManager.Instance.beforeGame();
        PlayerOperation.Instance.gamePauseStop();
    }

    public void isPlayingMethod()
    {
        TimerManager.Instance.startTimer();
        PlayerOperation.Instance.gameStartRun();
        GameModeManager.Instance.isPlaying();
    }

    // ゲーム終了
    private void gameFinishMethod()
    {
        Debug.Log("gameFinishMethodが呼び出された");
        TimerManager.Instance.stopTimer();
        //PlayerUiManager.Instance.falsePlayerUi();
        GameStartAnimator.Instance.finishedGame();
        PlayerOperation.Instance.gamePauseStop();
        stageCheckNumber = StageJudgeManager.Instance.stageNumberCheck();
    }

    // ゲームクリア
    public void gameClearMethod()
    {
        Debug.Log("gameClearMethodが呼び出されたよ");
        gameFinishMethod();
        SystemUiManager.Instance.displayClear();
        switch (stageCheckNumber)
        {
            case 0:
                Debug.Log("エラー");
                break;
            case 1:
                GameObject.Find("Stage1Obj").SendMessage("clearOne");
                break;
            case 2:
                GameObject.Find("Stage2Obj").SendMessage("clearTwo");
                break;
            case 3:
                GameObject.Find("Stage3Obj").SendMessage("clearThree");
                break;
            case 4:
                GameObject.Find("Stage4Obj").SendMessage("clearFour");
                break;
            case 5:
                GameObject.Find("Stage5Obj").SendMessage("clearFive");
                break;
            case 6:
                GameObject.Find("Stage6Obj").SendMessage("clearSix");
                break;
            case 7:
                GameObject.Find("Stage7Obj").SendMessage("clearSeven");
                break;
            case 8:
                GameObject.Find("Stage8Obj").SendMessage("clearEight");
                break;
            case 9:
                GameObject.Find("Stage9Obj").SendMessage("clearSeven");
                break;
            case 10:
                GameObject.Find("Stage10Obj").SendMessage("clearTen");
                break;
            case 11:
                GameObject.Find("Stage11Obj").SendMessage("clearEleven");
                break;
            case 12:
                GameObject.Find("Stage12Obj").SendMessage("clearTwelve");
                break;
            default:
                break;
        }
        GameModeManager.Instance.gameClear();
    }

    // ゲームオーバー
    public void gameOverMethod()
    {
        gameFinishMethod();
        SystemUiManager.Instance.displayOver();
        GameModeManager.Instance.gameOver();
    }

    public void nextGame()
    {
        destroyMode();
        StageJudgeManager.Instance.sceneTransition();
    }

    public void restartGame()
    {
        destroyMode();

    }

    public void backMenuP()
    {
        destroyMode();
        TimerManager.Instance.resetTimer();
        GameModeManager.Instance.systemScene();
        SceneManager.LoadScene("Menu");
    }

    public void escapeGameP()
    {
        destroyMode();
        TimerManager.Instance.resetTimer();
        GameModeManager.Instance.systemScene();
        SceneManager.LoadScene("Start");
    }

    void destroyMode()
    {
        gameModeCheck = GameModeManager.Instance.sendMode();
        if (gameModeCheck == "gameClear")
        {
            SystemUiManager.Instance.destroyClear();
        }
        else if (gameModeCheck == "gameOver")
        {
            SystemUiManager.Instance.destroyOver();
        }
    }

}