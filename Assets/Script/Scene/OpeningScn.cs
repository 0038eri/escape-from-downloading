using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningScn : MonoBehaviour {

    private float fadeTime;

    void Start()
    {
        fadeTime = FadeAnimation.Instance.valueFadeTime();
        FadeAnimation.Instance.goFadeIn();
        StartCoroutine(openingCoroutine());
    }

    IEnumerator openingCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SoundManager.Instance.playBgm();
    }

}