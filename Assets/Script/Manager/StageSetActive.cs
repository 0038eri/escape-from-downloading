using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSetActive : MonoBehaviour {
    
    private GameObject clearCanvas;
    private GameObject overCanvas;
    private GameObject pauseCanvas;
    private GameObject gamestartCanvas;
    private GameObject playerCanvas;

    public GameObject systemCam;

    void Awake()
    {
        clearCanvas = GameObject.Find("ClearCanvas");
        overCanvas = GameObject.Find("OverCanvas");
        pauseCanvas = GameObject.Find("PauseCanvas");
        gamestartCanvas = GameObject.Find("GameStartCanvas");
        playerCanvas = GameObject.Find("PlayerCanvas");

        systemCam = GameObject.Find("SystemCamera");

        SceneManager.sceneLoaded += checkSceneS; // シーン移動ごとに毎回呼び出し
        Debug.Log("StageSetActive.cs");
    }

    private void Start()
    {
        clearCanvas.SetActive(false);
        overCanvas.SetActive(false);
        pauseCanvas.SetActive(false);
        gamestartCanvas.SetActive(false);
        playerCanvas.SetActive(false);
    }

    // シーン移動時毎回読み込まれる
    private void checkSceneS(Scene scene, LoadSceneMode sceneMode)
    {

        /// Scene scenename,LoadSceneMode SceneMode は、SceneManager.sceneLoaded の引数である
        /// Awakeでの場合は引数は省略されている

        switch (scene.name)
        {
            
            // システムシーン
            case "Start":
            case "Opening":
            case "Menu":
            case "Option":
            case "Ending":
                systemCam.SetActive(true);
                GameObject.Find("StageManager").SendMessage("stopTimer");
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
                systemCam.SetActive(false);
                break;

            default:
                break;

        }

    }

}