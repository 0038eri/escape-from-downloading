using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScn : MonoBehaviour
{
    private int stageJudgeNumber = 0;

    private void Start()
    {
        stageJudgeNumber = StageJudgeManager.Instance.stageNumberCheck();
    }

    private void Update()
    {
        // クリックした時
        if (Input.GetMouseButtonDown(0)){
            StageJudgeManager.Instance.sceneTransition();
        }

    }

}