using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScn : MonoBehaviour {

    // PlayerPrefs保存切り替え判定
	public static bool prefsSave=false;
	
	// オープニング実行判定
	public static bool op=false;

	// ステージ1クリア判定
	bool game1ClearJudge;
	// ステージ2クリア判定
	bool game2ClearJudge;
	// ラストステージクリア判定
	bool gameLClearJudge;

	void Awake () {
    
		prefsSave = true; // PlayerPrefsに保存する

	}

	void Start (){
		
		game1ClearJudge = Game1Scn.game1Clear (); // ステージ1クリア判定を入れる      
		game2ClearJudge = Game2Scn.game2Clear (); // ステージ2クリア判定を入れる      
		gameLClearJudge = GameLScn.gameLClear(); // ステージラストクリア判定を入れる

	}
    
	void Update () {

        // SpaceKey押した時
		if (Input.GetKey (KeyCode.Space)) {
			
			/// オープニングを実行していない場合
			/// オープニング画面に移動し、オープニング実行済み
			if (op == false) {
				SceneManager.LoadScene ("Opening");
				op = true;	
			}

            // オープニングを実行済みの場合 
			else if (op == true) {
				 
				SceneManager.LoadScene ("Game1"); // ステージ1に移動

                // ステージ1クリア済みの場合
				if (game1ClearJudge == true) {
                    SceneManager.LoadScene("Game2"); // ステージ2に移動
                }

                // ステージ2クリア済みの場合
                if (game2ClearJudge == true) {
                    SceneManager.LoadScene("GameL"); // ステージラストに移動
                }

                // ステージラストクリア済みの場合
                if (gameLClearJudge == true) {
                    SceneManager.LoadScene("Menu"); // メニュー画面に移動
                }

			}
            
		}

	}	

}