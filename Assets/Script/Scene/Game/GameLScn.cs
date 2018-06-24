using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameLScn : MonoBehaviour {

	// ラストステージクリア判定
	public static bool stageLClear=false;

    // ステージラストクリア
	public void clearAll () {
		stageLClear = true; // ステージラストクリア済みにする      
		SceneManager.LoadScene("Ending"); // エンディング画面に移動    
	}

    // ステージラストリスタート
	public void oneMoreL () {
		SceneManager.LoadScene ("GameL"); // ラストステージに移動
	}

	// ラストステージクリア判定を送信
	public static bool gameLClear () {
		return stageLClear;
	}

}