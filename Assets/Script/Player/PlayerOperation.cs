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
    private float slideSpeed;
    // スライド判定
    private int slide;

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
        if(Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log("右に移動する準備完了");
            isRightArrow = true; // 右キー入力した
        }
        // 左
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log("左に移動する準備完了");
            isLeftArrow = true; // 左キー入力した
        }

    }

    private void FixedUpdate()
    {
        
        // 右キー入力したら
        if(isRightArrow==true)
        {
            Debug.Log("右に移動した");
            inputRight();
            isRightArrow = false; // 右キー入力完了
        }
        // 左キー入力したら
        if(isLeftArrow==true)
        {
            Debug.Log("左に移動した");
            inputLeft();
            isLeftArrow = false; // 左キー入力完了
        }

    }

    // 前進
    public void RunningMethod()
    {
        this.transform.position -= transform.up * runSpeed * Time.deltaTime;
    }

    /// 右 : 0
    /// 真ん中 : 1
    /// 左 : 2

    // プレイヤー初期位置
    void playerStartPos(Scene scene,LoadSceneMode sceneMode)
    {
        playerPos = new Vector3(0.0f, 0.0f, 0.0f);
        this.transform.position = playerPos;
        slide = 1;
        Debug.Log(slide);
    }

    // 座標中央に移動
    void playerCenter()
    {
        playerPos.z = 0.0f;
        this.transform.position = playerPos;
        slide = 1;
        Debug.Log(slide);
    }

    // 座標右に移動
    void playerRight ()
    {
        playerPos.z = 1.0f;
        this.transform.position = playerPos;
        slide = 0;
        Debug.Log(slide);
    }

    // 座標左に移動
    void playerLeft()
    {
        playerPos.z = -1.0f;
        this.transform.position = playerPos;
        slide = 2;
        Debug.Log(slide);
    }

    // 右入力
    void inputRight()
    {
        switch (slide)
        {
            // 中央である時
            case 1:
                playerRight();
                break;
            // 左であるとき
            case 2:
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
            case 1:
                playerLeft();
                break;
            // 右であるとき
            case 0:
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