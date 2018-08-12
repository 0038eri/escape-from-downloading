using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageJudge : MonoBehaviour {

    public static int stageJudge = 0;

    private GameObject stageObj;

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
                stageObj = GameObject.Find("Stage1Obj");
                stageObj.SendMessage("clearOne");
                break;
            case 2:
                stageObj = GameObject.Find("Stage2Obj");
                stageObj.SendMessage("clearTwo");
                break;
            case 3:
                stageObj = GameObject.Find("Stage3Obj");
                stageObj.SendMessage("clearThree");
                break;
            case 4:
                stageObj = GameObject.Find("Stage4Obj");
                stageObj.SendMessage("clearFour");
                break;
            case 5:
                stageObj = GameObject.Find("Stage5Obj");
                stageObj.SendMessage("clearSix");
                break;
            case 6:
                stageObj = GameObject.Find("Stage6Obj");
                stageObj.SendMessage("clearSeven");
                break;
            case 7:
                stageObj = GameObject.Find("Stage7Obj");
                stageObj.SendMessage("clearSeven");
                break;
            case 8:
                stageObj = GameObject.Find("Stage8Obj");
                stageObj.SendMessage("clearEight");
                break;
            case 9:
                stageObj = GameObject.Find("Stage9Obj");
                stageObj.SendMessage("clearNine");
                break;
            case 10:
                stageObj = GameObject.Find("Stage10Obj");
                stageObj.SendMessage("clearTen");
                break;
            case 11:
                stageObj = GameObject.Find("Stage11Obj");
                stageObj.SendMessage("clearEleven");
                break;
            case 12:
                stageObj = GameObject.Find("Stage12Obj");
                stageObj.SendMessage("clearEleven");
                break;
            default:
                break;
        }
    }

}