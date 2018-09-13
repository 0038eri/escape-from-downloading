using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class OpeningScn : MonoBehaviour {

    private float fadeTime = 2.0f;

    void Start()
    {
        FadeAnimation.Instance.goFadeIn();
        StartCoroutine(openingCoroutine());
    }

    IEnumerator openingCoroutine()
    {
        yield return new WaitForSeconds(fadeTime);
        SoundManager.Instance.playBgm();
    }

}