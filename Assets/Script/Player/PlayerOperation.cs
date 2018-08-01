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
    public bool isRunning;

    // スライド速度
    public float[] slideSpeed;
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

    // 入力不可能判定
    private bool canNotSlide = false;

    private void Start()
    {
        //SceneManager.sceneLoaded += playerStartPos; // シーン呼び出しごとに毎回プレイヤーを中央に
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

        if(canNotSlide==false)
        {
        // 右
        if(Input.GetKeyDown(KeyCode.RightArrow))
            {
            isWhichArrow= 1; // 右キー入力した
            canNotSlide = true;
            }
        // 左
        if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
            isWhichArrow = 2; // 左キー入力した
            canNotSlide = true;
            }
        }

    }

    private void FixedUpdate()
    {

        // 右キー入力したら
        if (isWhichArrow == 1)
        {
            if (playerPos.z == 2.0f)
            {
                isWhichArrow = 0;
                canNotSlide = false;
                switch (slide)
                {
                    case 1:
                        slide = 0;
                        break;
                    case 2:
                        slide = 1;
                        break;
                    default:
                        break;
                }
            } else {
                    slideToRight();
                }
            }
        // 左キー入力したら
        if (isWhichArrow == 2)
        {
            if (playerPos.z == -2.0f)
            {
                isWhichArrow = 0;
                canNotSlide = false;
                switch (slide)
                {
                    case 0:
                        slide = 1;
                        break;
                    case 1:
                        slide = 2;
                        break;
                    default:
                        break;
                }
            } else {
                slideToLeft();
            }
        }
    }

    // 前進
    public void RunningMethod()
    {
        this.transform.position -= transform.up * runSpeed * Time.deltaTime;
    }

    // プレイヤー初期位置
    public void playerStartPos()
    {
        Vector3 playerStartTransformPos;
        playerStartTransformPos = new Vector3(-0.5f, 1.0f, 0.0f);
        this.transform.position = playerStartTransformPos;
        slide = 1;
        Debug.Log(slide);
    }

    // ジャンプ入力
    void inputJump()
    {
        float jumpHeight = 2.5f; // ジャンプの高さ
        playerPos.y += jumpHeight; // Y軸1.5ジャンプ
        this.transform.position = playerPos;
    }

    void slideToRight(){
        this.transform.position += Vector3.forward * slideSpeed[0] * Time.deltaTime;
        playerPos = this.transform.position;
    }

    void slideToLeft(){
        this.transform.position += Vector3.forward * slideSpeed[1] * Time.deltaTime;
        playerPos = this.transform.position;
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