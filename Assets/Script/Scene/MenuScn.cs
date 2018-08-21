using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class MenuScn : MonoBehaviour {

    private int stageJudgeNumber;

    public Button[] stageButton;

    private void Awake()
    {
        stageJudgeNumber = StageJudgeManager.Instance.stageNumberCheck();
    }

    void Start()
    {
        SoundManager.Instance.playBgm();
        CanPlay();
    }

    void CanPlay()
    {
        switch (stageJudgeNumber)
        {
            case 1:
                stageButton[0].onClick.AddListener(toStage1);
                break;
            case 2:
                stageButton[0].onClick.AddListener(toStage1);
                stageButton[1].onClick.AddListener(toStage2);
                break;
            case 3:
                stageButton[0].onClick.AddListener(toStage1);
                stageButton[1].onClick.AddListener(toStage2);
                stageButton[2].onClick.AddListener(toStage3);
                break;
            case 4:
                stageButton[0].onClick.AddListener(toStage1);
                stageButton[1].onClick.AddListener(toStage2);
                stageButton[2].onClick.AddListener(toStage3);
                stageButton[3].onClick.AddListener(toStage4);
                break;
            case 5:
                stageButton[0].onClick.AddListener(toStage1);
                stageButton[1].onClick.AddListener(toStage2);
                stageButton[2].onClick.AddListener(toStage3);
                stageButton[3].onClick.AddListener(toStage4);
                stageButton[4].onClick.AddListener(toStage5);
                break;
            case 6:
                stageButton[0].onClick.AddListener(toStage1);
                stageButton[1].onClick.AddListener(toStage2);
                stageButton[2].onClick.AddListener(toStage3);
                stageButton[3].onClick.AddListener(toStage4);
                stageButton[4].onClick.AddListener(toStage5);
                stageButton[5].onClick.AddListener(toStage6);
                break;
            case 7:
                stageButton[0].onClick.AddListener(toStage1);
                stageButton[1].onClick.AddListener(toStage2);
                stageButton[2].onClick.AddListener(toStage3);
                stageButton[3].onClick.AddListener(toStage4);
                stageButton[4].onClick.AddListener(toStage5);
                stageButton[5].onClick.AddListener(toStage6);
                stageButton[6].onClick.AddListener(toStage7);
                break;
            case 8:
                stageButton[0].onClick.AddListener(toStage1);
                stageButton[1].onClick.AddListener(toStage2);
                stageButton[2].onClick.AddListener(toStage3);
                stageButton[3].onClick.AddListener(toStage4);
                stageButton[4].onClick.AddListener(toStage5);
                stageButton[5].onClick.AddListener(toStage6);
                stageButton[6].onClick.AddListener(toStage7);
                stageButton[7].onClick.AddListener(toStage8);
                break;
            case 9:
                stageButton[0].onClick.AddListener(toStage1);
                stageButton[1].onClick.AddListener(toStage2);
                stageButton[2].onClick.AddListener(toStage3);
                stageButton[3].onClick.AddListener(toStage4);
                stageButton[4].onClick.AddListener(toStage5);
                stageButton[5].onClick.AddListener(toStage6);
                stageButton[6].onClick.AddListener(toStage7);
                stageButton[7].onClick.AddListener(toStage8);
                stageButton[8].onClick.AddListener(toStage9);
                break;
            case 10:
                stageButton[0].onClick.AddListener(toStage1);
                stageButton[1].onClick.AddListener(toStage2);
                stageButton[2].onClick.AddListener(toStage3);
                stageButton[3].onClick.AddListener(toStage4);
                stageButton[4].onClick.AddListener(toStage5);
                stageButton[5].onClick.AddListener(toStage6);
                stageButton[6].onClick.AddListener(toStage7);
                stageButton[7].onClick.AddListener(toStage8);
                stageButton[8].onClick.AddListener(toStage9);
                stageButton[9].onClick.AddListener(toStage10);
                break;
            case 11:
                stageButton[0].onClick.AddListener(toStage1);
                stageButton[1].onClick.AddListener(toStage2);
                stageButton[2].onClick.AddListener(toStage3);
                stageButton[3].onClick.AddListener(toStage4);
                stageButton[4].onClick.AddListener(toStage5);
                stageButton[5].onClick.AddListener(toStage6);
                stageButton[6].onClick.AddListener(toStage7);
                stageButton[7].onClick.AddListener(toStage8);
                stageButton[8].onClick.AddListener(toStage9);
                stageButton[9].onClick.AddListener(toStage10);
                stageButton[10].onClick.AddListener(toStage11);
                break;
            case 12:
            case 13:
                stageButton[0].onClick.AddListener(toStage1);
                stageButton[1].onClick.AddListener(toStage2);
                stageButton[2].onClick.AddListener(toStage3);
                stageButton[3].onClick.AddListener(toStage4);
                stageButton[4].onClick.AddListener(toStage5);
                stageButton[5].onClick.AddListener(toStage6);
                stageButton[6].onClick.AddListener(toStage7);
                stageButton[7].onClick.AddListener(toStage8);
                stageButton[8].onClick.AddListener(toStage9);
                stageButton[9].onClick.AddListener(toStage10);
                stageButton[10].onClick.AddListener(toStage11);
                stageButton[11].onClick.AddListener(toStage12);
                break;
            default:
                break;
        }
    }

    // スタート画面に移動
    public void toStart ()
    {
        SceneManager.LoadScene("Start");
    }

    // オプション画面に移動
    public void toOption ()
    {
        SceneManager.LoadScene("Option");
    }

	// ステージ1に移動
	public void toStage1 () 
    {
		SceneManager.LoadScene ("Stage1");
	}

    // ステージ2に移動
    public void toStage2 ()
    {
        SceneManager.LoadScene("Stage2");
    }

    // ステージ3に移動
    public void toStage3 ()
    {
        SceneManager.LoadScene("Stage3");
    }

    // ステージ4に移動
    public void toStage4 () {
        SceneManager.LoadScene("Stage4");

    }

    // ステージ5に移動
    public void toStage5 () {
        SceneManager.LoadScene("Stage5");

    }

    // ステージ6に移動
    public void toStage6 () {
        SceneManager.LoadScene("Stage6");
    }

    // ステージ7に移動
    public void toStage7 () {
        SceneManager.LoadScene("Stage7");
    }

    // ステージ8に移動
    public void toStage8 () {
        SceneManager.LoadScene("Stage8");
    }

    // ステージ9に移動
    public void toStage9 () {
        SceneManager.LoadScene("Stage9");
    }

    // ステージ10に移動
    public void toStage10 () {
        SceneManager.LoadScene("Stage10");
    }

    // ステージ11に移動
    public void toStage11 () {
        SceneManager.LoadScene("Stage11");
    }

    // ステージ12に移動
    public void toStage12 () {
        SceneManager.LoadScene("Stage12");
    }
   
}