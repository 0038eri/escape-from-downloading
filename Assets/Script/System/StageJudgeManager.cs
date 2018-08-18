using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageJudgeManager : SingletonMonoBehaviour<StageJudgeManager> {

    public static int stageJudge = 0;

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

}