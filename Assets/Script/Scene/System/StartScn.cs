using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScn : MonoBehaviour
{

    // PlayerPrefs保存切り替え判定
    public static bool prefsSave = false;

    // オープニング実行判定
    public static bool op = false;

    /// 

    void Awake()
    {

        prefsSave = true; // PlayerPrefsに保存する

    }

    private void Update()
    {
        // クリックした時
        if (Input.GetMouseButtonDown(0)){
            toNextScene(); // シーンをチェック
        }
    }

    void toNextScene()
    {
            /// オープニングを実行していない場合
            /// オープニング画面に移動し、オープニング実行済み
            if (op == false)
            {
                SceneManager.LoadScene("Opening");
                op = true;
            }
    }

}