using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScn : MonoBehaviour {

    private Color bgColor = new Color(0.0f / 255.0f, 113.0f / 255.0f, 188.0f / 255.0f, 255.0f / 255.0f);
    private Camera systemCam;

    private int stageJudgeNumber;
    private GameObject stageJudgeManager;
    private StageJudge stageJudge;

    private Animator stageTrueAnimator;
    private Animator stageFalseAnimator;

    void Awake()
    {
        systemCam = GameObject.Find("SystemCamera").GetComponent<Camera>();
        stageJudgeManager = GameObject.Find("StageJudgeManager");
        stageJudge = stageJudgeManager.GetComponent<StageJudge>();
    }

    void Start()
    {
        systemCam.backgroundColor = bgColor;
        stageJudgeNumber = stageJudge.stageNumberCheck();
    }

    void Update()
    {
        if(stageJudgeNumber>0 || stageJudgeNumber<13){
            NowAnm();
        }
    }

    void NowAnm()
    {
        switch(stageJudgeNumber)
        {
            case 1:
                stageTrueAnimator = GameObject.Find("Stage1").GetComponent<Animator>();
                break;
            case 2:
                stageTrueAnimator = GameObject.Find("Stage2").GetComponent<Animator>();
                break;
            case 3:
                stageTrueAnimator = GameObject.Find("Stage3").GetComponent<Animator>();
                break;
            case 4:
                stageTrueAnimator = GameObject.Find("Stage4").GetComponent<Animator>();
                break;
            case 5:
                stageTrueAnimator = GameObject.Find("Stage5").GetComponent<Animator>();
                break;
            case 6:
                stageTrueAnimator = GameObject.Find("Stage6").GetComponent<Animator>();
                break;
            case 7:
                stageTrueAnimator = GameObject.Find("Stage7").GetComponent<Animator>();
                break;
            case 8:
                stageTrueAnimator = GameObject.Find("Stage8").GetComponent<Animator>();
                break;
            case 9:
                stageTrueAnimator = GameObject.Find("Stage9").GetComponent<Animator>();
                break;
            case 10:
                stageTrueAnimator = GameObject.Find("Stage10").GetComponent<Animator>();
                break;
            case 11:
                stageTrueAnimator = GameObject.Find("Stage11").GetComponent<Animator>();
                break;
            case 12:
                stageTrueAnimator = GameObject.Find("Stage12").GetComponent<Animator>();
                break;
        }
        stageTrueAnimator.enabled = true;
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