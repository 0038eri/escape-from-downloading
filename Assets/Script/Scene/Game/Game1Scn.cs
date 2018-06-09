using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game1Scn : MonoBehaviour {
	
	// ステージ1クリア判定
	public static bool stage1Clear=false;

	// 開発時隠しコマンド
	void Update(){
		if (Input.GetKey (KeyCode.S)) {
			SceneManager.LoadScene ("SampleStage");
		}
		if (Input.GetKey (KeyCode.Alpha1)) {
			SceneManager.LoadScene ("Stage1");
		}
	}
	// ここまで

    // ステージ1クリア
	public void nextScene1 () {
		stage1Clear = true; // ステージ1クリア済みにする      
		SceneManager.LoadScene ("Menu"); // メニューに移動
	}

    // ステージ1リスタート
	public void oneMore1 () {
		SceneManager.LoadScene ("Game1"); // ステージ1に移動
	}

    // ステージ1クリア判定を送信
	public static bool game1Clear () {
		return stage1Clear;
	}

}