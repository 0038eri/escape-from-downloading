using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerOperation : SingletonMonoBehaviour<PlayerOperation>
{

    private Vector3 playerPos;
    private Rigidbody playerRb;
    private float timer = 0.0f;
    private float runSpeed = 20;
    private float squatTime = 1.0f;
    private float[] slideSpeed = { 4, -4 };
    private int slide = 1;
    /// 右 : 0
    /// 真ん中 : 1
    /// 左 : 2
    private int isWhichArrow = 0;
    /// 0 : 入力なし
    /// 1 : 右入力
    /// 2 : 左入力 
    /// 3 : 下入力
    /// 4 : ジャンプ入力
    private bool gameJudge;
    private bool canNotSlide;
    private bool isJumping = false;
    private bool isPlayerCol;

private void Start()
{
    canNotSlide = true;
    playerRb = GetComponent<Rigidbody>();
}
void Update()
{

    playerPos = this.transform.position; // プレイヤー座標取得

    gameJudge = GameModeManager.Instance.sendFlag();
    if(gameJudge == false)
    {
        canNotSlide = true;
    }
    else if(gameJudge == true)
    {
        RunningMethod();

        if(canNotSlide == false) // スライド変更不可能判定が可能
        {

            if(Input.GetKeyDown(KeyCode.RightArrow))
            {
                isWhichArrow = 1;
                canNotSlide = true; // スライド変更判定不可能
            }
            if(Input.GetKeyDown(KeyCode.LeftArrow))
            {
                isWhichArrow = 2;
                canNotSlide = true; // スライド変更判定不可能
            }
            if(Input.GetKeyDown(KeyCode.DownArrow))
            {
                isWhichArrow = 3;
                canNotSlide = true;
            }
            if(isPlayerCol == true) // 地面に触れていたら
            {
                if(Input.GetKeyDown(KeyCode.Space))
                {
                    isWhichArrow = 4;
                    isJumping = true;
                    canNotSlide = true;
                }
            }

        }
           
        if(isWhichArrow == 1)
        {
            slideToRight();
        }
        else if(isWhichArrow == 2)
        {
            slideToLeft();
        }
        else if(isWhichArrow == 3)
        {
            slideToDown();
        }
        else if(isWhichArrow == 4)
        {
            inputJump();
        }
        else if(isWhichArrow == 0)
        {
            canNotSlide = false;
        } 

        // Debug.Log(isWhichArrow);
        // Debug.Log(slide);

    }

}

public void canInput()
{
    canNotSlide = false;
}

    public void RunningMethod()
    {
        playerRb.AddForce(Vector3.left * runSpeed);
    }

    // プレイヤー初期位置
    public void playerStartPos()
    {
        Vector3 playerStartTransformPos;
        playerStartTransformPos = new Vector3(0.0f, 1.0f, 0.0f);
        this.transform.position = playerStartTransformPos;
        slide = 1;
    }

    // ジャンプ入力
    void inputJump()
    {
        if(isJumping == true)
        {
        float jumpHeight = 4.0f; // ジャンプの高さ
        playerPos.y += jumpHeight; // Y軸1.5ジャンプ
        this.transform.position = playerPos;
        isJumping = false;
        }
    }

    // 右側に移動する
    void slideToRight()
    {
        switch (slide)
        {
            case 1: // 真ん中にいる
                if (playerPos.z < 1.5f) // 右に移動完了していなかったら
                {
                    this.transform.position += Vector3.forward * slideSpeed[0] * Time.deltaTime; // 右側に移動する
                }
                else if (playerPos.z >= 1.5f)
                {
                    slide = 0; // 右に移動完了
                    isWhichArrow = 0; // 右入力完了
                }
                break;
            case 2: // 左にいる
                if (playerPos.z < 0.0f) // 真ん中に移動完了していなかったら
                {
                    this.transform.position += Vector3.forward * slideSpeed[0] * Time.deltaTime; // 右側に移動する
                }
                else if (playerPos.z >= 0.0f)
                {
                    slide = 1; // 真ん中に移動完了
                    isWhichArrow = 0; // 右入力完了
                }
                break;
            default:
                canNotSlide = false; // スライド可能になる
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
                else if (playerPos.z <= 1.5f)
                {
                    slide = 1; // 真ん中に移動完了
                    isWhichArrow = 0; // 左入力完了
                }
                break;
            case 1: // 真ん中にいる
                if (playerPos.z > -1.5f) // 左に移動完了していなかったら 
                {
                    this.transform.position += Vector3.forward * slideSpeed[1] * Time.deltaTime; // 左側に移動する
                }
                else if (playerPos.z <= -1.5f)
                {
                    slide = 2; // 左に移動完了
                    isWhichArrow = 0; // 左入力完了
                }
                break;
            default:
                canNotSlide = false; // スライド可能になる
                break;
        }
    }

    void slideToDown()
    {
        Vector3 playerSca = this.transform.localScale;
        timer += Time.deltaTime;
        Debug.Log(timer);
        if(timer<squatTime){
            Debug.Log("しゃがんでいる");
            playerSca.z = 0.4f;
            this.transform.localScale = playerSca;
        }
        else if (timer>=squatTime)
        {
            Debug.Log("しゃがみおわったから、りせっとしよ！");
            playerSca.z = 1.0f;
            this.transform.localScale = playerSca;
            timer = 0.0f;
            isWhichArrow = 0;
        }
    }

    // 衝突判定
    private void OnCollisionStay(Collision collision)
    {
        isPlayerCol = true; // 地面に接している

        // オブジェクト
        if (collision.gameObject.tag == "Objects")
        {
            PlayerStateManager.Instance.gameOverMethod();
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        /// ジャンプして、着地したとき、
        /// isWhichArrowが0でなかったとき
        /// デフォルトに戻す
        if(isWhichArrow == 4)
        {
            isWhichArrow = 0;
        }

        if (collision.gameObject.tag == "Goal")
        {
            PlayerStateManager.Instance.gameClearMethod();
        }

        // エネミーに当たると      
        if (collision.gameObject.tag == "Enemy")
        {
            HpManager.Instance.playerHpEnemy();
            HpManager.Instance.updatePlayerHp();
            Destroy(gameObject); // エネミー消滅
        }

        // コインに当たると
        if (collision.gameObject.tag == "Coin")
        {
            MoneyManager.Instance.getCoin();
            Destroy(gameObject); // コイン消滅
        }

    }

    private void OnCollisionExit(Collision collision)
    {
        isPlayerCol = false; // 地面と接していない
    }

}