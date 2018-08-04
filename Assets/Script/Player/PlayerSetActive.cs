using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSetActive : MonoBehaviour {

    // プレイヤー
    private GameObject player;

    // ゲームスタート Animator
    private Animator gamestartAnimator;

	void Awake () 
    {

        player = GameObject.Find("Player"); // プレイヤー取得
        gamestartAnimator = GameObject.Find("CanvasObj").GetComponent<Animator>();

        SceneManager.sceneLoaded += checkSceneP; // シーン移動ごとに毎回呼び出し

	}

    // シーン移動時毎回読み込まれる
    private void checkSceneP (Scene scene,LoadSceneMode sceneMode) {
		
		/// Scene scenename,LoadSceneMode SceneMode は、SceneManager.sceneLoaded の引数である
		/// Awakeでの場合は引数は省略されている
		 
		switch (scene.name) {

            // システムシーン
            case "Start":
            case "Opening":
            case "Menu":
            case "Option":
            case "Ending":
                gamestartAnimator.enabled = false;
                player.SetActive(false); // プレイヤー停止
                break;

            // ステージシーン
            case "Prefab":
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
                GameObject.Find("CanvasObj").SendMessage("getGameStartCanvas");
                gamestartAnimator.enabled = true;
                player.SetActive(true); // プレイヤー
                player.SendMessage("playerStartPos"); // Playerポジション
                break;

            default:
                break;

		}

	}

}