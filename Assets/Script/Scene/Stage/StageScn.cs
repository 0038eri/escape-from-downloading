using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScn : MonoBehaviour {

    private float fadeTime;

    private void Start()
    {
        fadeTime = FadeAnimation.Instance.valueFadeTime();
        FadeAnimation.Instance.goFadeIn();
        PlayerStateManager.Instance.beforeGameMethod();
        StartCoroutine(startMethodS());
    }

    IEnumerator startMethodS()
    {
        yield return new WaitForSeconds(fadeTime);
        GameStartAnimator.Instance.trueAnimation();
        SoundManager.Instance.playBgm();
    }

}