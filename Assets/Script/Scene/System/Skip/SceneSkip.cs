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
            SceneManager.LoadScene("Stage1");
        }

    }

    /// オープニングより
	/// ステージ1に移動
	public void skipToStage1 () {
		SceneManager.LoadScene("Stage1");
	}

    /// エンディングより
	/// スタート画面に移動
	public void backToStart () {
		SceneManager.LoadScene("Start");
	}

}