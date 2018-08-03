using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneSkip : MonoBehaviour {

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