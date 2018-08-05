using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class PlayerSetActive : MonoBehaviour {

    // プレイヤー
    private GameObject player;

    // ゲームスタート Animator
    private Animator gameStartAnimator;

	void Awake () 
    {

        player = GameObject.Find("Player"); // プレイヤー取得
        gameStartAnimator = GameObject.Find("GameStart").GetComponent<Animator>();

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
                player.SetActive(false); // プレイヤー停止
                gameStartAnimator.enabled = false;
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
                player.SetActive(true); // プレイヤー
                gameStartAnimator.enabled = true;
                player.SendMessage("playerStartPos"); // Playerポジション
                break;

            default:
                break;

		}

	}

}