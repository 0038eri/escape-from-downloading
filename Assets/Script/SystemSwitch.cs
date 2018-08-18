using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SystemSwitch : MonoBehaviour {

    public GameObject player;

    public GameObject PlayerCam;
    public GameObject SystemCam;

    private GameObject playerManager;
    private GameObject playerUiManager;
    private GameObject timerManager;
    private GameObject HpManager;

    private GameObject gameStart;
    private Animator gameStartAnimator;

    void Awake()
    {
        DontDestroyOnLoad(this);
        playerManager = GameObject.Find("PlayerManager");
        playerUiManager = GameObject.Find("PlayerUiManager");
        timerManager = GameObject.Find("TimerManager");
        HpManager = GameObject.Find("HpManager");
        gameStart = GameObject.Find("GameStart");
        gameStartAnimator = gameStart.GetComponent<Animator>();
    }

    void Start()
    {
        SceneManager.sceneLoaded += sceneSwitch;
    }

    void sceneSwitch(Scene scene, LoadSceneMode sceneMode)
    {
        switch (scene.name)
        {
            // システムシーン
            case "Start":
            case "Opening":
            case "Menu":
            case "Option":
            case "Ending":
                player.SetActive(false);
                PlayerCam.SetActive(false);
                SystemCam.SetActive(true);
                gameStart.SetActive(false);
                break;
            // ステージシーン
            //case "Prefab":
            case "Stage1":
            case "Stage2":
            case "Stage3":
            case "Stage4":
            case "Stage5":
            case "Stage6":
            case "Stage7":
            case "Stage8":
            case "Stage9":
            case "Stage10":
            case "Stage11":
            case "Stage12":
            case "StageSample":
                gameStart.SetActive(true);
                playerUiManager.SendMessage("truePlayerUi");
                playerManager.SendMessage("beforeGameMethod");
                player.SetActive(true);
                player.SendMessage("playerStartPos");
                PlayerCam.SetActive(true);
                SystemCam.SetActive(false);
                break;
            default:
                break;
        }
    }

    public void startUpdate()
    {
        timerManager.SendMessage("startUpdateTimer");
        HpManager.SendMessage("startUpdateHp");
    }

}