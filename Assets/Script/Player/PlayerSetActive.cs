using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSetActive : MonoBehaviour {
    
    // プレイヤー MeshRenderer
	private MeshRenderer playerRenderer;
    // プレイヤー Canvas
    private Canvas playerCanvas;

    //private Canvas debugCanvas;

	void Awake () {
		    
        SceneManager.sceneLoaded += checkScene; // シーン移動ごとに毎回呼び出し

	}
    
	void Start () {
		
        playerRenderer = GameObject.Find("Player").GetComponent<MeshRenderer>(); // プレイヤーMeshRenderer取得
        playerCanvas = GameObject.Find("PlayerCanvas").GetComponent<Canvas>(); // プレイヤーCanvas取得

        //debugCanvas = GameObject.Find("Canvas").GetComponent<Canvas>();

	}

    // シーン移動時毎回読み込まれる
	void checkScene (Scene scene,LoadSceneMode SceneMode) {
		
		/// Scene scenename,LoadSceneMode SceneMode は、SceneManager.sceneLoaded の引数である
		/// Awakeでの場合は引数は省略されている
		 
		switch (scene.name) {

            case "Start":
            case "Opening":
            case "Menu":
            case "Option":
            case "Ending":
                playerRenderer.enabled = false; // プレイヤー不可視
                GameObject.Find("StageManager").SendMessage("stopTimer"); // タイマー停止
                playerCanvas.enabled = false; // UI非表示
                //debugCanvas.enabled = false;
                break;

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
                playerRenderer.enabled = true; // プレイヤー可視
                GameObject.Find("StageManager").SendMessage("startTimer"); // タイマー開始
                playerCanvas.enabled = true; // UI表示
                //debugCanvas.enabled = true;
                break;

            default:
                break;

		}

	}

}