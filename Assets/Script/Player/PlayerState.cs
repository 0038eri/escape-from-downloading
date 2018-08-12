using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerState : MonoBehaviour {
    
    private GameObject player;
    private GameObject hpManager;
    private GameObject gameModeManager;
    private GameObject playerUiManager;
    private GameObject timerManager;
    private GameObject stageJudgeManager;
    private StageJudge stageJudge;
    private GameObject systemUiManager;

    private int stageCheckNumber;

    void Awake()
    {
        player = GameObject.Find("Player");
        hpManager = GameObject.Find("HpManager");
        gameModeManager = GameObject.Find("GameModeManager");
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
        gameModeManager.SendMessage("isPlaying");
        timerManager.SendMessage("startTimer");
        player.SendMessage("gameStartRun");
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
        gameModeManager.SendMessage("gameClear");
        systemUiManager.SendMessage("displayClear");
    }

    // ゲームオーバー
    public void gameOverMethod()
    {
        gameFinishMethod();
        gameModeManager.SendMessage("gameOver");
        systemUiManager.SendMessage("displayOver");
    }

    public void nextGame()
    {
        Debug.Log("nextGame");
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
        Debug.Log("restartGame");
    }

    public void backMenuP()
    {
        Debug.Log("backMenuP");
        timerManager.SendMessage("resetTimer");
        SceneManager.LoadScene("Menu");
    }

    public void escapeGameP()
    {
        Debug.Log("escapeGameP");
        timerManager.SendMessage("resetTimer");
        systemUiManager.SendMessage("closePauseUi");
        SceneManager.LoadScene("Start");
    }

}