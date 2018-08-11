using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageJudge : MonoBehaviour {

    public static int stageJudge = 0;

    private GameObject[] stageObj;

    void Awake()
    {
        stageObj[0] = GameObject.Find("Stage1Obj");
        stageObj[1] = GameObject.Find("Stage2Obj");
        stageObj[2] = GameObject.Find("Stage3Obj");
        stageObj[3] = GameObject.Find("Stage4Obj");
        stageObj[4] = GameObject.Find("Stage5Obj");
        stageObj[5] = GameObject.Find("Stage6Obj");
        stageObj[6] = GameObject.Find("Stage7Obj");
        stageObj[7] = GameObject.Find("Stage8Obj");
        stageObj[8] = GameObject.Find("Stage9Obj");
        stageObj[9] = GameObject.Find("Stage10Obj");
        stageObj[10] = GameObject.Find("Stage11Obj");
        stageObj[11] = GameObject.Find("Stage12Obj");
    }

    // Startシーンで呼ぶ
    public int stageNumberCheck()
    {
        return stageJudge;
    }

    // 以前クリアしたことのないステージでクリアした際に呼び出す
    public void stageJudgeCount()
    {
        if (stageJudge < 13)
        {
            stageJudge++;
        }
    }

    public void checkNowClearStage()
    {
        switch(stageJudge)
        {
            case 1:
                stageObj[0].SendMessage("clearOne");
                break;
            case 2:
                stageObj[1].SendMessage("clearTwo");
                break;
            case 3:
                stageObj[2].SendMessage("clearThree");
                break;
            case 4:
                stageObj[3].SendMessage("clearFour");
                break;
            case 5:
                stageObj[4].SendMessage("clearSix");
                break;
            case 6:
                stageObj[5].SendMessage("clearSeven");
                break;
            case 7:
                stageObj[6].SendMessage("clearSeven");
                break;
            case 8:
                stageObj[7].SendMessage("clearEight");
                break;
            case 9:
                stageObj[8].SendMessage("clearNine");
                break;
            case 10:
                stageObj[9].SendMessage("clearTen");
                break;
            case 11:
                stageObj[10].SendMessage("clearEleven");
                break;
            case 12:
                stageObj[11].SendMessage("clearEleven");
                break;
            default:
                break;
        }
    }

}