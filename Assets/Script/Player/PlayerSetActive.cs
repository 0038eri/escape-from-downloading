using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerSetActive : MonoBehaviour {
    
    // プレイヤー MeshRenderer
	private MeshRenderer playerRenderer;

	void Awake () {
		     
        // シーン移動ごとに毎回呼び出し
        SceneManager.sceneLoaded += checkScene;

	}
    
	void Start () {
		
        // プレイヤーMeshRenderer取得
		playerRenderer = GameObject.Find("Player").GetComponent<MeshRenderer>();

	}

    /// シーン移動時毎回読み込まれる
    /// Player透明化判定メソッド
	void checkScene (Scene scene,LoadSceneMode SceneMode) {
		
		/// Scene scenename,LoadSceneMode SceneMode は、SceneManager.sceneLoaded の引数である
		/// Awakeでの場合は引数は省略されている
		 
        // プレイヤー 不可視
		switch (scene.name) {
		case "Ending":
		case "GameClear":
		case "GameOver":
		case "Item1":
		case "Menu":	
		case "Opening":
		case "Option":
		case "Setting":
		case "Shop":
		case "Start":
			playerRenderer.enabled = false;
			break;

        // プレイヤー 可視
		case "Game1":
		case "Game2":
		case "GameL":
		case "StageSample":
		case "Stage1":
			playerRenderer.enabled = true;
			break;

		default:
			break;
		}

	}

}