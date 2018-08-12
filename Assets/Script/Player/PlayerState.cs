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
        player.SendMessage("cannotInput");
        player.SendMessage("stopRunning");
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
        player.SendMessage("cannotInput");
        player.SendMessage("stopRunning");
    }

    // ゲームクリア
    public void gameClearMethod()
    {
        gameFinishMethod();
        stageJudgeManager.SendMessage("checkNowClearStage");
        systemUiManager.SendMessage("displayClear");
        gameModeManager.SendMessage("gameClear");
    }

    // ゲームオーバー
    public void gameOverMethod()
    {
        gameFinishMethod();
        systemUiManager.SendMessage("displayOver");
        gameModeManager.SendMessage("gameOver");
    }

    public void nextGame()
    {
        stageCheckNumber = stageJudge.stageNumberCheck();
        switch (stageCheckNumber)
        {
            case 0:
                SceneManager.LoadScene("Opening"); // オープニング
                stageJudgeManager.SendMessage("stageJudgeCount");
                break;
            case 1:
                SceneManager.LoadScene("Stage1"); // ステージ1
                break;
            case 2:
                SceneManager.LoadScene("Stage2"); // ステージ2
                break;
            case 3:
                SceneManager.LoadScene("Stage3"); // ステージ3
                break;
            case 4:
                SceneManager.LoadScene("Stage4"); // ステージ4
                break;
            case 5:
                SceneManager.LoadScene("Stage5"); // ステージ5
                break;
            case 6:
                SceneManager.LoadScene("Stage6"); // ステージ6
                break;
            case 7:
                SceneManager.LoadScene("Stage7"); // ステージ7
                break;
            case 8:
                SceneManager.LoadScene("Stage8"); // ステージ8
                break;
            case 9:
                SceneManager.LoadScene("Stage9"); // ステージ9
                break;
            case 10:
                SceneManager.LoadScene("Stage10"); // ステージ10
                break;
            case 11:
                SceneManager.LoadScene("Stage11"); // ステージ11
                break;
            case 12:
                SceneManager.LoadScene("Stage12"); // ステージ12
                break;
            case 13:
                SceneManager.LoadScene("Menu"); // メニュー
                break;
            default:
                break;
        }
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
        systemUiManager.SendMessage("destroyPauseUi");
        timerManager.SendMessage("resetTimer");
        gameModeManager.SendMessage("systemScene");
        SceneManager.LoadScene("Start");
    }

    void destroyMode()
    {
        destroyMode();
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