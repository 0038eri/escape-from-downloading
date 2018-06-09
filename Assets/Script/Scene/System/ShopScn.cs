using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ShopScn : MonoBehaviour {

	void Update () {
		
		// アイテム1購入画面
		if (Input.GetKey (KeyCode.Alpha1)) {
			SceneManager.LoadScene ("Item1");
		}

		// アイテム2購入画面
		if (Input.GetKey (KeyCode.Alpha2)) {
			SceneManager.LoadScene ("Item2");
		}
	}

	//Menuに移動
	public void backMenu () {
		SceneManager.LoadScene("Menu");
	}

}