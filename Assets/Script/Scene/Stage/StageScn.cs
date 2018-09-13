using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StageScn : MonoBehaviour {

    public GameObject gameStart;
    private float fadeTime = 2.0f;

    private void Start()
    {
        FadeAnimation.Instance.goFadeIn();
        PlayerStateManager.Instance.beforeGameMethod();
        StartCoroutine(startMethodS());
    }

    IEnumerator startMethodS()
    {
        yield return new WaitForSeconds(fadeTime);
        Debug.Log("hogehoge");
        gameStart.SetActive(true);
        SoundManager.Instance.playBgm();
    }

}