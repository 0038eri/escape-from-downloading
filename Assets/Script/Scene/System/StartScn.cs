using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScn : MonoBehaviour
{

    // PlayerPrefs保存切り替え判定
    public static bool prefsSave = false;

    // ステージクリア判定
    public static int stageNumber = 0;

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

    // 移動するシーンを確認
    void toNextScene()
    {
        switch (stageNumber){
            case 0: 
                SceneManager.LoadScene("Opening"); // オープニング
                break;

            case 1:
                SceneManager.LoadScene("Stage1"); // ステージ1
                break;

            case 2:
                SceneManager.LoadScene("Stage2"); // ステージ2
                break;

            case 3:
                SceneManager.LoadScene("Stage3"); // ステージ3
                break;

            case 4:
                SceneManager.LoadScene("Stage4"); // ステージ4
                break;

            case 5:
                SceneManager.LoadScene("Stage5"); // ステージ5
                break;

            case 6:
                SceneManager.LoadScene("Stage6"); // ステージ6
                break;

            case 7:
                SceneManager.LoadScene("Stage7"); // ステージ7
                break;

            case 8:
                SceneManager.LoadScene("Stage8"); // ステージ8
                break;

            case 9:
                SceneManager.LoadScene("Stage9"); // ステージ9
                break;

            case 10:
                SceneManager.LoadScene("Stage10"); // ステージ10
                break;

            case 11:
                SceneManager.LoadScene("Stage11"); // ステージ11
                break;

            case 12:
                SceneManager.LoadScene("Stage12"); // ステージ12
                break;

            default:
                break;
        }
    }



}