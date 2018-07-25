using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOperation : MonoBehaviour
{

    // プレイヤー座標
    private Vector3 playerPos;
    // プレイヤー地面接触判定
    private bool isPlayerCol;

    // 前進速度
    public float runSpeed;
    // 前進判定
    public bool isRunning = false;

    // スライド速度
    private float slideSpeed;
    // スライド判定
    private string slide;
    // 中央座標
    private Vector3 centerPos;
    // 右座標
    private Vector3 rightPos;
    // 左座標
    private Vector3 leftPos;

    // 右矢印ボタン入力判定
    private bool isRightArrow;
    // 左矢印ボタン入力判定
    private bool isLeftArrow;

    // ジャンプの高さ
    public float jumpHeight;

    private void Awake()
    {
        SceneManager.sceneLoaded += playerStartPos; // シーン呼び出しごとに毎回プレイヤーを中央に
    }

    private void Start()
    {
        // 座標を代入
        centerPos.z = 0.0f;
        rightPos.z = 1.0f;
        leftPos.z = -1.0f;
    }

    void Update()
    {

        playerPos = this.transform.position; // プレイヤー座標取得

        // 前進
        if (isRunning == true)
        {
            RunningMethod();
        }

        // ジャンプ
        if (isPlayerCol == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                inputJump();
            }
        }

        // 右
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            isRightArrow = true; // 右キー入力した
        }
        // 左
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            isLeftArrow = true; // 左キー入力した
        }

    }

    private void FixedUpdate()
    {
        
        // 右キー入力したら
        if(isRightArrow==true)
        {
            inputRight();
            isRightArrow = false; // 右キー入力完了
        }
        // 左キー入力したら
        else if(isLeftArrow==true)
        {
            inputLeft();
            isLeftArrow = false; // 左キー入力完了
        }

    }

    // 前進
    public void RunningMethod()
    {
        this.transform.position -= transform.up * runSpeed * Time.deltaTime;
    }

    // プレイヤー初期位置
    void playerStartPos(Scene scene,LoadSceneMode sceneMode)
    {
        playerPos = new Vector3(0.0f, 0.0f, 0.0f);
        this.transform.position = playerPos;
        slide = "center";
    }

    // 座標中央に移動
    void playerCenter()
    {
        playerPos.z = centerPos.z;
        this.transform.position = playerPos;
        slide = "center";
    }

    // 座標右に移動
    void playerRight ()
    {
        playerPos.z = rightPos.z;
        this.transform.position = playerPos;
        slide = "right";
    }

    // 座標左に移動
    void playerLeft()
    {
        playerPos.z = leftPos.z;
        this.transform.position = playerPos;
        slide = "left";
    }

    // 右入力
    void inputRight()
    {
        switch (slide)
        {
            // 中央である時
            case "center":
                playerRight();
                break;
            // 左であるとき
            case "left":
                playerCenter();
                break;
            default:
                break;
        }
    }

    // 左入力
    void inputLeft()
    {
        switch (slide)
        {
            // 中央であるとき
            case "center":
                playerLeft();
                break;
            // 右であるとき
            case "right":
                playerCenter();
                break;
            default:
                break;
        }
    }

    // ジャンプ入力
    void inputJump()
    {
        playerPos.y += jumpHeight; // Y軸1.5ジャンプ
        this.transform.position = playerPos;
    }

    // 衝突判定
    private void OnCollisionStay (Collision collision)
    {
        isPlayerCol = true; // 地面に接している

        // オブジェクト
        if (collision.gameObject.tag == "Objects")
        {
            GameObject.Find("PlayerManager").SendMessage("gameOver"); // ゲームオーバー
        }

    }

    private void OnCollisionEnter(Collision collision)
    {

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

    }

    private void OnCollisionExit(Collision collision)
    {
        isPlayerCol = false; // 地面と接していない
    }

    private void OnTriggerEnter(Collider other)
    {
        // ゴールしたら
        if (other.gameObject.tag == "Goal")
        {
            GameObject.Find("PlayerManager").SendMessage("gameClear"); // ゲームクリア
        }
    }

}