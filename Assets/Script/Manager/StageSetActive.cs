using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StageSetActive : MonoBehaviour {

    // プレイヤー Canvas
    private Canvas playerCanvas;

    void Awake()
    {

        playerCanvas = GameObject.Find("PlayerCanvas").GetComponent<Canvas>(); // プレイヤーCanvas取得

        SceneManager.sceneLoaded += checkSceneS; // シーン移動ごとに毎回呼び出し
        Debug.Log("StageSetActive.cs");
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
                GameObject.Find("StageManager").SendMessage("stopTimer");
                playerCanvas.enabled = false; // UI非表示
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
                GameObject.Find("StageManager").SendMessage("startTimer");
                break;

            default:
                break;

        }

    }

}