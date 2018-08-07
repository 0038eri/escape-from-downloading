using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PrefabScn : MonoBehaviour {

	// Startに移動
	void Awake () {
		SceneManager.LoadScene("Start");
	}

}