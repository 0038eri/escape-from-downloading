using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSkip : MonoBehaviour {

	// タイマー
    private float timer;

	void Update () {
     
        /// タイマーが20秒経過したら
		/// ゲーム1に移動する
        timer += Time.deltaTime;
        if (timer >= 20.0f) {
            SceneManager.LoadScene("Game1");
        }

    }

    /// オープニングより
	/// ステージ1に移動
	public void toGame1 () {
		SceneManager.LoadScene("Game1");
	}

    /// エンディングより
	/// スタート画面に移動
	public void toStart () {
		SceneManager.LoadScene("Start");
	}

}