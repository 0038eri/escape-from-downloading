using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOperation : MonoBehaviour {
	
	// プレイヤー移動速度
	public float speed = 0.7f;
    // プレイヤー前進判定
    public bool isRunning = false;
	
	void Update () {

        // 前進
        if(isRunning=true){
		this.transform.position -= transform.up * speed * Time.deltaTime;
        }

		// Spaceでジャンプ
		if (Input.GetKeyDown (KeyCode.Space)) {
			this.transform.position += new Vector3 (0, 1.0f, 0);
		}
		// Aで右 
		if (Input.GetKey (KeyCode.A)) {
			transform.position -= transform.right * speed * Time.deltaTime;
		}
		// Dで左 
		if (Input.GetKey (KeyCode.D)) {
			transform.position += transform.right * speed * Time.deltaTime;
		}
		
	}

    // 衝突判定
	void OnCollisionEnter(Collision col){
		
		// エネミーに当たると      
		if (col.gameObject.tag == "Enemy") {
            PlayerState.playerHp--; // HPを1減らす
            GameObject.Find("PlayerManager").SendMessage("updatePlayerHp"); // HP更新
            Destroy(gameObject); // エネミー消滅
		}

		// コインに当たると
		if(col.gameObject.tag=="Coin"){
			GameObject.Find("MoneyManager").SendMessage("getCoin"); // 所持金1増やす
			Destroy(gameObject); // コイン消滅
		}

        // ゴールしたら
        if (col.gameObject.tag == "Goal")
        {
            GameObject.Find("PlayerManager").SendMessage("gameClear"); // ゲームクリア
        }

	}

}