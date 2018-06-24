using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScn : MonoBehaviour {
	
	// ステージ2クリア判定
    static bool game2Clear;

	// ステージラストボタン表示
	public GameObject toL;

	void Start () {
		
		game2Clear = Game2Scn.game2Clear(); // Game2のクリア判定を入れる      
        // もしGame2クリア済みだったら
        if (game2Clear == true) {
			toL.gameObject.SetActive(true); // ボタン表示
        }

    }

	void Update () {
        // オプション画面に移動
        if (Input.GetKeyDown(KeyCode.O)) {
            toOption();
        }

    }
    // スタート画面に移動
    public void toStart()
    {
        SceneManager.LoadScene("Start");
    }

    // オプション画面に移動
    public void toOption()
    {
        SceneManager.LoadScene("Option");
    }

	// ステージ1に移動
	public void toGame1 () 
    {
		SceneManager.LoadScene ("Game1");
	}

    // ステージ2に移動
    public void toGame2()
    {
        SceneManager.LoadScene("Game2");
    }

    // ステージラストに移動
    public void toLast()
    {
        SceneManager.LoadScene("GameL");
    }
   
}