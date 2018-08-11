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
    private float runSpeed = 12;
    // 前進判定
    private bool isRunning;

    // スライド速度
    private float[] slideSpeed = { 4, -4 };
    // スライド判定
    private int slide;
    /// 右 : 0
    /// 真ん中 : 1
    /// 左 : 2

    // 矢印ボタン入力
    private int isWhichArrow = 0;
    /// 0 : 入力なし
    /// 1 : 右入力
    /// 2 : 左入力 

    // スライド変更不可能判定
    private bool canNotSlide = false;

    private GameObject hpManager;
    private GameObject moneyManager;
    private GameObject playerManager;

    void Awake()
    {
        hpManager = GameObject.Find("HpManager");
        moneyManager = GameObject.Find("MoneyManager");
        playerManager = GameObject.Find("PlayerManager");
    }

    private void Start()
    {
        SceneManager.sceneLoaded += playerStartPos; // シーン呼び出しごとに毎回プレイヤーを中央に
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
        if (isPlayerCol == true) // 地面に触れていたら
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                inputJump();
            }
        }

        if (canNotSlide == false) // スライド変更不可能判定が可能
        {
            // 右
            if (Input.GetKeyDown(KeyCode.RightArrow))
            {
                isWhichArrow = 1; // 右キー入力した判定
                canNotSlide = true; // スライド変更判定不可能
            }
            // 左
            if (Input.GetKeyDown(KeyCode.LeftArrow))
            {
                isWhichArrow = 2; // 左キー入力した判定
                canNotSlide = true; // スライド変更判定不可能
            }
        }

        // 右キー入力したら
        if (isWhichArrow == 1)
        {
            slideToRight();
        }
        // 左キー入力したら
        else if (isWhichArrow == 2)
        {
            slideToLeft();
        }
        // なにも入力していなかったら
        else if (isWhichArrow == 0)
        {
            canNotSlide = false; // スライド可能になる
        }
    }

    public void gameStartRun()
    {
        canInput();
        goRunning();
    }

    public void canInput()
    {
        canNotSlide = false;
    }

    public void cannotInput()
    {
        canNotSlide = true;
    }

    public void goRunning()
    {
        isRunning = true;
    }

    public void stopRunning()
    {
        isRunning = false;
    }

    // 前進
    public void RunningMethod()
    {
        this.transform.position -= transform.up * runSpeed * Time.deltaTime;
    }

    // プレイヤー初期位置
    public void playerStartPos(Scene scene, LoadSceneMode sceneMode)
    {
        Vector3 playerStartTransformPos;
        playerStartTransformPos = new Vector3(0.0f, 1.0f, 0.0f);
        this.transform.position = playerStartTransformPos;
        slide = 1;
    }

    // ジャンプ入力
    void inputJump()
    {
        float jumpHeight = 2.5f; // ジャンプの高さ
        playerPos.y += jumpHeight; // Y軸1.5ジャンプ
        this.transform.position = playerPos;
    }

    // 右側に移動する
    void slideToRight()
    {
        switch (slide)
        {
            case 1: // 真ん中にいる
                if (playerPos.z < 2.0f) // 右に移動完了していなかったら
                {
                    this.transform.position += Vector3.forward * slideSpeed[0] * Time.deltaTime; // 右側に移動する
                }
                else if (playerPos.z >= 2.0f)
                {
                    isWhichArrow = 0; // 右入力完了
                    slide = 0; // 右に移動完了
                }
                break;
            case 2: // 左にいる
                if (playerPos.z < 0.0f) // 真ん中に移動完了していなかったら
                {
                    this.transform.position += Vector3.forward * slideSpeed[0] * Time.deltaTime; // 右側に移動する
                }
                else if (playerPos.z >= 0.0f)
                {
                    isWhichArrow = 0; // 右入力完了
                    slide = 1; // 真ん中に移動完了
                }
                break;
            default:
                break;
        }
    }

    // 左側に移動する
    void slideToLeft()
    {
        switch(slide)
        {
            case 0: // 右にいる
                if (playerPos.z > 0.0f) // 真ん中に移動完了していなかったら
                {
                    this.transform.position += Vector3.forward * slideSpeed[1] * Time.deltaTime; // 左側に移動する
                }
                else if (playerPos.z <= 0.0f)
                {
                    isWhichArrow = 0; // 左入力完了
                    slide = 1; // 真ん中に移動完了
                }
                break;
            case 1: // 真ん中にいるにいる
                if (playerPos.z > -2.0f) // 左に移動完了していなかったら 
                {
                    this.transform.position += Vector3.forward * slideSpeed[1] * Time.deltaTime; // 左側に移動する
                }
                else if (playerPos.z <= -2.0f)
                {
                    isWhichArrow = 0; // 左入力完了
                    slide = 2; // 左に移動完了
                }
                break;
            default:
                break;
        }
    }

    // 衝突判定
    private void OnCollisionStay(Collision collision)
    {
        isPlayerCol = true; // 地面に接している

        // オブジェクト
        if (collision.gameObject.tag == "Objects")
        {
            playerManager.SendMessage("gameOverMethod");
        }

    }

    private void OnCollisionEnter(Collision collision)
    {

        // エネミーに当たると      
        if (collision.gameObject.tag == "Enemy")
        {
            hpManager.SendMessage("playerHpEnemy");
            hpManager.SendMessage("updatePlayerHp");
            Destroy(gameObject); // エネミー消滅
        }

        // コインに当たると
        if (collision.gameObject.tag == "Coin")
        {
            moneyManager.SendMessage("getCoin"); // 所持金1増やす
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
            playerManager.SendMessage("gameClearMethod");
        }
    }

}