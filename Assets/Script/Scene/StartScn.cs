using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class StartScn : MonoBehaviour
{
    private int stageJudgeNumber = 0;
    private float fadeTime = 2.0f;

    private void Start()
    {
        SoundManager.Instance.playBgm();
        stageJudgeNumber = StageJudgeManager.Instance.stageNumberCheck();
    }

    private void Update()
    {
        // クリックした時
        if (Input.GetMouseButtonDown(0))
        {
            FadeAnimation.Instance.goFadeOut();
            StartCoroutine(nextScnCoroutine());
        }

    }

    IEnumerator nextScnCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        StageJudgeManager.Instance.sceneTransition();
    }

}