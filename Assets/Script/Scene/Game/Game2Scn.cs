using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Game2Scn : MonoBehaviour {

	// ステージ2クリア判定
	public static bool stage2Clear=false;

    // ステージ2クリア
	public void nextScene2 () {
		stage2Clear = true; // ステージ2クリア済みにする      
		SceneManager.LoadScene ("Menu"); // メニューに移動   
	}

    // ステージ2リスタート
	public void oneMore2 () {
		SceneManager.LoadScene ("Game2"); //ステージ2に移動
	}

	// ステージ2クリア判定を送信
	public static bool game2Clear () {		
		return stage2Clear;
	}

}