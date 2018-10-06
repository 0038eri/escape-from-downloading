using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerStateManager : SingletonMonoBehaviour<PlayerStateManager> {

    private string gameModeCheck;
    private int stageCheckNumber;
    private float fadeTime;

    private void Start()
    {
        fadeTime = FadeAnimation.Instance.valueFadeTime();
    }

    // ゲーム開始前
    public void beforeGameMethod()
    {
        PlayerOperation.Instance.playerStartPos();
        HpManager.Instance.setupHp();
        GameModeManager.Instance.beforeGame();
    }

    public void isPlayingMethod()
    {
        PlayerOperation.Instance.canInput();
        TimerManager.Instance.startTimer();
        GameModeManager.Instance.isPlaying();
    }

    // ゲーム終了
    private void gameFinishMethod()
    {
        PlayerUiManager.Instance.falsePlayerUi();
        // GameStartAnimator.Instance.finishedGame();
        stageCheckNumber = StageJudgeManager.Instance.stageNumberCheck();
    }

    // ゲームクリア
    public void gameClearMethod()
    {
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
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(nextCoroutine());
    }

    IEnumerator nextCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        destroyUi();
        StageJudgeManager.Instance.sceneTransition();
    }

    public void restartGame()
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(restartCoroutine());
    }

    IEnumerator restartCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        destroyUi();
        string sceneName = SceneManager.GetActiveScene().name;
        SceneManager.LoadScene(sceneName);
    }

    public void backMenuP()
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(backMenuP_Coroutine());
    }

    IEnumerator backMenuP_Coroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        destroyUi();
        TimerManager.Instance.resetTimer();
        GameModeManager.Instance.systemScene();
        SceneManager.LoadScene("Menu");
    }

    public void escapeGameP()
    {
        FadeAnimation.Instance.goFadeOut();
        StartCoroutine(escapeGameP_Corountine());
    }

    IEnumerator escapeGameP_Corountine()
    {
        yield return new WaitForSeconds(fadeTime);
        destroyUi();
        TimerManager.Instance.resetTimer();
        GameModeManager.Instance.systemScene();
        SceneManager.LoadScene("Start");
    }

    void destroyUi()
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