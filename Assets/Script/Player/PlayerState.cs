using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerState : MonoBehaviour {
    
    private GameObject player;
    private GameObject hpManager;
    private GameObject gameModeManager;
    private GameMode gameMode;
    private GameObject playerUiManager;
    private GameObject timerManager;
    private GameObject stageJudgeManager;
    private StageJudge stageJudge;
    private GameObject systemUiManager;

    private string gameModeCheck;
    private int stageCheckNumber;

    void Awake()
    {
        player = GameObject.Find("Player");
        hpManager = GameObject.Find("HpManager");
        gameModeManager = GameObject.Find("GameModeManager");
        gameMode = gameModeManager.GetComponent<GameMode>();
        playerUiManager = GameObject.Find("PlayerUiManager");
        timerManager = GameObject.Find("TimerManager");
        stageJudgeManager = GameObject.Find("StageJudgeManager");
        stageJudge = stageJudgeManager.GetComponent<StageJudge>();
        systemUiManager = GameObject.Find("SystemUiManager");
    }

    // ゲーム開始前
    public void beforeGameMethod()
    {
        Debug.Log("beforeGameMethod();");
        player.SendMessage("gamePauseStop");
        hpManager.SendMessage("setupHp");
        gameModeManager.SendMessage("beforeGame");
    }

    public void isPlayingMethod()
    {
        timerManager.SendMessage("startTimer");
        player.SendMessage("gameStartRun");
        gameModeManager.SendMessage("isPlaying");
    }

    // ゲーム終了
    private void gameFinishMethod()
    {
        timerManager.SendMessage("stopTimer");
        player.SendMessage("gamePauseStop");
        stageCheckNumber = stageJudge.stageNumberCheck();
    }

    // ゲームクリア
    public void gameClearMethod()
    {
        gameFinishMethod();
        playerUiManager.SendMessage("falsePlayerUi");
        systemUiManager.SendMessage("displayClear");
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
        gameModeManager.SendMessage("gameClear");
    }

    // ゲームオーバー
    public void gameOverMethod()
    {
        gameFinishMethod();
        playerUiManager.SendMessage("falsePlayerUi");
        systemUiManager.SendMessage("displayOver");
        gameModeManager.SendMessage("gameOver");
    }

    public void nextGame()
    {
        
    }

    public void restartGame()
    {
    }

    public void backMenuP()
    {
        destroyMode();
        timerManager.SendMessage("resetTimer");
        gameModeManager.SendMessage("systemScene");
        SceneManager.LoadScene("Menu");
    }

    public void escapeGameP()
    {
        destroyMode();
        timerManager.SendMessage("resetTimer");
        gameModeManager.SendMessage("systemScene");
        SceneManager.LoadScene("Start");
    }

    void destroyMode()
    {
        gameModeCheck = gameMode.sendMode();
        if (gameModeCheck == "gameClear")
        {
            systemUiManager.SendMessage("destroyClear");
        }
        else if (gameModeCheck == "gameOver")
        {
            systemUiManager.SendMessage("destroyOver");
        }
    }

}