using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SystemSwitchManager : SingletonMonoBehaviour<SystemSwitchManager> {

    private GameObject player;
    private GameObject PlayerCam;
    private GameObject SystemCam;
    private GameObject gameStart;

    void Awake()
    {
        DontDestroyOnLoad(this);
        player = GameObject.Find("Player");
        PlayerCam = GameObject.Find("GameCamera");
        SystemCam = GameObject.Find("SystemCamera");
        gameStart = GameObject.Find("GameStart");
    }

    void Start()
    {
        SceneManager.sceneLoaded += sceneSwitch;
    }

    void sceneSwitch(Scene scene, LoadSceneMode sceneMode)
    {
        Debug.Log(scene.name);
        switch (scene.name)
        {
            // システムシーン
            case "Start":
            case "Opening":
            case "Menu":
            case "Option":
            case "Ending":
                //player.SetActive(false);
                PlayerCam.SetActive(false);
                SystemCam.SetActive(true);
                gameStart.SetActive(false);
                GameStartAnimator.Instance.readyStartAnimation();
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
                //PlayerUiManager.Instance.truePlayerUi();
                PlayerStateManager.Instance.beforeGameMethod();
                //player.SetActive(true);
                PlayerOperation.Instance.playerStartPos();
                PlayerCam.SetActive(true);
                SystemCam.SetActive(false);
                break;
            default:
                break;
        }
    }

}