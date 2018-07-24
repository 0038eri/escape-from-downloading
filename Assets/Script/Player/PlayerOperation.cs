using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOperation : MonoBehaviour {

    // プレイヤー座標
    public Vector3 playerPos;
    // プレイヤー地面接触判定
    private bool isPlayerCol;

    // 前進速度
    public float runSpeed;
    // 前進判定
    public bool isRunning = false;

    // スライド速度
    public float slideSpeed;
    // スライド判定
    private string slide;

    private void Awake()
    {
        SceneManager.sceneLoaded += playerCenter; // シーン呼び出しごとに毎回プレイヤーを中央に
    }

    private void Start()
    {
        
    }

    void Update () {

        playerPos = this.transform.position; // プレイヤー座標取得

        // 前進
        if(isRunning==true){
            RunningMethod();

            // 右移動
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                playerRight();
            }
            // 左移動
            else if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                playerLeft();
            }

        }

        // ジャンプ
        if (isPlayerCol == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                playerJump();
            }
        }
		
	}

    // 前進メソッド
    public void RunningMethod()
    {
        this.transform.position -= transform.up * runSpeed * Time.deltaTime;
    }

    // プレイヤー初期位置
    void playerCenter (Scene scene,LoadSceneMode sceneMode) {
        Vector3 centerPos = new Vector3(0.0f, 0.0f, 0.0f);
        this.transform.position = centerPos;
        slide = "center"; // 中央に位置する
    }

    // 右移動
    void playerRight(){
        
        switch(slide){

            // 中央である時
            case "center":
                playerPos.z = 1.0f;
                this.transform.position = playerPos;
                slide = "right";
                break;

            // 左であるとき
            case "left":
                playerPos.z = 0.0f;
                this.transform.position = playerPos;
                slide = "center";
                break;

            default:
                break;

        }
    }

    // 左移動
    void playerLeft(){

        switch(slide){

            // 中央であるとき
            case "center":
                playerPos.z = -1.0f;
                this.transform.position = playerPos;
                slide = "left";
                break;

            // 右であるとき
            case "right":
                playerPos.z = 0.0f;
                this.transform.position = playerPos;
                slide = "center";
                break;

            default:
                break;

        }
    }

    // ジャンプ
    void playerJump () {
        playerPos.y += 1.5f; // Y軸1.5ジャンプ
        this.transform.position = playerPos;
    }

    // 衝突判定
    private void OnCollisionEnter(Collision collision)
    {
        isPlayerCol = true; // 地面に接している

        // エネミーに当たると      
        if (collision.gameObject.tag == "Enemy")
        {
            PlayerState.playerHp--; // HPを1減らす
            GameObject.Find("PlayerManager").SendMessage("updatePlayerHp"); // HP更新
            Destroy(gameObject); // エネミー消滅
        }

        // コインに当たると
        if (collision.gameObject.tag == "Coin")
        {
            GameObject.Find("MoneyManager").SendMessage("getCoin"); // 所持金1増やす
            Destroy(gameObject); // コイン消滅
        }

        // ゴールしたら
        if (collision.gameObject.tag == "Goal")
        {
            GameObject.Find("PlayerManager").SendMessage("gameClear"); // ゲームクリア
        }

        //Debug.Log("playerfield");
    }

    private void OnCollisionExit(Collision collision)
    {
        isPlayerCol = false; // 地面と接していない
        //Debug.Log("playersky");
    }

}